using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VinylStore.Data_Access_Layer;
using VinylStore.Models;

namespace VinylStore.Controllers
{
    public class LendVinylsController : Controller
    {
        private VinylContext db = new VinylContext();

        // GET: LendVinyls
        public ActionResult Index()
        {
            return View(db.LendVinyls.ToList());
        }

        // GET: LendVinyls/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LendVinyl lendVinyl = db.LendVinyls.Find(id);
            if (lendVinyl == null)
            {
                return HttpNotFound();
            }
            return View(lendVinyl);
        }

        // GET: LendVinyls/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LendVinyls/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Artist,Album,DateOfPublish,CustomerId,CustomerFullName")] LendVinyl lendVinyl)
        {
            if (ModelState.IsValid)
            {
                db.LendVinyls.Add(lendVinyl);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lendVinyl);
        }

        // GET: LendVinyls/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LendVinyl lendVinyl = db.LendVinyls.Find(id);
            if (lendVinyl == null)
            {
                return HttpNotFound();
            }
            return View(lendVinyl);
        }

        // POST: LendVinyls/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Artist,Album,DateOfPublish,CustomerId,CustomerFullName")] LendVinyl lendVinyl)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lendVinyl).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lendVinyl);
        }

        // GET: LendVinyls/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LendVinyl lendVinyl = db.LendVinyls.Find(id);
            if (lendVinyl == null)
            {
                return HttpNotFound();
            }
            return View(lendVinyl);
        }

        // POST: LendVinyls/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LendVinyl lendVinyl = db.LendVinyls.Find(id);
            db.LendVinyls.Remove(lendVinyl);
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
