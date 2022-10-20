using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Logistic.UILayer.Models;


namespace Logistic.UILayer.Controllers
{
    public class StatisticController : Controller
    {
        DBLogisticEntities db = new DBLogisticEntities();
     
        public ActionResult Index()
        {
            //v1 Toplam Sipariş
            //V2 1 numaralı müşterinin sipariş sayısı 
            //v3 Ankaranın ID değeri
            //v4 Çıkış Şehri Ankara olan Sipariş Sayısı
            //v5 Siparişlerden kazanacağım toplam para 
            //v6 ortalama sipariş tutarı 
            //v7 kitap ürünün toplam tutarı
            //
            //

            ViewBag.v1 = db.TBL_ORDER.Count();
            ViewBag.v2 = db.TBL_ORDER.Where(x => x.Order_Customer == 1).Count();
            ViewBag.v3 = db.TBL_CITY.Where(x => x.CityName == "Ankara").Select(y => y.CityID).FirstOrDefault();
            int id= ViewBag.v3 = db.TBL_CITY.Where(x => x.CityName == "Ankara").Select(y => y.CityID).FirstOrDefault();
            ViewBag.v4 = db.TBL_ORDER.Where(X => X.FromCity ==id).Count();
            ViewBag.v6 = db.TBL_ORDER.Average(x => x.OrderPrice);
            ViewBag.v7 = db.TBL_ORDER.Where(x => x.OrderProduct == "Kitap").Sum(y => y.OrderPrice);
            return View();
        }
    }
}