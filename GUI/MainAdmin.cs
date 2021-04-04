using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;

namespace GUI
{
    public partial class MainAdmin : Form
    {
        private int accID;
        private int currentList;
        AdminMainBAL bal;

        //List<AccountView> accountList = new List<AccountView>();
        //List<TaskView> taskList = new List<TaskView>();
        public MainAdmin(int accID)
        {
            InitializeComponent();
            bal = new AdminMainBAL(accID);
            this.accID = accID;
        }

        private void btn_userList_Click(object sender, EventArgs e)
        {
            //accountList = bal.GetAccountList();
            dgv_list.DataSource = bal.GetAccountList();
            currentList = 1;
        }
        private void btn_TaskList_Click(object sender, EventArgs e)
        {
            //taskList = bal.GetTaskList();
            dgv_list.DataSource = bal.GetTaskList();
            currentList = 2;
        }


        private void btn_AddNewUser_Click(object sender, EventArgs e)
        {
            CreateUserForm form = new CreateUserForm();
            form.Show();
        }

        private void dgv_list_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (currentList == 1)
            {
                int accId = Convert.ToInt32(dgv_list.Rows[e.RowIndex].Cells[0].Value);
                UserDetails f = new UserDetails(accId);
                f.UserUpdated += F_UserUpdated;
                f.Show();
            }
            else
            {
                int taskId = Convert.ToInt32(dgv_list.Rows[e.RowIndex].Cells[0].Value);
                int accId = Convert.ToInt32(dgv_list.Rows[e.RowIndex].Cells[2].Value);
                DetailForm f = new DetailForm(accId, taskId, 0);
                f.TaskUpdated += F_TaskUpdated;
                f.Show();
            }
        }

        private void F_TaskUpdated(object sender, EventArgs e)
        {
            dgv_list.DataSource = bal.GetTaskList();
        }

        private void F_UserUpdated(object sender, EventArgs e)
        {
            dgv_list.DataSource = bal.GetAccountList();
        }

        private void btn_AddNewTask_Click(object sender, EventArgs e)
        {
            DetailForm f = new DetailForm(accID);
            //subscribe event mỗi khi task đã được update (tạo mới) qua form detail
            f.TaskUpdated += F_TaskUpdated;
            f.Show();
        }
    }
}
