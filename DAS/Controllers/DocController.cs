using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DAS.Models;

namespace DAS.Controllers
{
    public class DocController : Controller
    {
        private MyDbContext1 db = new MyDbContext1();

        // Display a success message after successful request
        public ActionResult Success()
        {
            return View();
        }
        // GET: Doc
        public ActionResult Index()
        {
            return View(db.documents.ToList());
        }

        // GET: Doc/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DocumentModels1 documentModels1 = db.documents.Find(id);
            if (documentModels1 == null)
            {
                return HttpNotFound();
            }
            return View(documentModels1);
        }

        // GET: Doc/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Doc/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,cips,citizenship,passport,crimerecord,name,surName,identityNo,streetAddress,city,cantoon,zipCode")] DocumentModels1 documentModels1)
        {
            if (ModelState.IsValid)
            {
                db.documents.Add(documentModels1);
                db.SaveChanges();
                return RedirectToAction("Success");
            }

            return View(documentModels1);
        }

        // GET: Doc/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DocumentModels1 documentModels1 = db.documents.Find(id);
            if (documentModels1 == null)
            {
                return HttpNotFound();
            }
            return View(documentModels1);
        }

        // POST: Doc/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,cips,citizenship,passport,crimerecord,name,surName,identityNo,streetAddress,city,cantoon,zipCode")] DocumentModels1 documentModels1)
        {
            if (ModelState.IsValid)
            {
                db.Entry(documentModels1).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(documentModels1);
        }

        // GET: Doc/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DocumentModels1 documentModels1 = db.documents.Find(id);
            if (documentModels1 == null)
            {
                return HttpNotFound();
            }
            return View(documentModels1);
        }

        // POST: Doc/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DocumentModels1 documentModels1 = db.documents.Find(id);
            db.documents.Remove(documentModels1);
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
