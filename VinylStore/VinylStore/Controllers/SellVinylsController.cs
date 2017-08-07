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
    public class SellVinylsController : Controller
    {
        private VinylContext db = new VinylContext();

        // GET: SellVinyls
        public ActionResult Index()
        {
            return View(db.SellVinyls.ToList());
        }

        // GET: SellVinyls/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SellVinyl sellVinyl = db.SellVinyls.Find(id);
            if (sellVinyl == null)
            {
                return HttpNotFound();
            }
            return View(sellVinyl);
        }

        // GET: SellVinyls/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SellVinyls/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Artist,Album,DateOfPublish,Price,StorageAmount")] SellVinyl sellVinyl)
        {
            if (ModelState.IsValid)
            {
                db.SellVinyls.Add(sellVinyl);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sellVinyl);
        }

        // GET: SellVinyls/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SellVinyl sellVinyl = db.SellVinyls.Find(id);
            if (sellVinyl == null)
            {
                return HttpNotFound();
            }
            return View(sellVinyl);
        }

        // POST: SellVinyls/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Artist,Album,DateOfPublish,Price,StorageAmount")] SellVinyl sellVinyl)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sellVinyl).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sellVinyl);
        }

        // GET: SellVinyls/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SellVinyl sellVinyl = db.SellVinyls.Find(id);
            if (sellVinyl == null)
            {
                return HttpNotFound();
            }
            return View(sellVinyl);
        }

        // POST: SellVinyls/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SellVinyl sellVinyl = db.SellVinyls.Find(id);
            db.SellVinyls.Remove(sellVinyl);
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
