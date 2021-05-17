    using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class NovostsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Novosts
        public ActionResult Index()
        {
            return View(db.Novosts.ToList());
        }

        // GET: Novosts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Novost novost = db.Novosts.Find(id);
            if (novost == null)
            {
                return HttpNotFound();
            }
            return View(novost);
        }

        // GET: Novosts/Create
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Novosts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Slika,Naslov,Kratko,Storija")] Novost novost)
        {
            if (ModelState.IsValid)
            {
                db.Novosts.Add(novost);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(novost);
        }

        // GET: Novosts/Edit/5
        [Authorize]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Novost novost = db.Novosts.Find(id);
            if (novost == null)
            {
                return HttpNotFound();
            }
            return View(novost);
        }

        // POST: Novosts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Slika,Naslov,Kratko,Storija")] Novost novost)
        {
            if (ModelState.IsValid)
            {
                db.Entry(novost).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(novost);
        }

        // GET: Novosts/Delete/5
        [Authorize]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Novost novost = db.Novosts.Find(id);
            if (novost == null)
            {
                return HttpNotFound();
            }
            return View(novost);
        }

        // POST: Novosts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Novost novost = db.Novosts.Find(id);
            db.Novosts.Remove(novost);
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
