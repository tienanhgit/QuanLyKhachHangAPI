using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KH_API.Models
{
    public class ChiTieuKhachHangCT
    {
    
        private string _Ma_NV;
        private string _Ma_Chi_Tieu_CT;
        private int _Thang1;
        private int _Thang2;
        private int _Thang3;
        private int _Thang4;
        private int _Thang5;
        private int _Thang6;
        private int _Thang7;
        private int _Thang8;
        private int _Thang9;
        private int _Thang10;
        private int _Thang11;
        private int _Thang12;
        public ChiTieuKhachHangCT()
        {

        }


        public ChiTieuKhachHangCT(string ma_NV, string ma_Chi_Tieu_CT, int thang1, int thang2, int thang3, int thang4, int thang5, int thang6, int thang7, int thang8, int thang9, int thang10, int thang11, int thang12)
        {
            Ma_NV = ma_NV;
            Ma_Chi_Tieu_CT = ma_Chi_Tieu_CT;
            Thang1 = thang1;
            Thang2 = thang2;
            Thang3 = thang3;
            Thang4 = thang4;
            Thang5 = thang5;
            Thang6 = thang6;
            Thang7 = thang7;
            Thang8 = thang8;
            Thang9 = thang9;
            Thang10 = thang10;
            Thang11 = thang11;
            Thang12 = thang12;
        }

        public string Ma_NV { get => _Ma_NV; set => _Ma_NV = value; }
        public string Ma_Chi_Tieu_CT { get => _Ma_Chi_Tieu_CT; set => _Ma_Chi_Tieu_CT = value; }
        public int Thang1 { get => _Thang1; set => _Thang1 = value; }
        public int Thang2 { get => _Thang2; set => _Thang2 = value; }
        public int Thang3 { get => _Thang3; set => _Thang3 = value; }
        public int Thang4 { get => _Thang4; set => _Thang4 = value; }
        public int Thang5 { get => _Thang5; set => _Thang5 = value; }
        public int Thang6 { get => _Thang6; set => _Thang6 = value; }
        public int Thang7 { get => _Thang7; set => _Thang7 = value; }
        public int Thang8 { get => _Thang8; set => _Thang8 = value; }
        public int Thang9 { get => _Thang9; set => _Thang9 = value; }
        public int Thang10 { get => _Thang10; set => _Thang10 = value; }
        public int Thang11 { get => _Thang11; set => _Thang11 = value; }
        public int Thang12 { get => _Thang12; set => _Thang12 = value; }
    }
}