using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WaitingList.Models;
using WaitingList.Models.List;

namespace WaitingList.Controllers
{
    public class WaitingListModelsController : Controller
    {
        private DataBaseContext db = new DataBaseContext();

        // GET: WaitingListModels
        public ActionResult Index()
        {
            return View(db.WaitingLists.ToList());
        }

        // GET: WaitingListModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WaitingListModels waitingListModels = db.WaitingLists.Find(id);
            if (waitingListModels == null)
            {
                return HttpNotFound();
            }
            return View(waitingListModels);
        }

        // GET: WaitingListModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WaitingListModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,InsertedDate,Name,Description")] WaitingListModels waitingListModels)
        {
            if (ModelState.IsValid)
            {
                waitingListModels.CreationDate = DateTime.Now;
                waitingListModels.LastUpdate = waitingListModels.CreationDate;
                db.WaitingLists.Add(waitingListModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(waitingListModels);
        }

        // GET: WaitingListModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WaitingListModels waitingListModels = db.WaitingLists.Find(id);
            if (waitingListModels == null)
            {
                return HttpNotFound();
            }
            return View(waitingListModels);
        }

        // POST: WaitingListModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,InsertedDate,Name,Description,CreationDate,LastUpdate")] WaitingListModels waitingListModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(waitingListModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(waitingListModels);
        }

        // GET: WaitingListModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WaitingListModels waitingListModels = db.WaitingLists.Find(id);
            if (waitingListModels == null)
            {
                return HttpNotFound();
            }
            return View(waitingListModels);
        }

        // POST: WaitingListModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            WaitingListModels waitingListModels = db.WaitingLists.Find(id);
            db.WaitingLists.Remove(waitingListModels);
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
