namespace QuanLy.GUI
{
    partial class frmEmployee
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
            this.btnLast = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.txtPay = new System.Windows.Forms.TextBox();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.cbFemales = new System.Windows.Forms.CheckBox();
            this.cbMales = new System.Windows.Forms.CheckBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgEmployee = new System.Windows.Forms.DataGridView();
            this.txtIdDpm = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIdGround = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIdGame = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLast);
            this.panel1.Controls.Add(this.btnForward);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnFirst);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnFilter);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnChange);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 42);
            this.panel1.TabIndex = 0;
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(83, 9);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(26, 23);
            this.btnLast.TabIndex = 6;
            this.btnLast.Text = ">|";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(57, 9);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(27, 23);
            this.btnForward.TabIndex = 6;
            this.btnForward.Text = ">>";
            this.btnForward.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(31, 9);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(27, 23);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "<<";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(4, 9);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(27, 23);
            this.btnFirst.TabIndex = 5;
            this.btnFirst.Text = "|<";
            this.btnFirst.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(583, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(51, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(526, 9);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(51, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(469, 9);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(51, 23);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.Text = "Lọc";
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(341, 9);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(51, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(284, 9);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(51, 23);
            this.btnChange.TabIndex = 1;
            this.btnChange.Text = "Sửa";
            this.btnChange.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(227, 9);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(51, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtIdGame);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtIdGround);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtIdDpm);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.dtpBirth);
            this.panel2.Controls.Add(this.txtPay);
            this.panel2.Controls.Add(this.txtJob);
            this.panel2.Controls.Add(this.cbFemales);
            this.panel2.Controls.Add(this.cbMales);
            this.panel2.Controls.Add(this.txtAddress);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtId);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(675, 173);
            this.panel2.TabIndex = 1;
            // 
            // dtpBirth
            // 
            this.dtpBirth.Location = new System.Drawing.Point(95, 75);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(263, 20);
            this.dtpBirth.TabIndex = 15;
            // 
            // txtPay
            // 
            this.txtPay.Location = new System.Drawing.Point(427, 79);
            this.txtPay.Name = "txtPay";
            this.txtPay.Size = new System.Drawing.Size(181, 20);
            this.txtPay.TabIndex = 14;
            // 
            // txtJob
            // 
            this.txtJob.Location = new System.Drawing.Point(427, 46);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(245, 20);
            this.txtJob.TabIndex = 13;
            // 
            // cbFemales
            // 
            this.cbFemales.AutoSize = true;
            this.cbFemales.Location = new System.Drawing.Point(503, 17);
            this.cbFemales.Name = "cbFemales";
            this.cbFemales.Size = new System.Drawing.Size(40, 17);
            this.cbFemales.TabIndex = 12;
            this.cbFemales.Text = "Nữ";
            this.cbFemales.UseVisualStyleBackColor = true;
            // 
            // cbMales
            // 
            this.cbMales.AutoSize = true;
            this.cbMales.Location = new System.Drawing.Point(449, 17);
            this.cbMales.Name = "cbMales";
            this.cbMales.Size = new System.Drawing.Size(48, 17);
            this.cbMales.TabIndex = 11;
            this.cbMales.Text = "Nam";
            this.cbMales.UseVisualStyleBackColor = true;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(95, 100);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(263, 20);
            this.txtAddress.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(95, 46);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(263, 20);
            this.txtName.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(175, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "(*)";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(95, 14);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(79, 20);
            this.txtId.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(374, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Lương";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(374, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Chức vụ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quê quán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giới tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            // 
            // dtgEmployee
            // 
            this.dtgEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgEmployee.Location = new System.Drawing.Point(0, 215);
            this.dtgEmployee.Name = "dtgEmployee";
            this.dtgEmployee.Size = new System.Drawing.Size(675, 242);
            this.dtgEmployee.TabIndex = 2;
            // 
            // txtIdDpm
            // 
            this.txtIdDpm.Location = new System.Drawing.Point(95, 130);
            this.txtIdDpm.Name = "txtIdDpm";
            this.txtIdDpm.Size = new System.Drawing.Size(79, 20);
            this.txtIdDpm.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(12, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Mã PB";
            // 
            // txtIdGround
            // 
            this.txtIdGround.Location = new System.Drawing.Point(295, 129);
            this.txtIdGround.Name = "txtIdGround";
            this.txtIdGround.Size = new System.Drawing.Size(79, 20);
            this.txtIdGround.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(212, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "Mã Khu";
            // 
            // txtIdGame
            // 
            this.txtIdGame.Location = new System.Drawing.Point(499, 129);
            this.txtIdGame.Name = "txtIdGame";
            this.txtIdGame.Size = new System.Drawing.Size(79, 20);
            this.txtIdGame.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(416, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 15);
            this.label11.TabIndex = 20;
            this.label11.Text = "Mã Trò ";
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 457);
            this.Controls.Add(this.dtgEmployee);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmEmployee";
            this.Text = "Nhân viên";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPay;
        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.CheckBox cbFemales;
        private System.Windows.Forms.CheckBox cbMales;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.DataGridView dtgEmployee;
        private System.Windows.Forms.TextBox txtIdGame;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtIdGround;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIdDpm;
        private System.Windows.Forms.Label label9;
    }
}