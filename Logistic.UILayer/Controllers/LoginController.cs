﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Logistic.UILayer.Models;

namespace Logistic.UILayer.Controllers
{
    [AllowAnonymous]
   
    public class LoginController : Controller
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
            var values = db.TBL_CUSTOMER.FirstOrDefault(x => x.CustomerMail == p.CustomerMail && x.CustomerPassword==p.CustomerPassword);
            if (values != null)
            {
                FormsAuthentication.SetAuthCookie(values.CustomerName, false);
                Session["CustomerMail"] = values.CustomerMail;
                return RedirectToAction("Index", "Dashboard");
            }
            else
            {
                return RedirectToAction("Index");
            }

       
        }

    }
}