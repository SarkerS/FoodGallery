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

        public ActionResult Index(string Searchterm = null)
        {
            var view = _database.Restaurents.
                                  OrderByDescending(r => r.Reviews.Average(ratings => ratings.Rating))
                                  .Where(r => Searchterm == null || r.Name.StartsWith(Searchterm))
                                  .Take(45)
                                  .Select(r => new RestaurentListView
                                  {
                                      Id = r.Id,
                                      Name = r.Name,
                                      City = r.City,
                                      Country = r.Country,
                                      NumberofReviews = r.Reviews.Count()
                                  });

            if (Request.IsAjaxRequest())
            {
                return PartialView("_RestaurentCard");
            }

            return View(view);
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