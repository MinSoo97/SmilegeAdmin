namespace SmilegeAdmin
{
    partial class AddStudentProgram
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
            this.label1 = new System.Windows.Forms.Label();
            this.Label_AddProgram_Program_Open = new System.Windows.Forms.Label();
            this.AddProgram_Program_Open = new System.Windows.Forms.TextBox();
            this.AddProgram_Program_Name = new System.Windows.Forms.TextBox();
            this.Label_AddProgram_Program_Name = new System.Windows.Forms.Label();
            this.AddProgram_SmilegeScore = new System.Windows.Forms.TextBox();
            this.Label_AddProgram_SmilegeScore = new System.Windows.Forms.Label();
            this.AddProgram_AddScore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "프로그램 추가";
            // 
            // Label_AddProgram_Program_Open
            // 
            this.Label_AddProgram_Program_Open.AutoSize = true;
            this.Label_AddProgram_Program_Open.Location = new System.Drawing.Point(31, 79);
            this.Label_AddProgram_Program_Open.Name = "Label_AddProgram_Program_Open";
            this.Label_AddProgram_Program_Open.Size = new System.Drawing.Size(29, 12);
            this.Label_AddProgram_Program_Open.TabIndex = 1;
            this.Label_AddProgram_Program_Open.Text = "주최";
            // 
            // AddProgram_Program_Open
            // 
            this.AddProgram_Program_Open.Location = new System.Drawing.Point(107, 76);
            this.AddProgram_Program_Open.Name = "AddProgram_Program_Open";
            this.AddProgram_Program_Open.Size = new System.Drawing.Size(158, 21);
            this.AddProgram_Program_Open.TabIndex = 2;
            // 
            // AddProgram_Program_Name
            // 
            this.AddProgram_Program_Name.Location = new System.Drawing.Point(107, 113);
            this.AddProgram_Program_Name.Name = "AddProgram_Program_Name";
            this.AddProgram_Program_Name.Size = new System.Drawing.Size(158, 21);
            this.AddProgram_Program_Name.TabIndex = 4;
            // 
            // Label_AddProgram_Program_Name
            // 
            this.Label_AddProgram_Program_Name.AutoSize = true;
            this.Label_AddProgram_Program_Name.Location = new System.Drawing.Point(31, 116);
            this.Label_AddProgram_Program_Name.Name = "Label_AddProgram_Program_Name";
            this.Label_AddProgram_Program_Name.Size = new System.Drawing.Size(69, 12);
            this.Label_AddProgram_Program_Name.TabIndex = 3;
            this.Label_AddProgram_Program_Name.Text = "프로그램 명";
            // 
            // AddProgram_SmilegeScore
            // 
            this.AddProgram_SmilegeScore.Location = new System.Drawing.Point(107, 150);
            this.AddProgram_SmilegeScore.Name = "AddProgram_SmilegeScore";
            this.AddProgram_SmilegeScore.Size = new System.Drawing.Size(158, 21);
            this.AddProgram_SmilegeScore.TabIndex = 6;
            // 
            // Label_AddProgram_SmilegeScore
            // 
            this.Label_AddProgram_SmilegeScore.AutoSize = true;
            this.Label_AddProgram_SmilegeScore.Location = new System.Drawing.Point(31, 153);
            this.Label_AddProgram_SmilegeScore.Name = "Label_AddProgram_SmilegeScore";
            this.Label_AddProgram_SmilegeScore.Size = new System.Drawing.Size(65, 12);
            this.Label_AddProgram_SmilegeScore.TabIndex = 5;
            this.Label_AddProgram_SmilegeScore.Text = "스마일리지";
            // 
            // AddProgram_AddScore
            // 
            this.AddProgram_AddScore.Location = new System.Drawing.Point(190, 217);
            this.AddProgram_AddScore.Name = "AddProgram_AddScore";
            this.AddProgram_AddScore.Size = new System.Drawing.Size(75, 39);
            this.AddProgram_AddScore.TabIndex = 7;
            this.AddProgram_AddScore.Text = "활동 추가";
            this.AddProgram_AddScore.UseVisualStyleBackColor = true;
            this.AddProgram_AddScore.Click += new System.EventHandler(this.AddProgram_AddScore_Click);
            // 
            // AddProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 301);
            this.Controls.Add(this.AddProgram_AddScore);
            this.Controls.Add(this.AddProgram_SmilegeScore);
            this.Controls.Add(this.Label_AddProgram_SmilegeScore);
            this.Controls.Add(this.AddProgram_Program_Name);
            this.Controls.Add(this.Label_AddProgram_Program_Name);
            this.Controls.Add(this.AddProgram_Program_Open);
            this.Controls.Add(this.Label_AddProgram_Program_Open);
            this.Controls.Add(this.label1);
            this.Name = "AddProgram";
            this.Text = "AddProgram";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label_AddProgram_Program_Open;
        private System.Windows.Forms.TextBox AddProgram_Program_Open;
        private System.Windows.Forms.TextBox AddProgram_Program_Name;
        private System.Windows.Forms.Label Label_AddProgram_Program_Name;
        private System.Windows.Forms.TextBox AddProgram_SmilegeScore;
        private System.Windows.Forms.Label Label_AddProgram_SmilegeScore;
        private System.Windows.Forms.Button AddProgram_AddScore;
    }
}