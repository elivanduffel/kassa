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
    public class GerechtsController : Controller
    {
        private KassaContext db = new KassaContext();

        // GET: Gerechts
        public ActionResult Index()
        {
            return View(db.Gerechts.ToList());
        }

        // GET: Gerechts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Gerecht gerecht = db.Gerechts.Find(id);
            if (gerecht == null)
            {
                return HttpNotFound();
            }
            return View(gerecht);
        }

        // GET: Gerechts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Gerechts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Omschrijving,Prijs")] Gerecht gerecht)
        {
            if (ModelState.IsValid)
            {
                db.Gerechts.Add(gerecht);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(gerecht);
        }

        // GET: Gerechts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Gerecht gerecht = db.Gerechts.Find(id);
            if (gerecht == null)
            {
                return HttpNotFound();
            }
            return View(gerecht);
        }

        //Get: read only  menu
        public ActionResult MenuList()
        {
            return View(db.Gerechts.ToList());
        }

        // POST: Gerechts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Omschrijving,Prijs")] Gerecht gerecht)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gerecht).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gerecht);
        }

        // GET: Gerechts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Gerecht gerecht = db.Gerechts.Find(id);
            if (gerecht == null)
            {
                return HttpNotFound();
            }
            return View(gerecht);
        }

        // POST: Gerechts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Gerecht gerecht = db.Gerechts.Find(id);
            db.Gerechts.Remove(gerecht);
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
