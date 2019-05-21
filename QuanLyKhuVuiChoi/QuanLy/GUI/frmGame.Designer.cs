namespace QuanLy.GUI
{
    partial class frmGame
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
            this.txtIDGround = new System.Windows.Forms.TextBox();
            this.txtNameGame = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIdGame = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lsvPlayGround = new System.Windows.Forms.ListView();
            this.ID_Game = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tentro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID_Ground = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(680, 42);
            this.panel1.TabIndex = 2;
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
            this.panel2.Controls.Add(this.txtIDGround);
            this.panel2.Controls.Add(this.txtNameGame);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtIdGame);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(680, 113);
            this.panel2.TabIndex = 3;
            // 
            // txtIDGround
            // 
            this.txtIDGround.Location = new System.Drawing.Point(95, 75);
            this.txtIDGround.Name = "txtIDGround";
            this.txtIDGround.Size = new System.Drawing.Size(79, 20);
            this.txtIDGround.TabIndex = 14;
            // 
            // txtNameGame
            // 
            this.txtNameGame.Location = new System.Drawing.Point(95, 46);
            this.txtNameGame.Name = "txtNameGame";
            this.txtNameGame.Size = new System.Drawing.Size(240, 20);
            this.txtNameGame.TabIndex = 9;
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
            // txtIdGame
            // 
            this.txtIdGame.Location = new System.Drawing.Point(95, 14);
            this.txtIdGame.Name = "txtIdGame";
            this.txtIdGame.Size = new System.Drawing.Size(79, 20);
            this.txtIdGame.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Mã Khu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Trò";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(28, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã trò";
            // 
            // lsvPlayGround
            // 
            this.lsvPlayGround.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_Game,
            this.tentro,
            this.ID_Ground});
            this.lsvPlayGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvPlayGround.Location = new System.Drawing.Point(0, 155);
            this.lsvPlayGround.MultiSelect = false;
            this.lsvPlayGround.Name = "lsvPlayGround";
            this.lsvPlayGround.Size = new System.Drawing.Size(680, 329);
            this.lsvPlayGround.TabIndex = 4;
            this.lsvPlayGround.UseCompatibleStateImageBehavior = false;
            this.lsvPlayGround.View = System.Windows.Forms.View.Details;
            // 
            // ID_Game
            // 
            this.ID_Game.Text = "Mã Trò";
            this.ID_Game.Width = 82;
            // 
            // tentro
            // 
            this.tentro.Text = "Tên Trò";
            this.tentro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tentro.Width = 200;
            // 
            // ID_Ground
            // 
            this.ID_Ground.Text = "Mã Khu";
            this.ID_Ground.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ID_Ground.Width = 108;
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 484);
            this.Controls.Add(this.lsvPlayGround);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmGame";
            this.Text = "Trò chơi";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.TextBox txtIDGround;
        private System.Windows.Forms.TextBox txtNameGame;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIdGame;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lsvPlayGround;
        private System.Windows.Forms.ColumnHeader ID_Game;
        private System.Windows.Forms.ColumnHeader tentro;
        private System.Windows.Forms.ColumnHeader ID_Ground;
    }
}