using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLy.DAO;

namespace QuanLy.GUI
{
    public partial class frmDichVu : Form
    {
        BindingSource DichVu = new BindingSource();
        public frmDichVu()
        {
            InitializeComponent();
            LoadDichVu();
            Binding();
        }
        void LoadDichVu()
        {
            dtgDichVu.DataSource = DichVu;
            string query = "sp_Dichvu_Select";
            DichVu.DataSource = DataProvider.Instance.ExecuteQuery(query);
            dtgDichVu.Refresh();
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string MaKhu = txtMaKhu.Text.Trim();
            if (KiemTraDAO.Istance.CheckMaKhu(MaKhu))
            {
                string query = "sp_Dichvu_Insert N'" + txtTenDV.Text + "','" + txtGiaDV.Text + "','" + txtMaKhu.Text + "'";
                DataProvider.Instance.ExecuteNonQuery(query);
                LoadDichVu();
            }
            else
                MessageBox.Show("Không tồn tại khu có mã "+MaKhu,"Thông báo");
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string MaKhu = txtMaKhu.Text;
            if (KiemTraDAO.Istance.CheckMaKhu(MaKhu))
            {
                string query = "sp_DichVu_update '" + txtMaDV.Text + "', N'" + txtTenDV.Text + "','" + txtGiaDV.Text + "','" + txtMaKhu.Text + "'";
                DataProvider.Instance.ExecuteNonQuery(query);
                LoadDichVu();
            }
            else
                MessageBox.Show("Không tồn tại khu có mã " + MaKhu, "Thông báo");
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string query = "sp_DichVu_Delete '" + txtMaDV.Text + "'";
            DataProvider.Instance.ExecuteNonQuery(query);
            LoadDichVu();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        void Binding()
        {
            txtMaDV.DataBindings.Add(new Binding("Text", dtgDichVu.DataSource, "MaDV"));
            txtTenDV.DataBindings.Add(new Binding("Text", dtgDichVu.DataSource, "tenDV"));
            txtGiaDV.DataBindings.Add(new Binding("Text", dtgDichVu.DataSource, "GiaDV"));
            txtMaKhu.DataBindings.Add(new Binding("Text", dtgDichVu.DataSource, "MaKhu"));
        }

    }
}
