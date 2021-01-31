using KH_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KH_API.Controllers
{
    public class ChiTieuKhachHangCTAPIController : ApiController
    {

        public static List<ChiTieuKhachHangCT> listChiTieuKhachHangCT = new List<ChiTieuKhachHangCT>()
        {
            new ChiTieuKhachHangCT(){Ma_Chi_Tieu_CT="CT01",Ma_NV="NV01",Thang1=10,Thang2=10,Thang3=10,
            Thang5=10,Thang6=10,Thang7=20,Thang8=10,Thang9=10,Thang10=10,Thang11=10,Thang12=10
            },
              new ChiTieuKhachHangCT(){Ma_Chi_Tieu_CT="CT01",Ma_NV="NV02",Thang1=10,Thang2=10,Thang3=10,
            Thang5=10,Thang6=10,Thang7=20,Thang8=10,Thang9=10,Thang10=10,Thang11=10,Thang12=10
            },
                new ChiTieuKhachHangCT(){Ma_Chi_Tieu_CT="CT02",Ma_NV="NV02",Thang1=10,Thang2=10,Thang3=10,
            Thang5=10,Thang6=10,Thang7=20,Thang8=10,Thang9=10,Thang10=10,Thang11=10,Thang12=10
            },
                     new ChiTieuKhachHangCT(){Ma_Chi_Tieu_CT="CT02",Ma_NV="NV01",Thang1=10,Thang2=10,Thang3=10,
            Thang5=10,Thang6=10,Thang7=20,Thang8=10,Thang9=10,Thang10=10,Thang11=10,Thang12=10
            },
                           new ChiTieuKhachHangCT(){Ma_Chi_Tieu_CT="CT03",Ma_NV="NV04",Thang1=10,Thang2=10,Thang3=10,
            Thang5=10,Thang6=10,Thang7=20,Thang8=10,Thang9=10,Thang10=10,Thang11=10,Thang12=10
            }
        };



    }
}
