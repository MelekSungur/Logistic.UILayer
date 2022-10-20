using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Logistic.UILayer.Models;

namespace Logistic.UILayer.Controllers
{
    public class OrderController : Controller
    {

        DBLogisticEntities db =new  DBLogisticEntities();

        public ActionResult Index()
        {
            //view oluşturmadan önce bu kıodlar yazılmış olmalı yoksa hata döner.
            var values = db.TBL_ORDER.ToList();
            return View(values);
        }
        public ActionResult DeleteOrder(int id)
        {
            var values = db.TBL_ORDER.Find(id);
            db.TBL_ORDER.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        [HttpGet]
        public ActionResult UpdateOrder(int id)
        {
            var values = db.TBL_ORDER.Find(id);
            return View(values);


        }
        [HttpPost]
        public ActionResult UpdateOrder(TBL_ORDER p)
        {
            db.SaveChanges();
            return (p);

        }

    }
}