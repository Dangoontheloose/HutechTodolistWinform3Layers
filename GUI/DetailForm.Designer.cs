namespace GUI
{
    partial class DetailForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_TaskName = new System.Windows.Forms.TextBox();
            this.dtp_DueDate = new System.Windows.Forms.DateTimePicker();
            this.cb_Priority = new System.Windows.Forms.ComboBox();
            this.rtb_Description = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.chb_Progress = new System.Windows.Forms.CheckBox();
            this.lb_state = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_Assignee = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txt_TaskName
            // 
            this.txt_TaskName.Location = new System.Drawing.Point(22, 42);
            this.txt_TaskName.Name = "txt_TaskName";
            this.txt_TaskName.Size = new System.Drawing.Size(286, 22);
            this.txt_TaskName.TabIndex = 0;
            // 
            // dtp_DueDate
            // 
            this.dtp_DueDate.Location = new System.Drawing.Point(22, 222);
            this.dtp_DueDate.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.dtp_DueDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtp_DueDate.Name = "dtp_DueDate";
            this.dtp_DueDate.Size = new System.Drawing.Size(200, 22);
            this.dtp_DueDate.TabIndex = 3;
            // 
            // cb_Priority
            // 
            this.cb_Priority.FormattingEnabled = true;
            this.cb_Priority.Location = new System.Drawing.Point(22, 290);
            this.cb_Priority.Name = "cb_Priority";
            this.cb_Priority.Size = new System.Drawing.Size(121, 24);
            this.cb_Priority.TabIndex = 4;
            this.cb_Priority.SelectedIndexChanged += new System.EventHandler(this.cb_Priority_SelectedIndexChanged);
            // 
            // rtb_Description
            // 
            this.rtb_Description.Location = new System.Drawing.Point(22, 110);
            this.rtb_Description.Name = "rtb_Description";
            this.rtb_Description.Size = new System.Drawing.Size(286, 69);
            this.rtb_Description.TabIndex = 1;
            this.rtb_Description.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Task name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Due date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Priority";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(170, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "State";
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(334, 42);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 65);
            this.btn_Save.TabIndex = 7;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(334, 249);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 65);
            this.btn_Delete.TabIndex = 7;
            this.btn_Delete.Text = "Delete Task";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // chb_Progress
            // 
            this.chb_Progress.AutoSize = true;
            this.chb_Progress.Location = new System.Drawing.Point(218, 292);
            this.chb_Progress.Name = "chb_Progress";
            this.chb_Progress.Size = new System.Drawing.Size(64, 21);
            this.chb_Progress.TabIndex = 8;
            this.chb_Progress.Text = "Done";
            this.chb_Progress.UseVisualStyleBackColor = true;
            // 
            // lb_state
            // 
            this.lb_state.AutoSize = true;
            this.lb_state.Location = new System.Drawing.Point(165, 270);
            this.lb_state.Name = "lb_state";
            this.lb_state.Size = new System.Drawing.Size(46, 17);
            this.lb_state.TabIndex = 9;
            this.lb_state.Text = "label3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(331, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 68);
            this.label7.TabIndex = 10;
            this.label7.Text = "Priority: \r\nHigh = !!!\r\nMedium = !!\r\nLow = !";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Assignee";
            // 
            // cb_Assignee
            // 
            this.cb_Assignee.FormattingEnabled = true;
            this.cb_Assignee.Location = new System.Drawing.Point(22, 352);
            this.cb_Assignee.Name = "cb_Assignee";
            this.cb_Assignee.Size = new System.Drawing.Size(121, 24);
            this.cb_Assignee.TabIndex = 12;
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 400);
            this.Controls.Add(this.cb_Assignee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lb_state);
            this.Controls.Add(this.chb_Progress);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtb_Description);
            this.Controls.Add(this.cb_Priority);
            this.Controls.Add(this.dtp_DueDate);
            this.Controls.Add(this.txt_TaskName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Todolist - Detail";
            this.Load += new System.EventHandler(this.DetailForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_TaskName;
        private System.Windows.Forms.DateTimePicker dtp_DueDate;
        private System.Windows.Forms.ComboBox cb_Priority;
        private System.Windows.Forms.RichTextBox rtb_Description;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.CheckBox chb_Progress;
        private System.Windows.Forms.Label lb_state;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_Assignee;
    }
}