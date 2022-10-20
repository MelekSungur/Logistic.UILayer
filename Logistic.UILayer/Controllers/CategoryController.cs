using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Logistic.UILayer.Models;

namespace Logistic.UILayer.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        DBLogisticEntities db=new DBLogisticEntities();
        public ActionResult Index()
        {
            var values =db.TBL_CATEGORY.ToList();
            return View(values);
        }
        public ActionResult AddCategory(TBL_CATEGORY p)
        {
            db.TBL_CATEGORY.Add(p);
            db.SaveChanges();

            return View();
           
        }
    }
}