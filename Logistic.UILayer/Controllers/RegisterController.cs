using Logistic.UILayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Logistic.UILayer.Controllers
{
    public class RegisterController : Controller
    {
       DBLogisticEntities db = new DBLogisticEntities();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
         public ActionResult Index(TBL_CUSTOMER p)
        {
            db.TBL_CUSTOMER.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index", "Login");
        }
        public PartialViewResult PartialHead()
        {

            return PartialView();
        }
    }
}