
namespace GUI
{
    partial class MainAdmin
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
            this.dgv_list = new System.Windows.Forms.DataGridView();
            this.btn_AddNewUser = new System.Windows.Forms.Button();
            this.btn_AddNewTask = new System.Windows.Forms.Button();
            this.btn_userList = new System.Windows.Forms.Button();
            this.btn_TaskList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_list
            // 
            this.dgv_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_list.Location = new System.Drawing.Point(12, 171);
            this.dgv_list.Name = "dgv_list";
            this.dgv_list.ReadOnly = true;
            this.dgv_list.RowHeadersWidth = 51;
            this.dgv_list.RowTemplate.Height = 24;
            this.dgv_list.Size = new System.Drawing.Size(980, 267);
            this.dgv_list.TabIndex = 0;
            this.dgv_list.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_list_CellDoubleClick);
            // 
            // btn_AddNewUser
            // 
            this.btn_AddNewUser.Location = new System.Drawing.Point(718, 12);
            this.btn_AddNewUser.Name = "btn_AddNewUser";
            this.btn_AddNewUser.Size = new System.Drawing.Size(127, 56);
            this.btn_AddNewUser.TabIndex = 1;
            this.btn_AddNewUser.Text = "Add new user";
            this.btn_AddNewUser.UseVisualStyleBackColor = true;
            this.btn_AddNewUser.Click += new System.EventHandler(this.btn_AddNewUser_Click);
            // 
            // btn_AddNewTask
            // 
            this.btn_AddNewTask.Location = new System.Drawing.Point(865, 12);
            this.btn_AddNewTask.Name = "btn_AddNewTask";
            this.btn_AddNewTask.Size = new System.Drawing.Size(127, 56);
            this.btn_AddNewTask.TabIndex = 1;
            this.btn_AddNewTask.Text = "Add new task";
            this.btn_AddNewTask.UseVisualStyleBackColor = true;
            this.btn_AddNewTask.Click += new System.EventHandler(this.btn_AddNewTask_Click);
            // 
            // btn_userList
            // 
            this.btn_userList.Location = new System.Drawing.Point(12, 12);
            this.btn_userList.Name = "btn_userList";
            this.btn_userList.Size = new System.Drawing.Size(127, 56);
            this.btn_userList.TabIndex = 1;
            this.btn_userList.Text = "User list";
            this.btn_userList.UseVisualStyleBackColor = true;
            this.btn_userList.Click += new System.EventHandler(this.btn_userList_Click);
            // 
            // btn_TaskList
            // 
            this.btn_TaskList.Location = new System.Drawing.Point(161, 12);
            this.btn_TaskList.Name = "btn_TaskList";
            this.btn_TaskList.Size = new System.Drawing.Size(127, 56);
            this.btn_TaskList.TabIndex = 1;
            this.btn_TaskList.Text = "Task list";
            this.btn_TaskList.UseVisualStyleBackColor = true;
            this.btn_TaskList.Click += new System.EventHandler(this.btn_TaskList_Click);
            // 
            // MainAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 450);
            this.Controls.Add(this.btn_AddNewTask);
            this.Controls.Add(this.btn_TaskList);
            this.Controls.Add(this.btn_userList);
            this.Controls.Add(this.btn_AddNewUser);
            this.Controls.Add(this.dgv_list);
            this.Name = "MainAdmin";
            this.Text = "MainAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_list;
        private System.Windows.Forms.Button btn_AddNewUser;
        private System.Windows.Forms.Button btn_AddNewTask;
        private System.Windows.Forms.Button btn_userList;
        private System.Windows.Forms.Button btn_TaskList;
    }
}