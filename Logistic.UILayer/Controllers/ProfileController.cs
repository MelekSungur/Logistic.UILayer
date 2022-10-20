using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Logistic.UILayer.Models;

namespace Logistic.UILayer.Controllers
{
    public class ProfileController : Controller
    {
        DBLogisticEntities db = new DBLogisticEntities();        // GET: Profile
        public ActionResult Index()
        {
            var name = Session["CustomerName"].ToString();
            var values=db.TBL_CUSTOMER.Where(x=>x.CustomerName==name).FirstOrDefault();
            ViewBag.v1 = values.CustomerName;
            ViewBag.v2 = values.CustomerSurname;
            ViewBag.v3 = values.CustomerPhone;

            return View();
        }
    }
}