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
    public partial class frmHoaDon : Form
    {
        BindingSource HoaDon = new BindingSource();
        public frmHoaDon()
        {
            InitializeComponent();
            LoadHoaDon();
            Binding();
        }
        void LoadHoaDon()
        {
            dtgHoaDon.DataSource = HoaDon;
            HoaDon.DataSource = DataProvider.Instance.ExecuteQuery("sp_Hoadon_Select");
            dtgHoaDon.Refresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string query = "sp_Hoadon_Insert '" + dtpNgaySD.Value.ToString("MM/dd/yyyy") + "'";
            DataProvider.Instance.ExecuteNonQuery(query);
            LoadHoaDon();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string query = "sp_Hoadon_update '" + txtMaHD.Text + "', '" + dtpNgaySD.Value.ToString("MM/dd/yyyy") + "'";
            DataProvider.Instance.ExecuteNonQuery(query);
            LoadHoaDon();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string query = "sp_HoaDon_Delete '" + txtMaHD.Text + "'";
            DataProvider.Instance.ExecuteNonQuery(query);
            LoadHoaDon();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
        void Binding()
        {
            txtMaHD.DataBindings.Add(new Binding("Text", dtgHoaDon.DataSource, "MaHD"));
            dtpNgaySD.DataBindings.Add(new Binding("Value", dtgHoaDon.DataSource, "NgaySD", true));
        }
    }
}
