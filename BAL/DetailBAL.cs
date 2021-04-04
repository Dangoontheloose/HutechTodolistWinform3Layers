using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DAL;
using DTO;

namespace BAL
{
    public class DetailBAL
    {

        MainDAL dal = new MainDAL();

        TodoTask activeTask;
        Account activeAccount;



        //nếu khởi tạo bal có tham số task ID truyền vào => edit task đã tồn tại
        public DetailBAL(int accID, int taskID)
        {
            activeTask = dal.GetTaskByTaskID(taskID);//load task đang được edit
            activeAccount = dal.GetAccountFromID(accID);
        }

        //Nếu khởi tạo bal không có tham số task ID truyền vào => Tạo task mới
        public DetailBAL(int accID)
        {
            activeTask = new TodoTask();
            activeTask.AccID = accID;//gán task mới vs ID account đang được đăng nhập
        }

        /// <summary>
        /// Hàm nhận vào các giá trị người dùng nhập và update lại hoặc thêm mới task
        /// </summary>
        /// <param name="taskname"></param>
        /// <param name="des"></param>
        /// <param name="prio"></param>
        /// <param name="dueDate"></param>
        /// <param name="state"></param>
        /// <returns>Trả về trạng thái hoàn thành hoặc kiểu lỗi</returns>
        public int Detail_UpdateTaskByUserInput(string taskname, string des, int prio, DateTime dueDate, int progress, string assignee)
        {

            if (taskname == "") { return -1; } //lỗi Để trống Task name

            activeTask.Taskname = taskname;
            activeTask.TaskDescription = des;
            activeTask.PriID = prio;
            activeTask.DueDate = dueDate;
            activeTask.Progress = progress;
            activeTask.Username = assignee;
            //Nếu chuyển thành trạng thái không hoàn thành => xóa ngày hoàn thành
            if (progress == 0)
            {
                activeTask.FinishDate = null;
                if (dal.GetAuditStateFromUsername(assignee) == 1)
                {
                    UserActivity userActivity = new UserActivity()
                    {
                        AccID = dal.GetAccountIDFromUsername(assignee),
                        Datetime = DateTime.Now,
                        Activity = "Xóa trạng thái hoàn thành [" + activeTask.TaskID + "]"
                    };
                    if (!dal.UpdateActivity(userActivity)) { Console.WriteLine("loi luu activity"); };
                }
            }
            //Nếu chuyển thành trạng thái hoàn thành => thêm ngày hoàn thành là hôm nay
            if (progress == 1 && activeTask.FinishDate == null)
            {
                if (dal.GetAuditStateFromUsername(assignee) == 1)
                {
                    activeTask.FinishDate = DateTime.Today;
                    UserActivity userActivity = new UserActivity()
                    {
                        AccID = dal.GetAccountIDFromUsername(assignee),
                        Datetime = DateTime.Now,
                        Activity = "Hoàn thành task [" + activeTask.TaskID + "]"
                    };
                    if (!dal.UpdateActivity(userActivity)) { Console.WriteLine("loi luu activity"); };
                }

            }
            //Cho update State dựa trên progress, ngày hạn và ngày hoàn thành
            activeTask.StateID = UpdateStateByProgressAndDate(progress, dueDate, activeTask.FinishDate);

            if (!dal.UpdateTask(activeTask)) { return -3; } //lỗi update không thành công

            return 1;
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
                return finish > due ? 4 : 2;
            }
            else//TH chua hoan thanh
            {
                //da qua due date => 3(tre han) otherwise 1(dang trong tien trinh (con han))
                return due < DateTime.Today ? 3 : 1;
            }

        }
        /// <summary>
        /// Lấy tất cả các priority từ dữ liệu (để nạp vào combo box)
        /// </summary>
        /// <returns>Returns mảng string</returns>
        public string[] Detail_GetPriorityRange()
        {
            return dal.GetAllPriorityOptions();
        }

        public string[] Detail_GetAssigneeRange()
        {
            return dal.GetAllAssigneeOptions();
        }

        /// <summary>
        /// Hàm xóa task gọi từ form detail
        /// </summary>
        /// <returns></returns>
        public bool Detail_DeleteTask()
        {
            return dal.DeleteTask(activeTask);
        }

        public string Detail_GetTaskName() { return activeTask.Taskname; }
        public string Detail_GetTaskDesc() { return activeTask.TaskDescription; }
        public DateTime Detail_GetDueDate() { return activeTask.DueDate; }
        public int Detail_GetPrio() { return activeTask.PriID; }
        public int Detail_GetStateID() { return activeTask.StateID; }
        public string Detail_GetAssignee() { return activeTask.Username; }
        public string Detail_GetStateName()
        {
            return activeTask.State.StateName;
        }

        public int Detail_GetProgress() { return activeTask.Progress; }




    }
}
