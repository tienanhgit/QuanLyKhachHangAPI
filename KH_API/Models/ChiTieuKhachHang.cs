using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KH_API.Models
{
    public class ChiTieuKhachHang
    {
        private int _Nam;
        private string _Ten_Chi_Tieu;
        private string _Status;
        private string _Ma_Chi_Tieu;
      
           

        public int Nam { get => _Nam; set => _Nam = value; }
        public string Ten_Chi_Tieu { get => _Ten_Chi_Tieu; set => _Ten_Chi_Tieu = value; }
        public string Status { get => _Status; set => _Status = value; }
        public string Ma_Chi_Tieu { get => _Ma_Chi_Tieu; set => _Ma_Chi_Tieu = value; }

        public ChiTieuKhachHang(int nam, string ten_Chi_Tieu, string status, string ma_Chi_Tieu)
        {
            Nam = nam;
            Ten_Chi_Tieu = ten_Chi_Tieu;
            Status = status;
            Ma_Chi_Tieu = ma_Chi_Tieu;
        }

        public ChiTieuKhachHang()
        {
        }

    }
}