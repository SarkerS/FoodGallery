using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using FoodGallery.Models;

namespace FoodGallery.Controllers
{
    public class HomeController : Controller

    {
        EntityDB _database = new EntityDB();

        public ActionResult Index()
        {
            var dbtolist = _database.Restaurents.ToList();

            return View(dbtolist);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (_database != null)
            {
                _database.Dispose();
            }
            base.Dispose(disposing);
        }


    }
}