using BAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class UserDetails : Form
    {
        public string Username { get => txt_Username.Text; set => txt_Username.Text = value; }
        public string Password { get => txt_Password.Text; set => txt_Password.Text = value; }
        public int AuditState { get => chbox_isAuditted.Checked ? 1 : 0; set => chbox_isAuditted.Checked = (value == 1); }

        UserDetailsBAL bal_details;




        public event EventHandler UserUpdated;

        public UserDetails(int accID)
        {
            InitializeComponent();
            bal_details = new UserDetailsBAL(accID);
        }

        public void LoadActivityList()
        {
            dataGridView1.DataSource = bal_details.UserDetail_GetActivityList();
        }

        private void LoadLabel()
        {
            this.Username = bal_details.UserDetail_GetUsername();
            this.AuditState = bal_details.UserDetail_GetAuditState();
        }

        private void UserDetails_Load(object sender, EventArgs e)
        {
            LoadLabel();
            LoadActivityList();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (Username == "" || Password == "")
            {
                MessageBox.Show("Username và mật khẩu không được để trống!");
            }
            else
            { 
                int state = bal_details.UserDetail_UpdateAccountByInput(Username, Password, AuditState);
                if (state == 1)
                {
                    OnUserUpdated();
                    this.Close();
                }
            }
        }

        protected virtual void OnUserUpdated() => UserUpdated?.Invoke(this, EventArgs.Empty);

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Confirm delete user?", "Confirm", buttons: MessageBoxButtons.OKCancel);
            if (DialogResult == DialogResult.OK)
            {
                if (bal_details.UserDetail_DeleteTask())
                {
                    OnUserUpdated();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Xóa tài khoản thất bại!");
                }
            }
        }
    }
}
