using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using iepDucan.Models;

namespace iepDucan.Controllers
{
    public class OrderTypesController : Controller
    {
        private velikigospodinEntities db = new velikigospodinEntities();

        // GET: OrderTypes
        public ActionResult Index()
        {
            return View(db.OrderTypes.ToList());
        }

        // GET: OrderTypes/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderType orderType = db.OrderTypes.Find(id);
            if (orderType == null)
            {
                return HttpNotFound();
            }
            return View(orderType);
        }

        // GET: OrderTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrderTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name")] OrderType orderType)
        {
            if (ModelState.IsValid)
            {
                db.OrderTypes.Add(orderType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(orderType);
        }

        // GET: OrderTypes/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderType orderType = db.OrderTypes.Find(id);
            if (orderType == null)
            {
                return HttpNotFound();
            }
            return View(orderType);
        }

        // POST: OrderTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] OrderType orderType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(orderType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(orderType);
        }

        // GET: OrderTypes/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderType orderType = db.OrderTypes.Find(id);
            if (orderType == null)
            {
                return HttpNotFound();
            }
            return View(orderType);
        }

        // POST: OrderTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            OrderType orderType = db.OrderTypes.Find(id);
            db.OrderTypes.Remove(orderType);
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
