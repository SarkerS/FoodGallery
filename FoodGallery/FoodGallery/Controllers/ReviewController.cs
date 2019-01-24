using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FoodGallery.Models;
using System.Data.Entity;
using System.Net;

namespace FoodGallery.Controllers
{
    public class ReviewController : Controller
    {
        EntityDB database = new EntityDB();
        // GET: Review
        public ActionResult Index([Bind(Prefix ="id")] int restaurentId)
        {
            var restaurent = database.Restaurents.Find(restaurentId);
            if (restaurent != null)
            {
                return View(restaurent);
            }

            return View();
        }




        //        // GET: Review/Details/5
        //        public ActionResult Details(int id)
        //        {
        //            return View();
        //        }

        // GET: Review/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Review/Create
        [HttpPost]
        public ActionResult Create(RestaurentReview review)
        {
            if (ModelState.IsValid)
            {
                database.Reviews.Add(review);
                database.SaveChanges();
                return RedirectToAction("Index", new { id = review.RestaurentID });
            }
            return View(review);
        }

        // GET: Review/Edit/5
        public ActionResult Edit(int id)
        {

            var edit = database.Reviews.Find(id);

            return View(edit);
        }

        // POST: Review/Edit/5
        [HttpPost]
        public ActionResult Edit(RestaurentReview review)
        {
            if (ModelState.IsValid)
            {
                database.Entry(review).State = EntityState.Modified;
                database.SaveChanges();
                return RedirectToAction("Index", new { id = review.RestaurentID });
            }
            return View(review);

        }


        // GET: Reviews/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var review = database.Reviews.Find(id);
            if (review == null)
            {
                return HttpNotFound();
            }
            return View(review);
        }

        // POST: Reviews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var review = database.Reviews.Find(id);
            database.Reviews.Remove(review);
            database.SaveChanges();
            return RedirectToAction("Index","Home");
        }



        protected override void Dispose(bool disposing)
        {
            database.Dispose();
            base.Dispose(disposing);
        }


    }






}
