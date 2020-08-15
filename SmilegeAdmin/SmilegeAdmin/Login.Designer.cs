namespace SmilegeAdmin
{
    partial class Login
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
            this.Label_AdminLogin = new System.Windows.Forms.Label();
            this.Label_AdminID = new System.Windows.Forms.Label();
            this.Label_AdminPW = new System.Windows.Forms.Label();
            this.Admin_ID = new System.Windows.Forms.TextBox();
            this.Admin_PW = new System.Windows.Forms.TextBox();
            this.Button_AdminLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_AdminLogin
            // 
            this.Label_AdminLogin.AutoSize = true;
            this.Label_AdminLogin.Font = new System.Drawing.Font("굴림", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Label_AdminLogin.Location = new System.Drawing.Point(47, 54);
            this.Label_AdminLogin.Name = "Label_AdminLogin";
            this.Label_AdminLogin.Size = new System.Drawing.Size(277, 40);
            this.Label_AdminLogin.TabIndex = 0;
            this.Label_AdminLogin.Text = "관리자 로그인";
            // 
            // Label_AdminID
            // 
            this.Label_AdminID.AutoSize = true;
            this.Label_AdminID.Location = new System.Drawing.Point(67, 132);
            this.Label_AdminID.Name = "Label_AdminID";
            this.Label_AdminID.Size = new System.Drawing.Size(41, 12);
            this.Label_AdminID.TabIndex = 1;
            this.Label_AdminID.Text = "아이디";
            // 
            // Label_AdminPW
            // 
            this.Label_AdminPW.AutoSize = true;
            this.Label_AdminPW.Location = new System.Drawing.Point(60, 164);
            this.Label_AdminPW.Name = "Label_AdminPW";
            this.Label_AdminPW.Size = new System.Drawing.Size(53, 12);
            this.Label_AdminPW.TabIndex = 2;
            this.Label_AdminPW.Text = "비밀번호";
            // 
            // Admin_ID
            // 
            this.Admin_ID.Location = new System.Drawing.Point(134, 129);
            this.Admin_ID.Name = "Admin_ID";
            this.Admin_ID.Size = new System.Drawing.Size(137, 21);
            this.Admin_ID.TabIndex = 3;
            // 
            // Admin_PW
            // 
            this.Admin_PW.Location = new System.Drawing.Point(134, 161);
            this.Admin_PW.Name = "Admin_PW";
            this.Admin_PW.Size = new System.Drawing.Size(137, 21);
            this.Admin_PW.TabIndex = 4;
            // 
            // Button_AdminLogin
            // 
            this.Button_AdminLogin.Location = new System.Drawing.Point(152, 211);
            this.Button_AdminLogin.Name = "Button_AdminLogin";
            this.Button_AdminLogin.Size = new System.Drawing.Size(75, 23);
            this.Button_AdminLogin.TabIndex = 5;
            this.Button_AdminLogin.Text = "로그인";
            this.Button_AdminLogin.UseVisualStyleBackColor = true;
            this.Button_AdminLogin.Click += new System.EventHandler(this.Button_AdminLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 310);
            this.Controls.Add(this.Button_AdminLogin);
            this.Controls.Add(this.Admin_PW);
            this.Controls.Add(this.Admin_ID);
            this.Controls.Add(this.Label_AdminPW);
            this.Controls.Add(this.Label_AdminID);
            this.Controls.Add(this.Label_AdminLogin);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_AdminLogin;
        private System.Windows.Forms.Label Label_AdminID;
        private System.Windows.Forms.Label Label_AdminPW;
        private System.Windows.Forms.TextBox Admin_ID;
        private System.Windows.Forms.TextBox Admin_PW;
        private System.Windows.Forms.Button Button_AdminLogin;
    }
}