using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Logistic.UILayer.Models;
namespace Logistic.UILayer.Controllers
{
    public class MessageController : Controller
    {
        DBLogisticEntities db = new DBLogisticEntities();

        public ActionResult Inbox()
        {
            var mail = Session["CustomerMail"].ToString();
            var values=db.TBL_MESSAGE.Where(x=>x.MessageReciever==mail).ToList();
            return View(values);
        }
        public ActionResult Outbox()
        {
            return View();
        }
    }
}