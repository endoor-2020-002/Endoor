using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TOP2020.Models;

namespace TOP2020.Controllers
{
    public class LijstsController : Controller
    {
        private TOP2000Entities db = new TOP2000Entities();

        // GET: Lijsts
        public ActionResult Index()
        {
            var lijsts = db.Lijsts.Include(l => l.Song);
            return View(lijsts.ToList());
        }

        // GET: Lijsts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lijst lijst = db.Lijsts.Find(id);
            if (lijst == null)
            {
                return HttpNotFound();
            }
            return View(lijst);
        }

        // GET: Lijsts/Create
        public ActionResult Create()
        {
            ViewBag.songid = new SelectList(db.Songs, "songid", "titel");
            return View();
        }

        // POST: Lijsts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "songid,top2000jaar,positie")] Lijst lijst)
        {
            if (ModelState.IsValid)
            {
                db.Lijsts.Add(lijst);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.songid = new SelectList(db.Songs, "songid", "titel", lijst.songid);
            return View(lijst);
        }

        // GET: Lijsts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lijst lijst = db.Lijsts.Find(id);
            if (lijst == null)
            {
                return HttpNotFound();
            }
            ViewBag.songid = new SelectList(db.Songs, "songid", "titel", lijst.songid);
            return View(lijst);
        }

        // POST: Lijsts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "songid,top2000jaar,positie")] Lijst lijst)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lijst).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.songid = new SelectList(db.Songs, "songid", "titel", lijst.songid);
            return View(lijst);
        }

        // GET: Lijsts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lijst lijst = db.Lijsts.Find(id);
            if (lijst == null)
            {
                return HttpNotFound();
            }
            return View(lijst);
        }

        // POST: Lijsts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Lijst lijst = db.Lijsts.Find(id);
            db.Lijsts.Remove(lijst);
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
