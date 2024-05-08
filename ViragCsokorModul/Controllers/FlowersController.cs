using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Bce.Dnn.ViragCsokorModul.Models;

namespace Bce.Dnn.ViragCsokorModul.Controllers
{
    public class FlowersController : Controller
    {
        private FlowersDBEntities1 db = new FlowersDBEntities1();

        // GET: Flowers
        public ActionResult Index()
        {
            return View(db.Table_Flowers.ToList());
        }

        // GET: Flowers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table_Flowers table_Flowers = db.Table_Flowers.Find(id);
            if (table_Flowers == null)
            {
                return HttpNotFound();
            }
            return View(table_Flowers);
        }

        // GET: Flowers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Flowers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FlowerID,FlowerName,Price")] Table_Flowers table_Flowers)
        {
            if (ModelState.IsValid)
            {
                db.Table_Flowers.Add(table_Flowers);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(table_Flowers);
        }

        // GET: Flowers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table_Flowers table_Flowers = db.Table_Flowers.Find(id);
            if (table_Flowers == null)
            {
                return HttpNotFound();
            }
            return View(table_Flowers);
        }

        // POST: Flowers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FlowerID,FlowerName,Price")] Table_Flowers table_Flowers)
        {
            if (ModelState.IsValid)
            {
                db.Entry(table_Flowers).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(table_Flowers);
        }

        // GET: Flowers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table_Flowers table_Flowers = db.Table_Flowers.Find(id);
            if (table_Flowers == null)
            {
                return HttpNotFound();
            }
            return View(table_Flowers);
        }

        // POST: Flowers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Table_Flowers table_Flowers = db.Table_Flowers.Find(id);
            db.Table_Flowers.Remove(table_Flowers);
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
