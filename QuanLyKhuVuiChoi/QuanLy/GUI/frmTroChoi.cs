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
    public partial class frmTroChoi : Form
    {
        BindingSource TroChoi = new BindingSource();
        public frmTroChoi()
        {
            InitializeComponent();
            LoadTroChoi();
            Binding();
        }
        void LoadTroChoi()
        {
            dtgTroChoi.DataSource = TroChoi;
            string query = "sp_Trochoi_Select";
            TroChoi.DataSource = DataProvider.Instance.ExecuteQuery(query);
            dtgTroChoi.Refresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string MaKhu = txtMaKhu.Text;
            if (KiemTraDAO.Istance.CheckMaKhu(MaKhu))
            {
                string query = "sp_TroChoi_Insert N'" + txtTenTro.Text + "','" + txtMaKhu.Text + "'";
                DataProvider.Instance.ExecuteNonQuery(query);
                LoadTroChoi();
            }
            else
                MessageBox.Show("Không tồn tại khu trò chơi có mã: "+MaKhu,"Thông báo");
            
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string MaKhu = txtMaKhu.Text;
            if (KiemTraDAO.Istance.CheckMaKhu(MaKhu))
            {
                string query = "sp_trochoi_Update '" + txtMaTro.Text + "',N'" + txtTenTro.Text + "','" + txtMaKhu.Text + "'";
                DataProvider.Instance.ExecuteNonQuery(query);
                LoadTroChoi();
            }
            else
                MessageBox.Show("Không tồn tại khu trò chơi có mã: " + MaKhu, "Thông báo");
            
        }
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string query = "sp_TroChoi_Delete '"+txtMaTro.Text+"'";
            DataProvider.Instance.ExecuteNonQuery(query);
            LoadTroChoi();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
        void Binding()
        {
            txtMaTro.DataBindings.Add(new Binding("Text", dtgTroChoi.DataSource, "MaTro"));
            txtTenTro.DataBindings.Add(new Binding("Text", dtgTroChoi.DataSource, "TenTro"));
            txtMaKhu.DataBindings.Add(new Binding("Text", dtgTroChoi.DataSource, "MaKhu"));
        }
    }
}
