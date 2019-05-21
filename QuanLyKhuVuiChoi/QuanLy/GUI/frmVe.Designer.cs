namespace QuanLy.GUI
{
    partial class frmVe
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
            this.txtMaKhu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpNgayban = new System.Windows.Forms.DateTimePicker();
            this.txtSLNL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSLTE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgVe = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVe)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(666, 42);
            this.panel1.TabIndex = 3;
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(83, 9);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(26, 23);
            this.btnLast.TabIndex = 6;
            this.btnLast.Text = ">|";
            this.btnLast.UseVisualStyleBackColor = true;
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
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(284, 9);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(51, 23);
            this.btnChange.TabIndex = 1;
            this.btnChange.Text = "Sửa";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
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
            this.panel2.Controls.Add(this.txtMaKhu);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtMaNV);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.dtpNgayban);
            this.panel2.Controls.Add(this.txtSLNL);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtSLTE);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtMave);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(666, 100);
            this.panel2.TabIndex = 4;
            // 
            // txtMaKhu
            // 
            this.txtMaKhu.Location = new System.Drawing.Point(526, 55);
            this.txtMaKhu.Name = "txtMaKhu";
            this.txtMaKhu.Size = new System.Drawing.Size(91, 20);
            this.txtMaKhu.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(472, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Mã Khu";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(526, 12);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(91, 20);
            this.txtMaNV.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(472, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Mã NV";
            // 
            // dtpNgayban
            // 
            this.dtpNgayban.Location = new System.Drawing.Point(86, 55);
            this.dtpNgayban.Name = "dtpNgayban";
            this.dtpNgayban.Size = new System.Drawing.Size(200, 20);
            this.dtpNgayban.TabIndex = 18;
            // 
            // txtSLNL
            // 
            this.txtSLNL.Location = new System.Drawing.Point(366, 55);
            this.txtSLNL.Name = "txtSLNL";
            this.txtSLNL.Size = new System.Drawing.Size(91, 20);
            this.txtSLNL.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "SLNL";
            // 
            // txtSLTE
            // 
            this.txtSLTE.Location = new System.Drawing.Point(366, 12);
            this.txtSLTE.Name = "txtSLTE";
            this.txtSLTE.Size = new System.Drawing.Size(91, 20);
            this.txtSLTE.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "SLTE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ngày bán";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(171, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "(*)";
            // 
            // txtMave
            // 
            this.txtMave.Location = new System.Drawing.Point(86, 15);
            this.txtMave.Name = "txtMave";
            this.txtMave.Size = new System.Drawing.Size(79, 20);
            this.txtMave.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(28, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã vé";
            // 
            // dtgVe
            // 
            this.dtgVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgVe.Location = new System.Drawing.Point(0, 142);
            this.dtgVe.Name = "dtgVe";
            this.dtgVe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgVe.Size = new System.Drawing.Size(666, 265);
            this.dtgVe.TabIndex = 5;
            // 
            // frmVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 407);
            this.Controls.Add(this.dtgVe);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmVe";
            this.Text = "Vé";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtpNgayban;
        private System.Windows.Forms.TextBox txtSLNL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSLTE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgVe;
        private System.Windows.Forms.TextBox txtMaKhu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label6;
    }
}