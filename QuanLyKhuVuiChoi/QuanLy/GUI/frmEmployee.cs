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
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            string query = "select MaNV as[Mã NV],HoTen as[Họ và Tên],NgaySinh as[Ngày Sinh],GioiTinh as[Giới Tính],QueQuan as[Quê Quán],ChucVu as[Chức vụ],Luong as[Lương],MaPB as[Mã PB],MaKhu as[Mã Khu],MaTro as[Mã Trò] from NHANVIEN";
            dtgEmployee.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //// Bước 1: kiểm tra dữ liệu
            //if (txtId.Text.Trim() == "")
            //{
            //    MessageBox.Show("Bạn phải nhập mã sinh viên","Thông báo");
            //    ActiveControl = txtId;
            //    return;
            //}
            //DateTime date = dtpBirth.Value;
            //int _ID = 0;
            //int _Luong = 0;
            //_Luong = Convert.ToInt32(txtPay.Text.Trim());
            //_ID = Convert.ToInt16(txtId.Text.Trim());
            ////Bước 2: tạo đối tượng
            //Entity.NhanVien objNhanvien = new Entity.NhanVien();
            //objNhanvien.ID = _ID;
            //objNhanvien.Hoten = txtName.Text.Trim();
            //objNhanvien.Quequan = txtAddress.Text.Trim();
            //objNhanvien.Chucvu = txtJob.Text.Trim();
            //objNhanvien.Luong = _Luong;
            //objNhanvien.Ngaysinh = date;
            //// Bước 3 chèn danh sách
            //string[] str = new string[7];
            //str[0] = objNhanvien.ID.ToString();
            //str[1] = objNhanvien.Hoten;
            //if (cbMales.CheckState == CheckState.Checked)
            //{
            //    cbFemales.CheckState = CheckState.Unchecked;
            //    str[2] = "Nam";
            //}
            //if (cbFemales.CheckState == CheckState.Checked)
            //{
            //    cbMales.CheckState = CheckState.Unchecked;
            //    str[2] = "Nữ";
            //}
            //str[3] = objNhanvien.Ngaysinh.ToString();
            //str[4] = objNhanvien.Quequan;
            //str[5] = objNhanvien.Luong.ToString();
            //str[6] = objNhanvien.Chucvu;

            //ListViewItem item = new ListViewItem(str);
            //lsvEmployee.Items.Add(item);
            //lsvEmployee.Refresh();

            if (txtId.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập mã PB", "Thông báo");
                ActiveControl = txtId;
                return;
            }
            Entity.NhanVien objNhanvien = new Entity.NhanVien();

            if (cbMales.CheckState == CheckState.Checked)
            {
                //cbFemales.CheckState = CheckState.Unchecked;
                objNhanvien.Gioitinh = "Nam";
                
            }
            if (cbFemales.CheckState == CheckState.Checked)
            {
                //cbMales.CheckState = CheckState.Unchecked;
                objNhanvien.Gioitinh = "Nữ";
            }

            string query = "INSERT INTO NHANVIEN(MaNV,HoTen,NgaySinh,GioiTinh,QueQuan,ChucVu,Luong,MaPB,MaKhu,MaTro)" +
                " VALUES('" + txtId.Text + "', N'" + txtName.Text + "','" + dtpBirth.Value.ToString("MM/dd/yyyy")+
                "','" + objNhanvien + "','" + txtAddress.Text + "','" + txtJob.Text + "','" + txtPay.Text + "','" + txtIdDpm.Text + "','" + txtIdGround.Text + "','" + txtIdGame.Text + "')";
            DataProvider.Instance.ExecuteNonQuery(query);
            query = "SELECT * FROM NHANVIEN";
            dtgEmployee.DataSource = DataProvider.Instance.ExecuteQuery(query);
            dtgEmployee.Refresh();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ////B1: Hiện thị giao diện tìm kiếm
            //frmNhanVien_Timtheoma frmTim = new frmNhanVien_Timtheoma();
            //frmTim.ShowDialog();

            ////B2: Nhận giá trị tìm kiếm: thực hiện tìm kiếm trên ListView
            //string Tmp = frmTim.LayGiaTriTimKiem();
            //if (Tmp == "")
            //{
            //    return;
            //}

            ////B3: Tìm kiếm 
            //for (int i = 0; i < lsvEmployee.Items.Count; i++)
            //{
            //    if (lsvEmployee.Items[i].SubItems[0].Text == Tmp)
            //    {
            //        lsvEmployee.SelectedItems.Clear(); //Xóa lựa chọn dòng trước đó
            //        lsvEmployee.Items[i].Selected = true; //Chọn dòng tìm kiếm
            //        lsvEmployee.Refresh();                //Làm tươi lại màn hình
            //        ActiveControl = lsvEmployee;
            //        return;
            //    }
            //}

            //Nếu không thì hiển thị dòng thông báo không tìm thấy
            //MessageBox.Show("Không tìm thấy mã chuyên ngành = " + Tmp + ". Mời bạn tìm lại...","Thông báo");


        }

        

    }
}
