using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class UserDetailsBAL
    {
        MainDAL dal = new MainDAL();

        Account activeAccount;
        public UserDetailsBAL(int accID)
        {
            activeAccount = dal.GetAccountFromID(accID);
        }

        public string UserDetail_GetUsername() { return activeAccount.Username; }
        public int UserDetail_GetAuditState() { return activeAccount.AuditState; }

        public int UserDetail_UpdateAccountByInput(string username, string password, int auditState)
        {
            activeAccount.Username = username;
            activeAccount.Password = Encrypt.MD5Hash(password);
            activeAccount.AuditState = auditState;

            if (dal.UpdateAccount(activeAccount))
            {
                return 1;
            }
            else
            {
                return -1;
            }

        }

        public List<ActivityView> UserDetail_GetActivityList()
        {
            List<UserActivity> list = dal.GetActivityList(activeAccount.AccID);
            List<ActivityView> viewList = new List<ActivityView>();

            foreach (var item in list)
            {
                ActivityView view = new ActivityView()
                {
                    ActivityID = item.ActivityID,
                    Activity = item.Activity,
                    DateTime = item.Datetime
                };
                viewList.Add(view);
            }
            return viewList;
        }

        public bool UserDetail_DeleteTask()
        {
            return dal.DeleteUser(activeAccount);
        }
    }
}
