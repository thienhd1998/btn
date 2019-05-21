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
    public partial class frmHoadon_Dichvu : Form
    {
        BindingSource LoadHDDV = new BindingSource();
        public frmHoadon_Dichvu()
        {
            InitializeComponent();
            LoadHoaDon_Dichvu();
            Binding();
        }
        void LoadHoaDon_Dichvu()
        {
            dtgHoaDon_DichVu.DataSource = LoadHDDV;
            string query = "sp_Hoadon_Chitiet_Select";
            LoadHDDV.DataSource = DataProvider.Instance.ExecuteQuery(query);
            dtgHoaDon_DichVu.Refresh();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            string MaHD = txtMaHD.Text;
            string MaDV = txtMaDV.Text;
            if (KiemTraDAO.Istance.CheckMaHD(MaHD)&&KiemTraDAO.Istance.CheckMaDV(MaDV))
            {
                string query = "sp_Hoadon_ChiTiet_Insert '" + txtMaHD.Text + "' , '" + txtMaDV.Text + "','" + txtSL.Text + "',N'" + txtTenKH.Text + "'";
                DataProvider.Instance.ExecuteNonQuery(query);
                LoadHoaDon_Dichvu();
            }
            else
                MessageBox.Show("Mã hóa đơn hoặc mã dịch vụ không tồn tại","Thông báo");
        }
        private void btnChange_Click(object sender, EventArgs e)
        {
            string MaHD = txtMaHD.Text;
            string MaDV = txtMaDV.Text;
            if (KiemTraDAO.Istance.CheckMaHD(MaHD) && KiemTraDAO.Istance.CheckMaDV(MaDV))
            {
                string query = "sp_Hoadon_ChiTiet_Update '" + txtMaHD.Text + "', '" + txtMaDV.Text + "','" + txtSL.Text + "',N'" + txtTenKH.Text + "'";
                DataProvider.Instance.ExecuteNonQuery(query);
                LoadHoaDon_Dichvu();
            }
            else
                MessageBox.Show("Mã hóa đơn hoặc mã dịch vụ không tồn tại", "Thông báo");
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string query = "sp_Hoadon_ChiTiet_Delete '" + txtMaHD.Text + "', '" + txtMaDV.Text + "'";
            DataProvider.Instance.ExecuteNonQuery(query);
            LoadHoaDon_Dichvu();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
        void Binding()
        {
            txtMaHD.DataBindings.Add(new Binding("Text", dtgHoaDon_DichVu.DataSource, "MaHD"));
            txtMaDV.DataBindings.Add(new Binding("Text", dtgHoaDon_DichVu.DataSource, "MaDV"));
            txtSL.DataBindings.Add(new Binding("Text", dtgHoaDon_DichVu.DataSource, "SoLuong"));
            txtTenKH.DataBindings.Add(new Binding("Text", dtgHoaDon_DichVu.DataSource, "TenKH"));
        }

     
    }
}
