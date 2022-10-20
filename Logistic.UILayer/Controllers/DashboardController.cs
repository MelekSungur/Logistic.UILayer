using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Logistic.UILayer.Models;

namespace Logistic.UILayer.Controllers
{
    public class DashboardController : Controller
    {
        DBLogisticEntities db = new DBLogisticEntities();
        // GET: Dashboard
        public ActionResult Index()
        {
            ViewBag.v1 = db.TBL_CATEGORY.Count();
            ViewBag.v2= db.TBL_CUSTOMER.Count();
            ViewBag.v3 = db.TBL_CATEGORY.Where(x => x.CategoryID == 1).Select(y => y.CategoryName).FirstOrDefault();
            ViewBag.v4=db.TBL_CATEGORY.Where(x=>x.CategoryStatus==true).Count();
            return View();
        }
    }
}