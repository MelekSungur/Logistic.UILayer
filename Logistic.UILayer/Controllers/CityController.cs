using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Logistic.UILayer.Models;
namespace Logistic.UILayer.Controllers
{
    public class CityController : Controller
    {
        DBLogisticEntities db=new DBLogisticEntities();
        // GET: City
        public ActionResult Index()
        {
           var values= db.TBL_CITY.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddCity()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCity(TBL_CITY p)
        {
            db.TBL_CITY.Add(p);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
        public ActionResult DeleteCity(int id)
        {
            var values = db.TBL_CITY.Find(id);
            db.TBL_CITY.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");


            
        }
        [HttpGet]
        public  ActionResult UpdateCity(int id)
        {
            var values = db.TBL_CITY.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateCity(TBL_CITY p)
        {
            var values = db.TBL_CITY.Find(p.CityID);
            values.CityName=p.CityName;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}