using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLy.GUI
{
    public partial class frmGame : Form
    {
        public frmGame()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Bước 1: kiểm tra dữ liệu
            if (txtIdGame.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập mã trò chơi", "Thông báo");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
