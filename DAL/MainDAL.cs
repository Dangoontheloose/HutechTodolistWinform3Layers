using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class MainDAL
    {
        TDModel _context;
        List<TodoTask> tasks = new List<TodoTask>();

        public MainDAL()
        {
            _context = new TDModel();
        }
        /// <summary>
        /// Trả về Account tương ứng với Account ID ở tham số
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Account GetAccountFromID(int id)
        {
            using (TDModel _context = new TDModel())
            {

                var acc = (from s in _context.Accounts
                           where s.AccID == id
                           select s).FirstOrDefault<Account>();
                return acc;
            }

        }
        /// <summary>
        /// Trả về Account ID tương ứng với username và password ở tham số
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>Trả về ID nếu tìm được tk khớp và trả về -1 nếu không tìm được</returns>        
        /// <summary>
        /// Trả về List chứa tất cả task từ Account ở tham số
        /// </summary>
        /// <param name="account"></param>
        /// <returns>Trả về list todotask</returns>
        public int GetAccountIDFromLoginInput(string username, string password)
        {
            var acc = (from s in _context.Accounts
                       where s.Username == username && s.Password == password
                       select s).FirstOrDefault<Account>();

            if (acc == null)
            {
                return -1;
            }
            else
            {
                return acc.AccID;
            }
        }


        
        public List<TodoTask> GetTaskListFromAccount(Account account)
        {
            using (TDModel _context = new TDModel())
            {
                var acc = (from s in _context.Accounts where s.AccID == account.AccID select s).FirstOrDefault<Account>();
                List<TodoTask> list = acc.TodoTasks.ToList<TodoTask>();
                return list;

            }
        }

        /// <summary>
        /// Returns a task with the same TaskID from database
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TodoTask GetTaskByTaskID(int id)
        {
            using (TDModel _context = new TDModel())
            {

                var task = (from s in _context.TodoTasks where s.TaskID == id select s).First<TodoTask>();
                string stateName = task.State.StateName;
                return task;
            }
        }

        public string[] GetAllStateOptions()
        {
            using (TDModel _context = new TDModel())
            {
                var list = _context.States.ToList();
                string[] vs = new string[list.Count];
                
                foreach (var item in list)
                {
                    vs[item.StateID] = item.StateName;
                }

                return vs;
            }
        }

        public string[] GetAllPriorityOptions()
        {
            using (TDModel _context = new TDModel())
            {
                var list = _context.Priorities.ToList();
                string[] vs = new string[list.Count];

                foreach (var item in list)
                {
                    vs[item.PriID] = item.Des;
                }

                return vs;
            }
        }

        /// <summary>
        /// Hàm check tên username người dùng nhập vào để tạo tài khoản đã được sử dụng hay chưa
        /// </summary>
        /// <param name="username"></param>
        /// <returns>Trả về true nếu chưa tồn tại, ngược lại trả về false</returns>
        public bool AccountUsernameAvailable(string username)
        {
            using (TDModel _context = new TDModel())
            {
                var acc = _context.Accounts.Where(s => s.Username == username).FirstOrDefault();
                return (acc == null);
            }
        }

        /// <summary>
        /// Xóa task khỏi database 
        /// </summary>
        /// <param name="task"></param>
        /// <returns></returns>
        public bool DeleteTask(TodoTask task)
        {
            using (TDModel _context = new TDModel())
            {
                var ogTask = (from s in _context.TodoTasks where s.TaskID == task.TaskID select s).FirstOrDefault<TodoTask>();
                _context.TodoTasks.Remove(ogTask);
                try
                {
                    _context.SaveChanges();
                }
                catch (Exception)
                {

                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Cập nhật trạng thái hoàn thành task vào database dựa trên Task ID và state
        /// </summary>
        /// <param name="id"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public bool UpdateTaskStateByTaskID(int id, int progress, int state, DateTime? fin)
        {
            using (TDModel _context = new TDModel())
            {
                var task = _context.TodoTasks.Where(s => s.TaskID == id).FirstOrDefault();
                if(task == null) { return false; }

                task.Progress = progress;
                task.StateID = state;
                task.FinishDate = fin;

                _context.SaveChanges();
            }
            return true;
        }
        /// <summary>
        /// Tạo account mới và lưu vào database dựa trên username và password tham số
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>Trả về trạng thái thành công</returns>
        public bool CreateAcc(string username, string password)
        {
            Account account = new Account
            {
                Username = username,
                Password = password
            };

            using (TDModel _context = new TDModel())
            {
                _context.Accounts.Add(account);
                _context.SaveChanges();
                //try
                //{
                //}
                //catch (Exception e)
                //{
                    
                //    return false;
                //}
            }
            return true;

        }
        /// <summary>
        /// Tạo mới hoặc update task cũ dựa trên tham số object Task
        /// </summary>
        /// <param name="task"></param>
        /// <returns></returns>
        public bool UpdateTask(TodoTask task)
        {
            using (TDModel _context = new TDModel())
            {

                //var ogTask = GetTaskByTaskID(task.TaskID);
                var ogTask = (from s in _context.TodoTasks where s.TaskID == task.TaskID select s).FirstOrDefault<TodoTask>();
                //Nếu không tìm được task dựa trên ID => tạo task mới
                if (ogTask == null)
                {
                    ogTask = new TodoTask
                    {
                        Taskname        = task.Taskname,
                        TaskDescription = task.TaskDescription,
                        PriID        = task.PriID,
                        DueDate         = task.DueDate,
                        Progress        = task.Progress,
                        StateID           = task.StateID,
                        AccID           = task.AccID,
                    };

                    _context.TodoTasks.Add(ogTask);
                }
                else
                {
                    ogTask.Taskname         = task.Taskname;
                    ogTask.TaskDescription  = task.TaskDescription;
                    ogTask.Progress         = task.Progress;
                    ogTask.PriID            = task.PriID;
                    ogTask.DueDate          = task.DueDate;
                    ogTask.StateID          = task.StateID;
                }

                try
                {
                    _context.SaveChanges();
                }
                catch (Exception e)
                {

                    e.ToString();
                    return false;
                }
            }
            return true;
        }
    }
}
