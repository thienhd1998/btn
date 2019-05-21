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
    public partial class frmNhanVien_Timtheoma : Form
    {
        private string mGiaTri;
        public frmNhanVien_Timtheoma()
        {
            InitializeComponent();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            
        }
        public string LayGiaTriTimKiem()
        {
            return mGiaTri; //Trả về giá trị tìm kiếm
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            mGiaTri = "";
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập giá trị cần tìm", "Thông báo");
                ActiveControl = txtSearch;
                return;
            }

            mGiaTri = txtSearch.Text.Trim();
            this.Close();

        }
    }
}
