using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLy.DAO;

namespace QuanLy.GUI
{
    public partial class frmDepartment : Form
    {
        public frmDepartment()
        {
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            string query = "SELECT MaPB as [Mã PB],TenPB as [Tên Phòng Ban],MaTP as [Mã TP],NgayNC as[Ngày NC],DiaDiem as [Địa Điểm] FROM PHONGBAN";
            dtgDepartment.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtIdDpm.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập mã PB", "Thông báo");
                ActiveControl = txtIdDpm;
                return;
            }
            //dtpNgayNC.Value.ToString("MM/dd/yyyy");
            string query = "INSERT INTO PHONGBAN(MaPB,TenPB,MaTP,NgayNC,DiaDiem)" +
                " VALUES('" + txtIdDpm.Text + "', N'" +txtTenPB.Text+ "','" +txtMaTP.Text+
                "','" + dtpNgayNC.Value.ToString("MM/dd/yyyy") + "','" + txtDiaDiem.Text + "')";
            DataProvider.Instance.ExecuteNonQuery(query);
                query = "SELECT * FROM PHONGBAN";
                dtgDepartment.DataSource = DataProvider.Instance.ExecuteQuery(query);
                dtgDepartment.Refresh();
            
        }
    }
}
