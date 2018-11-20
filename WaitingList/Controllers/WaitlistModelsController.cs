using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Waitlist.Models;
using Waitlist.Models.List;

namespace Waitlist.Controllers
{
    public class WaitlistModelsController : Controller
    {
        private DataBaseContext db = new DataBaseContext();

        // GET: WaitlistModels
        public ActionResult Index()
        {
            return View(db.Waitlists.ToList());
        }

        // GET: WaitlistModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WaitlistModels waitlistModels = db.Waitlists.Find(id);
            if (waitlistModels == null)
            {
                return HttpNotFound();
            }
            return View(waitlistModels);
        }

        // GET: WaitlistModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WaitlistModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,InsertedDate,Name,Description")] WaitlistModels waitlistModels)
        {
            if (ModelState.IsValid)
            {
                waitlistModels.CreationDate = DateTime.Now;
                waitlistModels.LastUpdate = waitlistModels.CreationDate;
                db.Waitlists.Add(waitlistModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(waitlistModels);
        }

        // GET: WaitlistModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WaitlistModels waitlistModels = db.Waitlists.Find(id);
            if (waitlistModels == null)
            {
                return HttpNotFound();
            }
            return View(waitlistModels);
        }

        // POST: WaitlistModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,InsertedDate,Name,Description,CreationDate,LastUpdate")] WaitlistModels waitlistModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(waitlistModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(waitlistModels);
        }

        // GET: WaitlistModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WaitlistModels waitlistModels = db.Waitlists.Find(id);
            if (waitlistModels == null)
            {
                return HttpNotFound();
            }
            return View(waitlistModels);
        }

        // POST: WaitlistModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            WaitlistModels waitlistModels = db.Waitlists.Find(id);
            db.Waitlists.Remove(waitlistModels);
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
