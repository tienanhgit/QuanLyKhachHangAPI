using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using KH_API.Models;
using Newtonsoft.Json;

namespace KH_API.Controllers
{
    public class KhachHangAPIController : ApiController
    {
        public static int Ma_Chi_Tieu = 1;
        public static int Ma_Chi_Tieu_CT = 1;
        public static List<ChiTieuKhachHang> listCTKH = new List<ChiTieuKhachHang>() {
        new ChiTieuKhachHang(){Nam=2020,Ten_Chi_Tieu="Chi Tieu 1",Ma_Chi_Tieu="CT01",Status="Sử dụng"},
        new ChiTieuKhachHang(){Nam=2020,Ten_Chi_Tieu="Chi Tieu 2",Ma_Chi_Tieu="CT02",Status="Sử dụng"},
        new ChiTieuKhachHang(){Nam=2021,Ten_Chi_Tieu="Chi Tieu 3",Ma_Chi_Tieu="CT03",Status="Không sử dụng"},
        new ChiTieuKhachHang(){Nam=2022,Ten_Chi_Tieu="Chi Tieu 4",Ma_Chi_Tieu="CT04",Status="Không sử dụng"},
        new ChiTieuKhachHang(){Nam=2021,Ten_Chi_Tieu="Chi Tieu 5",Ma_Chi_Tieu="CT05",Status="Không sử dụng"}
        };
        static List<ChiTieuKhachHangCT> tempChiTieuCT;
        [HttpGet]
        public HttpResponseMessage getChitieu()
        {
            tempChiTieuCT = new List<ChiTieuKhachHangCT>();
            ChiTieuKhachHangCT chiTieuKhachHangCT;
            for (int i = 0; i < ChiTieuKhachHangCTAPIController.listChiTieuKhachHangCT.Count; i++)
            {
                chiTieuKhachHangCT = new ChiTieuKhachHangCT();
                chiTieuKhachHangCT.Ma_NV = ChiTieuKhachHangCTAPIController.listChiTieuKhachHangCT[i].Ma_NV;
                chiTieuKhachHangCT.Ma_Chi_Tieu_CT = ChiTieuKhachHangCTAPIController.listChiTieuKhachHangCT[i].Ma_Chi_Tieu_CT;
                chiTieuKhachHangCT.Thang1 = ChiTieuKhachHangCTAPIController.listChiTieuKhachHangCT[i].Thang1;
                chiTieuKhachHangCT.Thang2 = ChiTieuKhachHangCTAPIController.listChiTieuKhachHangCT[i].Thang2;
                chiTieuKhachHangCT.Thang3 = ChiTieuKhachHangCTAPIController.listChiTieuKhachHangCT[i].Thang3;
                chiTieuKhachHangCT.Thang4 = ChiTieuKhachHangCTAPIController.listChiTieuKhachHangCT[i].Thang4;
                chiTieuKhachHangCT.Thang5 = ChiTieuKhachHangCTAPIController.listChiTieuKhachHangCT[i].Thang5;
                chiTieuKhachHangCT.Thang6 = ChiTieuKhachHangCTAPIController.listChiTieuKhachHangCT[i].Thang6;
                chiTieuKhachHangCT.Thang7 = ChiTieuKhachHangCTAPIController.listChiTieuKhachHangCT[i].Thang7;
                chiTieuKhachHangCT.Thang8 = ChiTieuKhachHangCTAPIController.listChiTieuKhachHangCT[i].Thang8;
                chiTieuKhachHangCT.Thang9 = ChiTieuKhachHangCTAPIController.listChiTieuKhachHangCT[i].Thang9;
                chiTieuKhachHangCT.Thang10 = ChiTieuKhachHangCTAPIController.listChiTieuKhachHangCT[i].Thang10;
                chiTieuKhachHangCT.Thang11 = ChiTieuKhachHangCTAPIController.listChiTieuKhachHangCT[i].Thang11;
                chiTieuKhachHangCT.Thang12 = ChiTieuKhachHangCTAPIController.listChiTieuKhachHangCT[i].Thang12;
                tempChiTieuCT.Add(chiTieuKhachHangCT);
            }

            foreach (var t in tempChiTieuCT)
            {
                bool has = false;
                foreach (var lsCTKH in listCTKH)
                {
                    if (lsCTKH.Ma_Chi_Tieu == t.Ma_Chi_Tieu_CT)
                    {
                        has = true;
                        break;
                    }
                }
                if (has == false) tempChiTieuCT.Remove(t);
            }

            for (int i = 0; i < tempChiTieuCT.Count; i++)
            {
                for (int j = tempChiTieuCT.Count - 1; j > i; j--)
                {
                    if (tempChiTieuCT[i].Ma_Chi_Tieu_CT == tempChiTieuCT[j].Ma_Chi_Tieu_CT)
                    {
                        tempChiTieuCT[i].Thang1 += tempChiTieuCT[j].Thang1;
                        tempChiTieuCT[i].Thang2 += tempChiTieuCT[j].Thang2;
                        tempChiTieuCT[i].Thang3 += tempChiTieuCT[j].Thang3;
                        tempChiTieuCT[i].Thang4 += tempChiTieuCT[j].Thang4;
                        tempChiTieuCT[i].Thang5 += tempChiTieuCT[j].Thang5;
                        tempChiTieuCT[i].Thang6 += tempChiTieuCT[j].Thang6;
                        tempChiTieuCT[i].Thang7 += tempChiTieuCT[j].Thang7;
                        tempChiTieuCT[i].Thang8 += tempChiTieuCT[j].Thang8;
                        tempChiTieuCT[i].Thang9 += tempChiTieuCT[j].Thang9;
                        tempChiTieuCT[i].Thang10 += tempChiTieuCT[j].Thang10;
                        tempChiTieuCT[i].Thang11 += tempChiTieuCT[j].Thang11;
                        tempChiTieuCT[i].Thang12 += tempChiTieuCT[j].Thang12;
                        tempChiTieuCT.RemoveAt(j);
                    }

                }
            }
            return Request.CreateResponse(HttpStatusCode.OK, JsonConvert.SerializeObject(Tuple.Create(tempChiTieuCT, listCTKH)));
        }

        [HttpGet]
        public HttpResponseMessage getChitieu2()
        {
            return Request.CreateResponse(HttpStatusCode.OK, JsonConvert.SerializeObject(Tuple.Create(ChiTieuKhachHangCTAPIController.listChiTieuKhachHangCT)));
        }

        [HttpPost]
        public HttpResponseMessage ThemMoiChiTieuCT(List<ChiTieuKhachHangCT> lsChiTieu)
        {
            Ma_Chi_Tieu++;
            ChiTieuKhachHangCT chiTieuKhachCT = new ChiTieuKhachHangCT();
            for (int i = 0; i < lsChiTieu.Count; i++)
            {
                chiTieuKhachCT.Ma_Chi_Tieu_CT = Convert.ToString(Ma_Chi_Tieu);
                chiTieuKhachCT.Ma_NV = lsChiTieu[i].Ma_NV;
                chiTieuKhachCT.Thang1 = lsChiTieu[i].Thang1;
                chiTieuKhachCT.Thang2 = lsChiTieu[i].Thang2;
                chiTieuKhachCT.Thang3 = lsChiTieu[i].Thang3;
                chiTieuKhachCT.Thang4 = lsChiTieu[i].Thang4;
                chiTieuKhachCT.Thang5 = lsChiTieu[i].Thang5;
                chiTieuKhachCT.Thang6 = lsChiTieu[i].Thang6;
                chiTieuKhachCT.Thang7 = lsChiTieu[i].Thang7;
                chiTieuKhachCT.Thang8 = lsChiTieu[i].Thang8;
                chiTieuKhachCT.Thang9 = lsChiTieu[i].Thang9;
                chiTieuKhachCT.Thang10 = lsChiTieu[i].Thang10;
                chiTieuKhachCT.Thang11 = lsChiTieu[i].Thang11;
                chiTieuKhachCT.Thang12 = lsChiTieu[i].Thang12;
                ChiTieuKhachHangCTAPIController.listChiTieuKhachHangCT.Add(chiTieuKhachCT);

            }
            return Request.CreateResponse(HttpStatusCode.OK, JsonConvert.SerializeObject(Tuple.Create(ChiTieuKhachHangCTAPIController.listChiTieuKhachHangCT)));
        }
        [HttpPost]
        public HttpResponseMessage ThemMoiChiTieu(ChiTieuKhachHang chiTieuKhachHang)
        {
            Ma_Chi_Tieu_CT = Ma_Chi_Tieu_CT + 1;

            ChiTieuKhachHang chiTieuKhach = new ChiTieuKhachHang();
            chiTieuKhach.Nam = chiTieuKhachHang.Nam;
            chiTieuKhach.Status = chiTieuKhachHang.Status;
            chiTieuKhach.Ten_Chi_Tieu = chiTieuKhachHang.Ten_Chi_Tieu;
            chiTieuKhach.Ma_Chi_Tieu = Convert.ToString(Ma_Chi_Tieu_CT);
            listCTKH.Add(chiTieuKhach);
            return Request.CreateResponse(HttpStatusCode.OK, JsonConvert.SerializeObject(Tuple.Create(listCTKH)));

        }

        [HttpGet]

        public HttpResponseMessage SearchChiTieu(string str)
        {
            List<ChiTieuKhachHang> listitem = new List<ChiTieuKhachHang>();
            if (str == null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, listCTKH);
            }
            else
            {
                for (int i = 0; i < listCTKH.Count; i++)
                {
                    if (Convert.ToString(listCTKH[i].Nam).Contains(str) || listCTKH[i].Ten_Chi_Tieu.Contains(str))
                    {
                        listitem.Add(listCTKH[i]);
                    }
                }
                return Request.CreateResponse(HttpStatusCode.OK, JsonConvert.SerializeObject(Tuple.Create(tempChiTieuCT, listitem)));
            }

        }

        //Xoa

        [HttpPost]
        public HttpResponseMessage DeleteTieuChi(List<string> strMa)
        {
            foreach (var str in strMa)
            {
                for (int i = listCTKH.Count - 1; i > -1; i--)
                {
                    if (listCTKH[i].Ma_Chi_Tieu == str)
                    {
                        listCTKH.RemoveAt(i);
                    }
                }
                for (int i = ChiTieuKhachHangCTAPIController.listChiTieuKhachHangCT.Count - 1; i > -1; i--)
                {
                    if (ChiTieuKhachHangCTAPIController.listChiTieuKhachHangCT[i].Ma_Chi_Tieu_CT == str)
                    {
                        ChiTieuKhachHangCTAPIController.listChiTieuKhachHangCT.RemoveAt(i);
                    }
                }
            }
            return Request.CreateResponse(HttpStatusCode.OK);

        }
        [HttpPost]
        public HttpResponseMessage UpdateChiTieu(ChiTieuKhachHang chiTieuKhachHang)
        {
            for (int i = 0; i < listCTKH.Count; i++)
            {
                if (chiTieuKhachHang.Ma_Chi_Tieu.Equals(listCTKH[i].Ma_Chi_Tieu))
                {
                    listCTKH[i].Nam = chiTieuKhachHang.Nam;
                    listCTKH[i].Status = chiTieuKhachHang.Status;
                    listCTKH[i].Ten_Chi_Tieu = chiTieuKhachHang.Ten_Chi_Tieu;
                    break;
                }
            }
            return Request.CreateResponse(HttpStatusCode.OK, true);

        }





    }
}
