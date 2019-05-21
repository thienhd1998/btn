using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLy.Entity
{
    public class Ve
    {
        private int _ID;
        private DateTime _Ngayban;
        private int _SLTE;
        private int _SLNL;
        private int _ThanhTien;
        private int _MaNV;
        private int _MaKhu;
        public Ve()
        {
            _ID = -1;
            _Ngayban = DateTime.Now;
            _SLTE = -1;
            _SLNL = -1;
            _ThanhTien = -1;
            _MaNV = -1;
            _MaKhu = -1;
        }
        public Ve(int ID, DateTime Ngayban, int SLTE, int SLNL, int ThanhTien, int MaNV,int MaKhu)
        {
            this._ID = ID;
            this._Ngayban = Ngayban;
            this._SLTE = SLTE;
            this._SLNL = SLNL;
            this._ThanhTien = ThanhTien;
            this._MaNV = MaNV;
            this._MaKhu = MaKhu;
        }
        public int ID {
            set {
                this._ID = value;
            }
            get {
                return this._ID;
            }
        }
        public DateTime Ngayban
        {
            set
            {
                this._Ngayban = value;
            }
            get
            {
                return this._Ngayban;
            }
        }
        public int SLTE
        {
            set
            {
                this._SLTE = value;
            }
            get
            {
                return this._SLTE;
            }
        }
        public int SLNL
        {
            set
            {
                this._SLNL = value;
            }
            get
            {
                return this._SLNL;
            }
        }
        public int ThanhTien
        {
            set
            {
                this._ThanhTien = value;
            }
            get
            {
                return this._ThanhTien;
            }
        }
        public int MaNV
        {
            set
            {
                this._MaNV = value;
            }
            get
            {
                return this._MaNV;
            }
        }
        public int MaKhu
        {
            set
            {
                this._MaKhu = value;
            }
            get
            {
                return this._MaKhu;
            }
        }
    }
}
