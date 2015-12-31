using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EetdagenKassa.DAL;
using EetdagenKassa.Models;

namespace EetdagenKassa.Controllers
{
    public class BestellingsController : Controller
    {
        private KassaContext db = new KassaContext();
        private KassaInitializer ki = new KassaInitializer();

        [HttpGet]
        public ActionResult AddBestelling()
        {
            //instantiate the product repository
            var bestelling = new Bestelling();

            //for get product categories from database
            var gerechten = ki.GetFullList();

            //for initialize viewmodel
            var bestellingViewModel = new ViewModels.BestellingViewModel();

            //assign values for viewmodel
            bestellingViewModel.Gerechts = gerechten;

            //send viewmodel into UI (View)
            return View("AddProduct", bestellingViewModel);
        }

        // GET: Bestellings
        public ActionResult Index()
        {
            return View(db.Bestellings.ToList());
        }

        // GET: Bestellings/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bestelling bestelling = db.Bestellings.Find(id);
            if (bestelling == null)
            {
                return HttpNotFound();
            }
            return View(bestelling);
        }

        // GET: Bestellings/Create
        public ActionResult Create()
        {
            return View();
        }

        

        // POST: Bestellings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BestellingID,Shift,Kassa,TotaalPrijs,Bonnen,Contant,Bancontact")] Bestelling bestelling)
        {
            if (ModelState.IsValid)
            {
                db.Bestellings.Add(bestelling);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bestelling);
        }

        // GET: Bestellings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bestelling bestelling = db.Bestellings.Find(id);
            if (bestelling == null)
            {
                return HttpNotFound();
            }
            return View(bestelling);
        }

        // POST: Bestellings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BestellingID,Shift,Kassa,TotaalPrijs,Bonnen,Contant,Bancontact")] Bestelling bestelling)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bestelling).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bestelling);
        }

        // GET: Bestellings/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bestelling bestelling = db.Bestellings.Find(id);
            if (bestelling == null)
            {
                return HttpNotFound();
            }
            return View(bestelling);
        }

        // POST: Bestellings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Bestelling bestelling = db.Bestellings.Find(id);
            db.Bestellings.Remove(bestelling);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
