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

    public partial class DetailForm : Form
    {

        enum FormState
        {
            EditExisting,
            AddNew
        }
        //Trạng thái của form detail(edit task cũ hoặc tạo task mới)
        private FormState f_state;
        //property Taskname set, get giá trị từ textbox Taskname
        public string Taskname { get => txt_TaskName.Text; set => txt_TaskName.Text = value; }
        //property Description set, get giá trị từ textbox Description
        public string Description { get => rtb_Description.Text; set => rtb_Description.Text = value; }
        //property DueDate set, get giá trị từ datetimepicker DueDate
        public DateTime DueDate { get => dtp_DueDate.Value; set => dtp_DueDate.Value = value; }
        //property Priority set, get giá trị từ combobox Priority
        public int Priority { get => cb_Priority.SelectedIndex; set => cb_Priority.SelectedIndex = value; }
        //property Progress lấy giá trị trả về từ check box
        public int Progress { get => chb_Progress.Checked ? 1 : 0; set => chb_Progress.Checked = (value == 1); }

        //public int State { get => Convert.ToInt32(lb_state.Text); set => lb_state.Text = value.ToString(); }
        public string StateName { get => lb_state.Text; set => lb_state.Text = value; }
        DetailBAL bal_detail;


        public event EventHandler TaskUpdated;


        public DetailForm(int accID)
        {
            f_state = FormState.AddNew;
            bal_detail = new DetailBAL(accID);
            InitializeComponent();
            LoadPriorityCombobox();
        }


        public DetailForm(int accID, int taskID)
        {
            f_state = FormState.EditExisting;
            bal_detail = new DetailBAL(accID, taskID);
            InitializeComponent();
            LoadPriorityCombobox();
        }
        private void LoadPriorityCombobox()
        {
            string[] priorityList = bal_detail.Detail_GetPriorityRange();
            cb_Priority.Items.AddRange(priorityList);
        }
        private void LoadLabel()
        {
            this.Taskname = bal_detail.Detail_GetTaskName();
            this.Description = bal_detail.Detail_GetTaskDesc();
            this.Priority = bal_detail.Detail_GetPrio();
            this.DueDate = bal_detail.Detail_GetDueDate();
            this.Progress = bal_detail.Detail_GetProgress();
            //this.State = bal_detail.Detail_GetStateID();
            this.StateName = bal_detail.Detail_GetStateName();

        }

        private void DetailForm_Load(object sender, EventArgs e)
        {
            if (f_state == FormState.EditExisting)
            {
                LoadLabel();
            }
            else
            {
                this.btn_Delete.Enabled = false;
                this.Progress = 0;
                this.Priority = 2;
            }
        }


        private void btn_Save_Click(object sender, EventArgs e)
        {
            int state = bal_detail.Detail_UpateTaskByUserInput(Taskname, Description, Priority, DueDate, Progress);
            //MessageBox.Show(state.ToString());
            if (state == 1)
            {
                OnTaskUpdated();
                this.Close();
            }
        }
        protected virtual void OnTaskUpdated() => TaskUpdated?.Invoke(this, EventArgs.Empty);





        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Confirm delete Task?", "Confirm", buttons: MessageBoxButtons.OKCancel);
            if (DialogResult == DialogResult.OK)
            {
                if (bal_detail.Detail_DeleteTask())
                {
                    OnTaskUpdated();
                    this.Close();
                }
            }
        }

        private void cb_Priority_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_State_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
