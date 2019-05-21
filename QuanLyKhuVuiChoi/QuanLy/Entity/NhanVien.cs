using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLy.Entity
{
    public class NhanVien
    {
        private int _ID;
        private string _Hoten;
        private DateTime _Ngaysinh;
        private string _Gioitinh;
        private string _Quequan;
        private string _Chucvu;
        private int _Luong;
        public NhanVien()
        {
            _ID = -1;
            _Hoten = " ";
            _Ngaysinh = DateTime.Now;
            _Gioitinh = " ";
            _Quequan = " ";
            _Chucvu = " ";
            _Luong = -1;
        }
        public NhanVien(int ID, string Hoten, DateTime Ngaysinh,string GioiTinh,string Quequan,string Chucvu,int Luong) {
            this._ID = ID;
            this._Hoten = Hoten;
            this._Ngaysinh = Ngaysinh;
            this._Gioitinh = GioiTinh;
            this._Quequan = Quequan;
            this._Chucvu = Chucvu;
            this._Luong = Luong;
        }
        public int ID {
            set {
                this._ID = value;
            }
            get {
                return this._ID;
            }
        }
        public string Hoten
        {
            set
            {
                this._Hoten = value;
            }
            get
            {
                return this._Hoten;
            }
        }
        public DateTime Ngaysinh
        {
            set
            {
                this._Ngaysinh = value;
            }
            get
            {
                return this._Ngaysinh;
            }
        }
        public string Gioitinh
        {
            set
            {
                this._Gioitinh = value;
            }
            get
            {
                return this._Gioitinh;
            }
        }
        public string Quequan
        {
            set
            {
                this._Quequan = value;
            }
            get
            {
                return this._Quequan;
            }
        }
        public string Chucvu
        {
            set
            {
                this._Chucvu = value;
            }
            get
            {
                return this._Chucvu;
            }
        }
        public int Luong
        {
            set
            {
                this._Luong = value;
            }
            get
            {
                return this._Luong;
            }
        }
    }
}
