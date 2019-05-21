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
    public partial class frmPhongBan : Form
    {
        BindingSource LoadPB = new BindingSource();
        public frmPhongBan()
        {
            InitializeComponent();
            LoadData();
            AddDepartBinding();
        }
        void LoadData()
        {
            dtgPhongBan.DataSource = LoadPB;
            string query = "sp_PhongBan_Select";
            LoadPB.DataSource = DataProvider.Instance.ExecuteQuery(query);
            dtgPhongBan.Refresh();
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string MaNV = txtMaTP.Text;
            if (KiemTraDAO.Istance.CheckMaNV(MaNV))
            {
                string query = "sp_Phongban_insert  N'" + txtTenPB.Text + "','" + txtMaTP.Text +
                "','" + dtpNgayNC.Value.ToString("MM/dd/yyyy") + "',N'" + txtDiaDiem.Text + "'";
                DataProvider.Instance.ExecuteNonQuery(query);
                LoadData();
            }
            else
                MessageBox.Show("Không tồn tại nhân viên có mã: "+MaNV,"Thông báo");
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string query = "sp_Phongban_Delete '" +txtMaPB.Text+ "'";
            DataProvider.Instance.ExecuteNonQuery(query);
            LoadData();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string MaNV = txtMaTP.Text;
            if (KiemTraDAO.Istance.CheckMaNV(MaNV))
            {
                string query = "sp_Phongban_Update '" + txtMaPB.Text + "',N'" + txtTenPB.Text + "','" + txtMaTP.Text +
                "','" + dtpNgayNC.Value.ToString("MM/dd/yyyy") + "',N'" + txtDiaDiem.Text + "'";
                DataProvider.Instance.ExecuteNonQuery(query);
                LoadData();
            }
            else
                MessageBox.Show("Không tồn tại nhân viên có mã: " + MaNV, "Thông báo");
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        void AddDepartBinding()
        {
            txtMaPB.DataBindings.Add(new Binding("Text", dtgPhongBan.DataSource, "MaPB",true,DataSourceUpdateMode.Never));
            txtTenPB.DataBindings.Add(new Binding("Text", dtgPhongBan.DataSource, "TenPB",true,DataSourceUpdateMode.Never));
            txtMaTP.DataBindings.Add(new Binding("Text", dtgPhongBan.DataSource, "MaTP",true,DataSourceUpdateMode.Never));
            dtpNgayNC.DataBindings.Add(new Binding("Value", dtgPhongBan.DataSource, "NgayNC", true,DataSourceUpdateMode.Never));
            txtDiaDiem.DataBindings.Add(new Binding("Text", dtgPhongBan.DataSource, "DiaDiem",true,DataSourceUpdateMode.Never));

        }

        private void txtMaPB_TextChanged(object sender, EventArgs e)
        {
            string MaPB = txtMaPB.Text;
            if (KiemTraDAO.Istance.CheckMaPB(MaPB))
            {
                btnAdd.Enabled = false;
                btnChange.Enabled = true;
                btnDelete.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = true;
                btnChange.Enabled = false;
                btnDelete.Enabled = false;
            }
        }
    }
}
