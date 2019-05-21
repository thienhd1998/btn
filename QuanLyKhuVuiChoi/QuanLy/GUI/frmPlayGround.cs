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
    public partial class frmPlayGround : Form
    {
        public frmPlayGround()
        {
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            string query = "SELECT MaKhu as [Mã Khu],TenKhu as [Tên Khu],GiaTreEm as [Giá Trẻ Em],GiaNguoiLon as[Giá Người Lớn],GioMoCua as [Giờ Mở Cửa],GioDongCua as[Giờ Đóng Cửa]  FROM KHUTROCHOI";
            dtgPlayGround.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtIdGround.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập mã khu", "Thông báo");
                ActiveControl = txtIdGround;
                return;
            }
            string query = "INSERT INTO KHUTROCHOI(MaKhu, TenKhu, GiaTreEm, GiaNguoiLon, GioMoCua,GioDongCua)" +
                " VALUES('" + txtIdGround.Text + "', N'" + txtNameGround.Text + "','" + txtPayChildren.Text +
                "','" + txtPayAdults.Text + "','" + dtpOn.Text + "','" + dtpOff.Text + "')";
            DataProvider.Instance.ExecuteNonQuery(query);
                query = "SELECT * FROM KHUTROCHOI";
                dtgPlayGround.DataSource = DataProvider.Instance.ExecuteQuery(query);
                dtgPlayGround.Refresh();
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
            //for (int i = 0; i < lsvPlayGround.Items.Count; i++)
            //{
            //    if (lsvPlayGround.Items[i].SubItems[0].Text == Tmp)
            //    {
            //        lsvPlayGround.SelectedItems.Clear(); //Xóa lựa chọn dòng trước đó
            //        lsvPlayGround.Items[i].Selected = true; //Chọn dòng tìm kiếm
            //        lsvPlayGround.Refresh();                //Làm tươi lại màn hình
            //        ActiveControl = lsvPlayGround;
            //        return;
            //    }
            //}

            ////Nếu không thì hiển thị dòng thông báo không tìm thấy
            //MessageBox.Show("Không tìm thấy mã khu = " + Tmp + ". Mời bạn tìm lại...", "Thông báo");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            //B1: Kiểm tra có dữ liệu không?
            //if (lsvPlayGround.Items.Count == 0)
            //    return;

            ////B2: Thiết lập vị trị
            //int index = 0;

            ////B3: Hiển thị
            //lsvPlayGround.SelectedItems.Clear(); //Xóa lựa chọn dòng trước đó
            //lsvPlayGround.Items[index].Selected = true; //Chọn dòng đầu tiên của ListView
            //lsvPlayGround.Refresh();                //Làm tươi lại màn hình
            //ActiveControl = lsvPlayGround;          //Chuyển quyền điều khiển cho ListView
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            ////B1: Kiểm tra có dữ liệu không?
            //if (lsvPlayGround.Items.Count == 0)
            //    return;

            ////B2: Thiết lập vị trị
            //int index = lsvPlayGround.Items.Count - 1;

            ////B3: Hiển thị
            //lsvPlayGround.SelectedItems.Clear(); //Xóa lựa chọn dòng trước đó
            //lsvPlayGround.Items[index].Selected = true; //Chọn dòng đầu tiên của ListView
            //lsvPlayGround.Refresh();                //Làm tươi lại màn hình
            //ActiveControl = lsvPlayGround;          //Chuyển quyền điều khiển cho ListView
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //B1: Kiểm tra có dữ liệu không?
            //if (lsvPlayGround.Items.Count == 0)
            //    return;
            //if (lsvPlayGround.SelectedItems.Count == 0) //Nếu không có dòng nào được chọn
            //    return;

            ////B2: Thiết lập vị trị: về bản ghi trước
            //int index = lsvPlayGround.Items.IndexOf(lsvPlayGround.SelectedItems[0]); //Lấy dòng hiện thời
            //if (index > 0)
            //    index = index - 1; //chuyển về dòng trước đó

            ////B3: Hiển thị
            //lsvPlayGround.SelectedItems.Clear(); //Xóa lựa chọn dòng trước đó
            //lsvPlayGround.Items[index].Selected = true; //Chọn dòng đầu tiên của ListView
            //lsvPlayGround.Refresh();                //Làm tươi lại màn hình
            //ActiveControl = lsvPlayGround;          //Chuyển quyền điều khiển cho ListView
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            ////B1: Kiểm tra có dữ liệu không?
            //if (lsvPlayGround.Items.Count == 0)
            //    return;
            //if (lsvPlayGround.SelectedItems.Count == 0) //Nếu không có dòng nào được chọn
            //    return;

            ////B2: Thiết lập vị trị: 
            //int index = lsvPlayGround.Items.IndexOf(lsvPlayGround.SelectedItems[0]); //Lấy dòng hiện thời
            //if (index < lsvPlayGround.Items.Count - 1)
            //    index = index + 1; //chuyển về dòng phía sau

            ////B3: Hiển thị
            //lsvPlayGround.SelectedItems.Clear(); //Xóa lựa chọn dòng trước đó
            //lsvPlayGround.Items[index].Selected = true; //Chọn dòng đầu tiên của ListView
            //lsvPlayGround.Refresh();                //Làm tươi lại màn hình
            //ActiveControl = lsvPlayGround;          //Chuyển quyền điều khiển cho ListView
        }
    }
}
