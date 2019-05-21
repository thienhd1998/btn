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
using QuanLy.Entity;
namespace QuanLy.GUI
{
    public partial class frmKhuTroChoi : Form
    {
        BindingSource KhuTroChoi = new BindingSource();
        public frmKhuTroChoi()
        {
            InitializeComponent();
            LoadData();
            AddDepartBinding();
        }
        
        private void btnSearch_Click(object sender, EventArgs e)
        {
        }


        private void btnFirst_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            
        }
        void LoadData()
        {
            dtgKhuTroChoi.DataSource = KhuTroChoi;
            string query = "sp_KhuTroChoi_Select";
            KhuTroChoi.DataSource = DataProvider.Instance.ExecuteQuery(query);
            dtgKhuTroChoi.Refresh();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string query = " sp_Khutrochoi_Insert N'" + txtTenKhu.Text + "','" + txtGiaTE.Text +
                "','" + txtGiaNL.Text + "','" + dtpGioMo.Value.ToString("HH:mm") + "','" + dtpGioDong.Value.ToString("HH:mm") + "'";
            DataProvider.Instance.ExecuteNonQuery(query);
            LoadData();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string query = " sp_Khutrochoi_Update '"+txtMaKhu.Text+"' , N'" + txtTenKhu.Text + "','" + txtGiaTE.Text +
                "','" + txtGiaNL.Text + "','" + dtpGioMo.Value.ToString("HH:mm") + "','" + dtpGioDong.Value.ToString("HH:mm") + "'";
            DataProvider.Instance.ExecuteNonQuery(query);
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string query = "sp_Khutrochoi_delete '"+txtMaKhu+"'";
            DataProvider.Instance.ExecuteNonQuery(query);
            LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        void AddDepartBinding()
        {
            txtMaKhu.DataBindings.Add(new Binding("Text", dtgKhuTroChoi.DataSource, "MaKhu"));
            txtTenKhu.DataBindings.Add(new Binding("Text", dtgKhuTroChoi.DataSource, "TenKhu"));
            txtGiaTE.DataBindings.Add(new Binding("Text", dtgKhuTroChoi.DataSource, "GiaTreEm"));
            txtGiaNL.DataBindings.Add(new Binding("Text", dtgKhuTroChoi.DataSource, "GiaNguoiLon"));
            dtpGioMo.Value.ToString("Text");
            dtpGioDong.Value.ToString("Text");
            dtpGioMo.DataBindings.Add(new Binding("Text", dtgKhuTroChoi.DataSource, "GioMoCua", true));
            dtpGioDong.DataBindings.Add(new Binding("Text", dtgKhuTroChoi.DataSource, "GioDongCua",true));
        }
    }
}
