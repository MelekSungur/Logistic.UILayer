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
    }
}