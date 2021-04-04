using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class AdminMainBAL
    {
        int id;
        MainDAL dal = new MainDAL();
        List<Account> accountList = new List<Account>();
        List<AccountView> accViewList;
        List<TodoTask> taskList = new List<TodoTask>();
        List<TaskView> taskViewList;


        public AdminMainBAL(int id)
        {
            this.id = id;
        }

        public List<AccountView> GetAccountList()
        {
            accountList = dal.GetAllUserAccounts();
            accViewList = new List<AccountView>();
            foreach (var item in accountList)
            {
                AccountView accountView = new AccountView
                {
                    AccID = item.AccID,
                    Username = item.Username,
                    Password = item.Password,
                    Type = item.Type
                };

                accViewList.Add(accountView);
            }
            return accViewList;
        }

        public List<TaskView> GetTaskList()
        {
            taskList = dal.GetAllTasks();
            taskViewList = new List<TaskView>();
            foreach (var item in taskList)
            {
                TaskView taskView = new TaskView
                {
                    Assignee = item.Username,
                    AssigneeID = item.Account.AccID,
                    TaskID = item.TaskID,
                    Taskname = item.Taskname,
                    Progress = item.Progress == 0 ? "Unfinished" : "Finished",
                    Priority = item.Priority.Des,
                    DueDate = item.DueDate,
                    FinishDate = item.FinishDate
                };

                taskViewList.Add(taskView);
            }
            return taskViewList;
        }
    }

    
}
