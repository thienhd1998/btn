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
    public partial class frmNhanVien : Form
    {
        BindingSource NhanVien = new BindingSource();
        public frmNhanVien()
        {
            InitializeComponent();
            LoadData();
            BindingNV();
        }
        void LoadData()
        {
            dtgNhanVien.DataSource = NhanVien;
            string query = "sp_NhanVien_Select";
            NhanVien.DataSource = DataProvider.Instance.ExecuteQuery(query);
            dtgNhanVien.Refresh();
        }
        void NhanVien_Insert()
        {
            string query = " sp_Nhanvien_insert N'" + txtTenNV.Text + "','" + dtpNgaySinh.Value.ToString("MM/dd/yyyy") + "',N'" + cbbGioiTinh.Text + "',N'" + txtQueQuan.Text + "',N'" + txtChucVu.Text + "','" + txtLuong.Text + "',null,null,null";
            DataProvider.Instance.ExecuteNonQuery(query);
            LoadData();
        }
        void NhanVien_Update()
        {
            string query = "sp_Nhanvien_update '" + txtMaNV.Text + "', N'" + txtTenNV.Text + "','" + dtpNgaySinh.Value.ToString("MM/dd/yyyy") + "' , N'" + cbbGioiTinh.Text + "',N'" + txtQueQuan.Text + "',N'" + txtChucVu.Text + "','" + txtLuong.Text + "','" + txtMaPB.Text + "','" + txtMaKhu.Text + "','" + txtMaTro.Text + "'";
            DataProvider.Instance.ExecuteNonQuery(query);
            LoadData();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string MaKhu = txtMaKhu.Text.Trim();
            string MaPB = txtMaPB.Text.Trim();
            string MaTro = txtMaTro.Text.Trim();

            if (MaKhu == "" && MaPB == "" && MaTro == "")
            {
                NhanVien_Insert();
            }

            else if (MaKhu == "" && MaPB == "")
            {
                if (KiemTraDAO.Istance.CheckMaTro(MaTro))
                {
                    NhanVien_Insert();
                }
                else
                    MessageBox.Show("Mã trò chơi không tồn tại", "Thông báo");
            }
            // Hom nay ngay 21/5
            else if (MaKhu == "" && MaTro == "")
            {
                if (KiemTraDAO.Istance.CheckMaPB(MaPB))
                {
                    NhanVien_Insert();
                }
                else
                    MessageBox.Show("Mã phòng ban không tồn tại", "Thông báo");
            }
            else if (MaTro == "" && MaPB == "")
            {
                if (KiemTraDAO.Istance.CheckMaKhu(MaKhu))
                {
                    NhanVien_Insert();
                }
                else
                    MessageBox.Show("Mã khu không tồn tại", "Thông báo");
            }
            else if (MaKhu == "")
            {
                if (KiemTraDAO.Istance.CheckMaPB(MaPB) && KiemTraDAO.Istance.CheckMaTro(MaTro))
                {
                    NhanVien_Insert();
                }
                else
                    MessageBox.Show("Mã phòng ban hoặc mã trò không tồn tại", "Thông báo");
            }
            else if (MaPB == "")
            {
                if (KiemTraDAO.Istance.CheckMaTro(MaTro) && KiemTraDAO.Istance.CheckMaKhu(MaKhu))
                {
                    NhanVien_Insert();
                }
                else
                    MessageBox.Show("Mã khu hoặc mã trò không tồn tại", "Thông báo");
            }
            else if (MaTro == "")
            {
                if (KiemTraDAO.Istance.CheckMaKhu(MaKhu) && KiemTraDAO.Istance.CheckMaPB(MaPB))
                {
                    NhanVien_Insert();
                }
                else
                    MessageBox.Show("Mã khu hoặc phòng ban không tồn tại", "Thông báo");
            }
            else
            {
                if (KiemTraDAO.Istance.CheckMaKhu(MaKhu) && KiemTraDAO.Istance.CheckMaPB(MaPB) && KiemTraDAO.Istance.CheckMaTro(MaTro))
                {
                    NhanVien_Insert();
                }
                else
                    MessageBox.Show("Mã khu, mã trò chơi hoặc mã phòng ban không tồn tại", "Thông báo");
            }
            
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string query = "sp_Nhanvien_Delete '"+txtMaNV.Text+"'";
            DataProvider.Instance.ExecuteNonQuery(query);
            LoadData();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string MaKhu = txtMaKhu.Text.Trim();
            string MaPB = txtMaPB.Text.Trim();
            string MaTro = txtMaTro.Text.Trim();

            if (MaKhu == "" && MaPB == "" && MaTro == "")
            {
                NhanVien_Update();
            }
            else if (MaKhu == "" && MaPB == "")
            {
                if (KiemTraDAO.Istance.CheckMaTro(MaTro))
                {
                    NhanVien_Update();
                }
                else
                    MessageBox.Show("Mã trò chơi không tồn tại", "Thông báo");
            }
            else if (MaKhu == "" && MaTro == "")
            {
                if (KiemTraDAO.Istance.CheckMaPB(MaPB))
                {
                    NhanVien_Update();
                }
                else
                    MessageBox.Show("Mã phòng ban không tồn tại", "Thông báo");
            }
            else if (MaTro == "" && MaPB == "")
            {
                if (KiemTraDAO.Istance.CheckMaKhu(MaKhu))
                {
                    NhanVien_Update();
                }
                else
                    MessageBox.Show("Mã khu không tồn tại", "Thông báo");
            }
            else if (MaKhu == "")
            {
                if (KiemTraDAO.Istance.CheckMaPB(MaPB) && KiemTraDAO.Istance.CheckMaTro(MaTro))
                {
                    NhanVien_Update();
                }
                else
                    MessageBox.Show("Mã phòng ban hoặc mã trò không tồn tại", "Thông báo");
            }
            else if (MaPB == "")
            {
                if (KiemTraDAO.Istance.CheckMaTro(MaTro) && KiemTraDAO.Istance.CheckMaKhu(MaKhu))
                {
                    NhanVien_Update();
                }
                else
                    MessageBox.Show("Mã khu hoặc mã trò không tồn tại", "Thông báo");
            }
            else if (MaTro == "")
            {
                if (KiemTraDAO.Istance.CheckMaKhu(MaKhu) && KiemTraDAO.Istance.CheckMaPB(MaPB))
                {
                    NhanVien_Update();
                }
                else
                    MessageBox.Show("Mã khu hoặc phòng ban không tồn tại", "Thông báo");
            }
            else
            {
                if (KiemTraDAO.Istance.CheckMaKhu(MaKhu) && KiemTraDAO.Istance.CheckMaPB(MaPB) && KiemTraDAO.Istance.CheckMaTro(MaTro))
                {
                    NhanVien_Update();
                }
                else
                    MessageBox.Show("Mã khu, mã trò chơi hoặc mã phòng ban không tồn tại", "Thông báo");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
        void BindingNV()
        {
            txtMaNV.DataBindings.Add("Text", dtgNhanVien.DataSource, "MaNV");
            txtTenNV.DataBindings.Add("Text", dtgNhanVien.DataSource, "HoTen");
            dtpNgaySinh.DataBindings.Add("Value", dtgNhanVien.DataSource, "NgaySinh",true);
            txtQueQuan.DataBindings.Add("Text", dtgNhanVien.DataSource, "QueQuan");
            txtChucVu.DataBindings.Add("Text", dtgNhanVien.DataSource, "ChucVu");
            txtMaKhu.DataBindings.Add("Text", dtgNhanVien.DataSource, "MaKhu");
            txtMaPB.DataBindings.Add("Text", dtgNhanVien.DataSource, "MaPB");
            txtMaTro.DataBindings.Add("Text", dtgNhanVien.DataSource, "MaTro");
            txtLuong.DataBindings.Add("Text", dtgNhanVien.DataSource, "Luong");
        }
    }
}
