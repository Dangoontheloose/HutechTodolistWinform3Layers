using System.Windows.Forms;

namespace GUI
{
    partial class TaskBox
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lb_Taskname = new System.Windows.Forms.Label();
            this.lb_Description = new System.Windows.Forms.Label();
            this.dtp_DueDate = new System.Windows.Forms.DateTimePicker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Priority = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Taskname
            // 
            this.lb_Taskname.AutoSize = true;
            this.lb_Taskname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Taskname.Location = new System.Drawing.Point(3, 73);
            this.lb_Taskname.Name = "lb_Taskname";
            this.lb_Taskname.Size = new System.Drawing.Size(52, 17);
            this.lb_Taskname.TabIndex = 1;
            this.lb_Taskname.Text = "label2";
            // 
            // lb_Description
            // 
            this.lb_Description.AutoSize = true;
            this.lb_Description.Location = new System.Drawing.Point(14, 96);
            this.lb_Description.Name = "lb_Description";
            this.lb_Description.Size = new System.Drawing.Size(35, 13);
            this.lb_Description.TabIndex = 1;
            this.lb_Description.Text = "label2";
            // 
            // dtp_DueDate
            // 
            this.dtp_DueDate.Enabled = false;
            this.dtp_DueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DueDate.Location = new System.Drawing.Point(3, 27);
            this.dtp_DueDate.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.dtp_DueDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtp_DueDate.Name = "dtp_DueDate";
            this.dtp_DueDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtp_DueDate.Size = new System.Drawing.Size(100, 26);
            this.dtp_DueDate.TabIndex = 2;
            this.dtp_DueDate.Value = new System.DateTime(2020, 11, 11, 3, 34, 56, 0);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editTaskToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(120, 26);
            // 
            // editTaskToolStripMenuItem
            // 
            this.editTaskToolStripMenuItem.Name = "editTaskToolStripMenuItem";
            this.editTaskToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.editTaskToolStripMenuItem.Text = "Edit Task";
            this.editTaskToolStripMenuItem.Click += new System.EventHandler(this.editTaskToolStripMenuItem_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 6);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(52, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Done";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(16, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 4;
            // 
            // lb_Priority
            // 
            this.lb_Priority.AutoSize = true;
            this.lb_Priority.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Priority.Location = new System.Drawing.Point(14, 1);
            this.lb_Priority.Name = "lb_Priority";
            this.lb_Priority.Size = new System.Drawing.Size(70, 25);
            this.lb_Priority.TabIndex = 5;
            this.lb_Priority.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_Priority);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(127, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(91, 154);
            this.panel1.TabIndex = 6;
            // 
            // TaskBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dtp_DueDate);
            this.Controls.Add(this.lb_Description);
            this.Controls.Add(this.lb_Taskname);
            this.Name = "TaskBox";
            this.Size = new System.Drawing.Size(218, 154);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Taskname;
        private System.Windows.Forms.Label lb_Description;
        private System.Windows.Forms.DateTimePicker dtp_DueDate;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editTaskToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Priority;
        private Panel panel1;
    }
}
