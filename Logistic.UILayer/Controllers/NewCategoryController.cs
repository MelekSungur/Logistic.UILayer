 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Logistic.UILayer.Models;

namespace Logistic.UILayer.Controllers
{
    public class NewCategoryController : Controller
    {
        // GET: NewCategory
        DBLogisticEntities db = new DBLogisticEntities();
        public ActionResult Index()
        {
            var values = db.TBL_CATEGORY.ToList();
            return View(values);
        }
        [HttpGet]
        public  ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(TBL_CATEGORY p)
        {
            p.CategoryStatus = true;
            db.TBL_CATEGORY.Add(p);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
        public ActionResult DeleteCategory(int id)
        {
            var values = db.TBL_CATEGORY.Find(id);
            db.TBL_CATEGORY.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            var values=db.TBL_CATEGORY.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateCategory(TBL_CATEGORY p)
        {
            var values = db.TBL_CATEGORY.Find(p.CategoryID);
             values.CategoryName = p.CategoryName;
            db.SaveChanges();
            return RedirectToAction("Index");
       
        }

    }
}