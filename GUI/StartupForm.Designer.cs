namespace GUI
{
    partial class StartupForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_SignInTab = new System.Windows.Forms.Button();
            this.btn_SignUpTab = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 286);
            this.panel1.TabIndex = 0;
            // 
            // btn_SignInTab
            // 
            this.btn_SignInTab.Location = new System.Drawing.Point(81, 100);
            this.btn_SignInTab.Name = "btn_SignInTab";
            this.btn_SignInTab.Size = new System.Drawing.Size(116, 35);
            this.btn_SignInTab.TabIndex = 1;
            this.btn_SignInTab.Text = "SIGN IN";
            this.btn_SignInTab.UseVisualStyleBackColor = true;
            this.btn_SignInTab.Click += new System.EventHandler(this.btn_SignInTab_Click);
            // 
            // btn_SignUpTab
            // 
            this.btn_SignUpTab.Location = new System.Drawing.Point(371, 100);
            this.btn_SignUpTab.Name = "btn_SignUpTab";
            this.btn_SignUpTab.Size = new System.Drawing.Size(116, 35);
            this.btn_SignUpTab.TabIndex = 1;
            this.btn_SignUpTab.Text = "SIGN UP";
            this.btn_SignUpTab.UseVisualStyleBackColor = true;
            this.btn_SignUpTab.Click += new System.EventHandler(this.btn_SignUpTab_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "TODO LIST";
            // 
            // StartupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 439);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_SignUpTab);
            this.Controls.Add(this.btn_SignInTab);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StartupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Todolist";
            this.Load += new System.EventHandler(this.StartupForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_SignInTab;
        private System.Windows.Forms.Button btn_SignUpTab;
        private System.Windows.Forms.Label label1;
    }
}