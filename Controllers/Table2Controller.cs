using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Assignment1.Models;

namespace Assignment1.Controllers
{

    [Authorize]
    public class Table2Controller : Controller
    {
        private Model1 db = new Model1();

        // GET: Table2
        [OverrideAuthorization]
        public ActionResult Index()
        {
            return View(db.Table2.ToList());
        }

        // GET: Table2/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table2 table2 = db.Table2.Find(id);
            if (table2 == null)
            {
                return HttpNotFound();
            }
            return View(table2);
        }

        // GET: Table2/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Table2/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "contactno_,phone,customerID")] Table2 table2)
        {
            if (ModelState.IsValid)
            {
                db.Table2.Add(table2);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(table2);
        }

        // GET: Table2/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table2 table2 = db.Table2.Find(id);
            if (table2 == null)
            {
                return HttpNotFound();
            }
            return View(table2);
        }

        // POST: Table2/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "contactno_,phone,customerID")] Table2 table2)
        {
            if (ModelState.IsValid)
            {
                db.Entry(table2).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(table2);
        }

        // GET: Table2/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table2 table2 = db.Table2.Find(id);
            if (table2 == null)
            {
                return HttpNotFound();
            }
            return View(table2);
        }

        // POST: Table2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Table2 table2 = db.Table2.Find(id);
            db.Table2.Remove(table2);
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
