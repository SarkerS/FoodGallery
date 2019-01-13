using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FoodGallery.Models;


namespace FoodGallery.Controllers
{
    public class ReviewController : Controller
    {
        // GET: Review
        public ActionResult Index()
        {
            var datar = from r in _localdata
                        orderby r.City
                        select r;

            return View(datar);
        }

        // GET: Review/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Review/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Review/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Review/Edit/5
        public ActionResult Edit(int id)
        {

            var edit = _localdata.Single(i => i.Id == id);

            return View(edit);
        }

        // POST: Review/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var edit = _localdata.Single(i => i.Id == id);
            if (TryUpdateModel(edit))
            {
                // TODO: Add update logic here
                // and database

                return RedirectToAction("Index");
            }
            return View(edit);
        }

        // GET: Review/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Review/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        static List<RestaurentReview> _localdata = new List<RestaurentReview>() {

        new RestaurentReview { Id = 1, Name = "Five Gays", City = "Winnipeg", Country = "Canada", Rating = 7.5},
        new RestaurentReview { Id = 2, Name = "Tim Horton", City = "Rgina", Country = "Bangladesh", Rating = 8.5}


        };


    }






}
