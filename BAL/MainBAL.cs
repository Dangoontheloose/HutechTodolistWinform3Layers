using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BAL
{
    public class MainBAL
    {
        public enum SortType
        {
            Default,
            DueDate,
            Priority,
        }

        public enum TaskState
        {
            Today,
            Upcoming,
            Past,
        }

        MainDAL dal = new MainDAL();
        Account activeAccount = new Account();
        List<TodoTask> activeTasks = new List<TodoTask>();

        //lấy dữ liệu của account đc login thông qua id được truyền từ form login 
        public MainBAL(int id)
        {
            SetActiveAccount(dal.GetAccountFromID(id));
        }

        public string[] Main_GetPriorityRange()
        {
            return dal.GetAllPriorityOptions();
        }

        //tra list cac task ve View de load vao flowpanel
        /// <summary>
        /// Trả về list chứa các task từ account đang đăng nhập hiện tại và được sắp xếp dựa trên 2 filter từ tham số
        /// </summary>
        /// <returns>Returns a list of Task sorted by descending (Priority, DueDate) or default and completed or incomplete</returns>
        public List<TodoTask> Main_LoadList(SortType sortType, int listType)
        {
            //reload active account
            SetActiveAccount(dal.GetAccountFromID(activeAccount.AccID));

            //reload list chứa toàn bộ task trong account
            activeTasks = dal.GetTaskListFromAccount(activeAccount);
            List<TodoTask> returnTasks = new List<TodoTask>();

            switch (listType)
            {
                case 0:
                    returnTasks = activeTasks.Where(s => s.DueDate.Date == DateTime.Today && s.Progress == 0).ToList();
                    break;
                case 1:
                    returnTasks = activeTasks.Where(s => s.DueDate.Date > DateTime.Today && s.Progress == 0).ToList();
                    break;
                case 2:
                default:
                    returnTasks = activeTasks.Where(s => s.DueDate.Date < DateTime.Today || s.Progress == 1).ToList();
                    break;
            }


            //returnTasks = activeTasks;



            switch (sortType)
            {
                case SortType.Default:
                    //Filter mặc định => sắp xếp theo bảng chữ cái tăng dần
                    returnTasks = returnTasks.OrderBy(s => s.Taskname).ToList();
                    break;
                case SortType.DueDate:
                    //Filter theo ngày hạn => sắp xếp theo ngày hạn gần nhất -> xa nhất
                    returnTasks = returnTasks.OrderBy(s => s.DueDate).ToList();
                    break;
                case SortType.Priority:
                    //Filter theo mức quan trọng => sắp xếp theo mức quan trọng giảm dần
                    returnTasks = returnTasks.OrderBy(s => s.PriID).ToList();
                    break;
                default:
                    break;
            }

            //return activeTasks;
            return returnTasks;
        }
        //hàm cập nhật trạng thái hoàn thành được gọi trực tiếp từ Main(thông qua các TaskBox)
        public bool Main_UpdateTaskState(int taskID, int progress, DateTime dueDate, DateTime? finishDate)
        {
            if (progress == 0)
            {
                finishDate = null;
                if (activeAccount.AuditState == 1)
                {

                    UserActivity userActivity = new UserActivity()
                    {
                        AccID = dal.GetAccountIDFromUsername(activeAccount.Username),
                        Datetime = DateTime.Now,
                        Activity = "Xóa trạng thái hoàn thành [" + taskID + "]"
                    };
                    if (!dal.UpdateActivity(userActivity)) { Console.WriteLine("Loi luu activity"); };
                }
            }
            if (progress == 1 && finishDate == null)
            {
                finishDate = DateTime.Today;
                if (activeAccount.AuditState == 1)
                {
                    UserActivity userActivity = new UserActivity()
                    {
                        AccID = dal.GetAccountIDFromUsername(activeAccount.Username),
                        Datetime = DateTime.Now,
                        Activity = "Hoàn thành task [" + taskID + "]"
                    };
                    if (!dal.UpdateActivity(userActivity)) { Console.WriteLine("Loi luu activity"); };
                }
            }
            int state = UpdateStateByProgressAndDate(progress, dueDate, finishDate);

            return dal.UpdateTaskStateByTaskID(taskID, progress, state, finishDate);
        }

        public int UpdateStateByProgressAndDate(int progress, DateTime due, DateTime? finish)
        {
            if (progress == -1)
            {
                return 0;
            }
            if (progress == 1)//TH hoan thanh
            {
                //date finish sau due date => 4(xong tre han) otherwise 2(xong dung han)
                return finish.Value.Date > due.Date ? 4 : 2;
            }
            else//TH chua hoan thanh
            {
                //da qua due date => 3(tre han) otherwise 1(dang trong tien trinh (con han))
                return due.Date >= DateTime.Today ? 1 : 3;
            }

        }

        private void SetActiveAccount(Account account)
        {
            activeAccount = account;
        }

        public string LoadUserName()
        {
            return activeAccount.Username;
        }

        public void Main_LogOut()
        {
            if (activeAccount.AuditState == 1)
            {
                UserActivity userActivity = new UserActivity()
                {
                    AccID = activeAccount.AccID,
                    Datetime = DateTime.Now,
                    Activity = "User đăng xuất"
                };
                if (!dal.UpdateActivity(userActivity)) { Console.WriteLine("loi luu activity"); };
            }
        }
    }
}
