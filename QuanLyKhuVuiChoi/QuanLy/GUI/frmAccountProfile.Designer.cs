namespace QuanLy.GUI
{
    partial class frmAccountProfile
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
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassChange = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassAgain = new System.Windows.Forms.TextBox();
            this.cbMemoryPass = new System.Windows.Forms.CheckBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên đăng nhập";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(143, 25);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(197, 20);
            this.txtUser.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(30, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên hiển thị";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(143, 66);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(197, 20);
            this.txtName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(39, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mật khẩu";
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(143, 107);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(197, 20);
            this.txtPassWord.TabIndex = 7;
            this.txtPassWord.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(13, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Thay đổi mật khẩu";
            // 
            // txtPassChange
            // 
            this.txtPassChange.Location = new System.Drawing.Point(143, 148);
            this.txtPassChange.Name = "txtPassChange";
            this.txtPassChange.Size = new System.Drawing.Size(197, 20);
            this.txtPassChange.TabIndex = 9;
            this.txtPassChange.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(39, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nhập lại";
            // 
            // txtPassAgain
            // 
            this.txtPassAgain.Location = new System.Drawing.Point(143, 189);
            this.txtPassAgain.Name = "txtPassAgain";
            this.txtPassAgain.Size = new System.Drawing.Size(197, 20);
            this.txtPassAgain.TabIndex = 11;
            this.txtPassAgain.UseSystemPasswordChar = true;
            // 
            // cbMemoryPass
            // 
            this.cbMemoryPass.AutoSize = true;
            this.cbMemoryPass.Location = new System.Drawing.Point(245, 215);
            this.cbMemoryPass.Name = "cbMemoryPass";
            this.cbMemoryPass.Size = new System.Drawing.Size(95, 17);
            this.cbMemoryPass.TabIndex = 13;
            this.cbMemoryPass.Text = "Hiện mật khẩu";
            this.cbMemoryPass.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(265, 238);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(184, 238);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Cập Nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // frmAccountProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 282);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cbMemoryPass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPassAgain);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPassChange);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUser);
            this.Name = "frmAccountProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin tài khoản";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAccountProfile_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassChange;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPassAgain;
        private System.Windows.Forms.CheckBox cbMemoryPass;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUpdate;
    }
}