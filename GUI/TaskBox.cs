using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DevExpress.Utils.Layout;

namespace GUI
{
    public partial class TaskBox : UserControl
    {
        public string Taskname { get => lb_Taskname.Text; set => lb_Taskname.Text = value; }
        public string Description { get => lb_Description.Text; set => lb_Description.Text = value; }

        public DateTime DueDate { get => dtp_DueDate.Value; set => dtp_DueDate.Value = value; }
        public DateTime? FinishDate { get; set; }
        public int Progress { get => checkBox1.Checked ? 1 : 0; set => checkBox1.Checked = (value == 1); }
        public int StateID { get => 1; set => label1.Text = (value == 3) ? "Overdue" : ""; }
        public int TaskboxID { get; set; }
        public string Priority { get => lb_Priority.Text; set => lb_Priority.Text = value; }
        public TaskBox(TodoTask task)
        {
            InitializeComponent();
            this.Taskname = task.Taskname;
            this.Description = task.TaskDescription;
            this.DueDate = task.DueDate;
            this.Progress = task.Progress;
            this.FinishDate = task.FinishDate;
            this.StateID = task.StateID;
            SetPrioLabel(task.PriID);

            TaskboxID = task.TaskID;
        }

        private void SetPrioLabel(int prio)
        {
            switch (prio)
            {
                case 0:
                    Priority = "!!!";
                    lb_Priority.ForeColor = Color.Red;
                    break;
                case 1:
                    Priority = "!!";
                    lb_Priority.ForeColor = Color.Orange;
                    break;
                default:
                    lb_Priority.ForeColor = Color.Blue;
                    Priority = "!";
                    break;
            }
        }






        //public new event EventHandler<TaskboxEventArgs> DoubleClick;

        //protected override void OnDoubleClick(EventArgs e)
        //{
        //    TaskboxEventArgs args = new TaskboxEventArgs();
        //    args.TaskboxID = this.TaskboxID;

        //    var handler = DoubleClick;
        //    if (handler != null)
        //    {
        //        handler(this, args);
        //    }
        //    base.OnDoubleClick(e);
        //}

        public class TaskboxEventArgs : EventArgs
        {
            public int TaskboxID { get; set; }
        }

        private void editTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnDoubleClick(EventArgs.Empty);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            OnCheckedChanged();
        }



        public event EventHandler CheckedChanged;

        protected virtual void OnCheckedChanged() => CheckedChanged?.Invoke(this, EventArgs.Empty);

        
    }
}
