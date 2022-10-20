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
            var mail = Session["CustomerMail"].ToString();
            var values = db.TBL_MESSAGE.Where(x => x.MessageSender == mail).ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult SendMessage()
        {
            return View();
        }
        public ActionResult SendMessage(TBL_MESSAGE p)
        {
            db.TBL_MESSAGE.Add(p);
            db.SaveChanges();

            return RedirectToAction("Outbox");
        }
    }
}