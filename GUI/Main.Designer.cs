namespace GUI
{
    partial class Main
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
            this.btn_Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_DueCount = new System.Windows.Forms.Label();
            this.lb_AllCount = new System.Windows.Forms.Label();
            this.lb_UpcomingCount = new System.Windows.Forms.Label();
            this.lb_TodayCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_SignOut = new System.Windows.Forms.Button();
            this.btn_Past = new System.Windows.Forms.Button();
            this.btn_Upcoming = new System.Windows.Forms.Button();
            this.btn_Today = new System.Windows.Forms.Button();
            this.btn_All = new System.Windows.Forms.Button();
            this.flp_Past = new System.Windows.Forms.FlowLayoutPanel();
            this.lb_Past = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_SortType = new System.Windows.Forms.ComboBox();
            this.lb_content = new System.Windows.Forms.Label();
            this.flp_Today = new System.Windows.Forms.FlowLayoutPanel();
            this.lb_Upcoming = new System.Windows.Forms.Label();
            this.flp_Upcoming = new System.Windows.Forms.FlowLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(-1, 98);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(119, 50);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.Text = "New Task";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sort by";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lb_DueCount);
            this.panel1.Controls.Add(this.lb_AllCount);
            this.panel1.Controls.Add(this.lb_UpcomingCount);
            this.panel1.Controls.Add(this.lb_TodayCount);
            this.panel1.Controls.Add(this.btn_Add);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_SignOut);
            this.panel1.Controls.Add(this.btn_Past);
            this.panel1.Controls.Add(this.btn_Upcoming);
            this.panel1.Controls.Add(this.btn_Today);
            this.panel1.Controls.Add(this.btn_All);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 567);
            this.panel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 430);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Overdue Task(s):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "User name:";
            // 
            // lb_DueCount
            // 
            this.lb_DueCount.AutoSize = true;
            this.lb_DueCount.Location = new System.Drawing.Point(121, 430);
            this.lb_DueCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_DueCount.Name = "lb_DueCount";
            this.lb_DueCount.Size = new System.Drawing.Size(46, 17);
            this.lb_DueCount.TabIndex = 4;
            this.lb_DueCount.Text = "label4";
            // 
            // lb_AllCount
            // 
            this.lb_AllCount.AutoSize = true;
            this.lb_AllCount.Location = new System.Drawing.Point(121, 298);
            this.lb_AllCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_AllCount.Name = "lb_AllCount";
            this.lb_AllCount.Size = new System.Drawing.Size(46, 17);
            this.lb_AllCount.TabIndex = 4;
            this.lb_AllCount.Text = "label4";
            // 
            // lb_UpcomingCount
            // 
            this.lb_UpcomingCount.AutoSize = true;
            this.lb_UpcomingCount.Location = new System.Drawing.Point(121, 245);
            this.lb_UpcomingCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_UpcomingCount.Name = "lb_UpcomingCount";
            this.lb_UpcomingCount.Size = new System.Drawing.Size(46, 17);
            this.lb_UpcomingCount.TabIndex = 4;
            this.lb_UpcomingCount.Text = "label4";
            // 
            // lb_TodayCount
            // 
            this.lb_TodayCount.AutoSize = true;
            this.lb_TodayCount.Location = new System.Drawing.Point(121, 194);
            this.lb_TodayCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_TodayCount.Name = "lb_TodayCount";
            this.lb_TodayCount.Size = new System.Drawing.Size(46, 17);
            this.lb_TodayCount.TabIndex = 4;
            this.lb_TodayCount.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "label3";
            // 
            // btn_SignOut
            // 
            this.btn_SignOut.Location = new System.Drawing.Point(0, 498);
            this.btn_SignOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_SignOut.Name = "btn_SignOut";
            this.btn_SignOut.Size = new System.Drawing.Size(119, 55);
            this.btn_SignOut.TabIndex = 0;
            this.btn_SignOut.Text = "Sign out";
            this.btn_SignOut.UseVisualStyleBackColor = true;
            this.btn_SignOut.Click += new System.EventHandler(this.btn_SignOut_Click);
            // 
            // btn_Past
            // 
            this.btn_Past.Location = new System.Drawing.Point(-1, 373);
            this.btn_Past.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Past.Name = "btn_Past";
            this.btn_Past.Size = new System.Drawing.Size(119, 55);
            this.btn_Past.TabIndex = 0;
            this.btn_Past.Text = "Past";
            this.btn_Past.UseVisualStyleBackColor = true;
            this.btn_Past.Click += new System.EventHandler(this.btn_Past_Click);
            // 
            // btn_Upcoming
            // 
            this.btn_Upcoming.Location = new System.Drawing.Point(0, 225);
            this.btn_Upcoming.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Upcoming.Name = "btn_Upcoming";
            this.btn_Upcoming.Size = new System.Drawing.Size(119, 55);
            this.btn_Upcoming.TabIndex = 0;
            this.btn_Upcoming.Text = "Upcoming";
            this.btn_Upcoming.UseVisualStyleBackColor = true;
            this.btn_Upcoming.Click += new System.EventHandler(this.btn_Upcoming_Click);
            // 
            // btn_Today
            // 
            this.btn_Today.Location = new System.Drawing.Point(0, 175);
            this.btn_Today.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Today.Name = "btn_Today";
            this.btn_Today.Size = new System.Drawing.Size(119, 55);
            this.btn_Today.TabIndex = 0;
            this.btn_Today.Text = "Today";
            this.btn_Today.UseVisualStyleBackColor = true;
            this.btn_Today.Click += new System.EventHandler(this.btn_Today_Click);
            // 
            // btn_All
            // 
            this.btn_All.Location = new System.Drawing.Point(0, 278);
            this.btn_All.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_All.Name = "btn_All";
            this.btn_All.Size = new System.Drawing.Size(119, 55);
            this.btn_All.TabIndex = 0;
            this.btn_All.Text = "All";
            this.btn_All.UseVisualStyleBackColor = true;
            this.btn_All.Click += new System.EventHandler(this.btn_All_Click);
            // 
            // flp_Past
            // 
            this.flp_Past.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flp_Past.AutoScroll = true;
            this.flp_Past.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flp_Past.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flp_Past.Location = new System.Drawing.Point(20, 87);
            this.flp_Past.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flp_Past.Name = "flp_Past";
            this.flp_Past.Size = new System.Drawing.Size(300, 467);
            this.flp_Past.TabIndex = 0;
            this.flp_Past.WrapContents = false;
            this.flp_Past.Resize += new System.EventHandler(this.flp_Past_Resize);
            // 
            // lb_Past
            // 
            this.lb_Past.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Past.AutoSize = true;
            this.lb_Past.Location = new System.Drawing.Point(155, 57);
            this.lb_Past.Name = "lb_Past";
            this.lb_Past.Size = new System.Drawing.Size(36, 17);
            this.lb_Past.TabIndex = 1;
            this.lb_Past.Text = "Past";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label7);
            this.splitContainer2.Panel1.Controls.Add(this.cb_SortType);
            this.splitContainer2.Panel1.Controls.Add(this.lb_content);
            this.splitContainer2.Panel1.Controls.Add(this.flp_Today);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.lb_Upcoming);
            this.splitContainer2.Panel2.Controls.Add(this.flp_Upcoming);
            this.splitContainer2.Size = new System.Drawing.Size(637, 567);
            this.splitContainer2.SplitterDistance = 307;
            this.splitContainer2.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Sort by";
            // 
            // cb_SortType
            // 
            this.cb_SortType.FormattingEnabled = true;
            this.cb_SortType.Items.AddRange(new object[] {
            "Default",
            "Priority",
            "Due Date"});
            this.cb_SortType.Location = new System.Drawing.Point(5, 32);
            this.cb_SortType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_SortType.Name = "cb_SortType";
            this.cb_SortType.Size = new System.Drawing.Size(121, 24);
            this.cb_SortType.TabIndex = 5;
            this.cb_SortType.SelectedIndexChanged += new System.EventHandler(this.cb_SortType_SelectedIndexChanged);
            // 
            // lb_content
            // 
            this.lb_content.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_content.AutoSize = true;
            this.lb_content.Location = new System.Drawing.Point(125, 58);
            this.lb_content.Name = "lb_content";
            this.lb_content.Size = new System.Drawing.Size(48, 17);
            this.lb_content.TabIndex = 1;
            this.lb_content.Text = "Today";
            // 
            // flp_Today
            // 
            this.flp_Today.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flp_Today.AutoScroll = true;
            this.flp_Today.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flp_Today.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flp_Today.Location = new System.Drawing.Point(9, 86);
            this.flp_Today.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flp_Today.Name = "flp_Today";
            this.flp_Today.Size = new System.Drawing.Size(289, 467);
            this.flp_Today.TabIndex = 0;
            this.flp_Today.WrapContents = false;
            this.flp_Today.Resize += new System.EventHandler(this.flp_Today_Resize);
            // 
            // lb_Upcoming
            // 
            this.lb_Upcoming.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Upcoming.AutoSize = true;
            this.lb_Upcoming.Location = new System.Drawing.Point(132, 50);
            this.lb_Upcoming.Name = "lb_Upcoming";
            this.lb_Upcoming.Size = new System.Drawing.Size(77, 17);
            this.lb_Upcoming.TabIndex = 1;
            this.lb_Upcoming.Text = "Up Coming";
            // 
            // flp_Upcoming
            // 
            this.flp_Upcoming.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flp_Upcoming.AutoScroll = true;
            this.flp_Upcoming.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flp_Upcoming.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flp_Upcoming.Location = new System.Drawing.Point(15, 86);
            this.flp_Upcoming.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flp_Upcoming.Name = "flp_Upcoming";
            this.flp_Upcoming.Size = new System.Drawing.Size(300, 467);
            this.flp_Upcoming.TabIndex = 0;
            this.flp_Upcoming.WrapContents = false;
            this.flp_Upcoming.Resize += new System.EventHandler(this.flp_Upcoming_Resize);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(169, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lb_Past);
            this.splitContainer1.Panel2.Controls.Add(this.flp_Past);
            this.splitContainer1.Size = new System.Drawing.Size(979, 567);
            this.splitContainer1.SplitterDistance = 637;
            this.splitContainer1.TabIndex = 8;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 567);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Todolist - Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Past;
        private System.Windows.Forms.Button btn_Upcoming;
        private System.Windows.Forms.Button btn_Today;
        private System.Windows.Forms.Button btn_All;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_SignOut;
        private System.Windows.Forms.Label lb_DueCount;
        private System.Windows.Forms.Label lb_AllCount;
        private System.Windows.Forms.Label lb_UpcomingCount;
        private System.Windows.Forms.Label lb_TodayCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flp_Past;
        private System.Windows.Forms.Label lb_Past;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_SortType;
        private System.Windows.Forms.Label lb_content;
        private System.Windows.Forms.FlowLayoutPanel flp_Today;
        private System.Windows.Forms.Label lb_Upcoming;
        private System.Windows.Forms.FlowLayoutPanel flp_Upcoming;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}