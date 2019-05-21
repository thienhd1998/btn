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
    public partial class frmVe : Form
    {
        BindingSource Ve = new BindingSource();
        public frmVe()
        {
            InitializeComponent();
            LoadVe();
            Binding();
        }
        void LoadVe()
        {
            dtgVe.DataSource = Ve;
            string query = "sp_Ve_Select";
            Ve.DataSource = DataProvider.Instance.ExecuteQuery(query);
            dtgVe.Refresh();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string MaNV = txtMaNV.Text;
            if (KiemTraDAO.Istance.CheckMaNV(MaNV))
            {
                string query = "sp_ve_insert '" + dtpNgayban.Value.ToString("MM/dd/yyyy") + "','" + txtSLTE.Text + "','" + txtSLNL.Text + "','" + txtMaNV.Text + "','" + txtMaKhu.Text + "'";
                DataProvider.Instance.ExecuteNonQuery(query);
                LoadVe();
            }
            else
                MessageBox.Show("Không tồn tại nhân viên có mã: " + MaNV, "Thông báo");
            
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string MaNV = txtMaNV.Text;
            if (KiemTraDAO.Istance.CheckMaNV(MaNV))
            {
                string query = "sp_Ve_update '" + txtMave.Text + "', '" + dtpNgayban.Value.ToString("MM/dd/yyyy") + "','" + txtSLTE.Text + "','" + txtSLNL.Text + "','" + txtMaNV.Text + "','" + txtMaKhu.Text + "'";
                DataProvider.Instance.ExecuteNonQuery(query);
                LoadVe();
            }
            else
                MessageBox.Show("Không tồn tại nhân viên có mã: " + MaNV, "Thông báo");
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string query = "sp_Ve_Delete '"+txtMave.Text+"'";
            DataProvider.Instance.ExecuteNonQuery(query);
            LoadVe();
        }
        void Binding()
        {
            txtMave.DataBindings.Add(new Binding("Text", dtgVe.DataSource, "MaVe"));
            dtpNgayban.DataBindings.Add(new Binding("Value", dtgVe.DataSource, "NgayBan", true));
            txtSLTE.DataBindings.Add(new Binding("Text", dtgVe.DataSource, "SLTE"));
            txtSLNL.DataBindings.Add(new Binding("Text", dtgVe.DataSource, "SLNL"));
            txtMaNV.DataBindings.Add(new Binding("Text", dtgVe.DataSource, "MaNV"));
            txtMaKhu.DataBindings.Add(new Binding("Text", dtgVe.DataSource, "MaKhu"));
        }
    }
}
