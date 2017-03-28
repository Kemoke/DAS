using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using DAS.Models;

namespace DAS.Controllers
{
    public class DocumentsController : ApiController
    {
        private MyDbContext1 db = new MyDbContext1();

        // GET: api/Documents
        public IQueryable<DocumentModels1> Getdocuments()
        {
            return db.documents;
        }

        // GET: api/Documents/5
        [ResponseType(typeof(DocumentModels1))]
        public IHttpActionResult GetDocumentModels1(int id)
        {
            DocumentModels1 documentModels1 = db.documents.Find(id);
            if (documentModels1 == null)
            {
                return NotFound();
            }

            return Ok(documentModels1);
        }

        // PUT: api/Documents/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutDocumentModels1(int id, DocumentModels1 documentModels1)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != documentModels1.id)
            {
                return BadRequest();
            }

            db.Entry(documentModels1).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DocumentModels1Exists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Documents
        [ResponseType(typeof(DocumentModels1))]
        public IHttpActionResult PostDocumentModels1(DocumentModels1 documentModels1)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.documents.Add(documentModels1);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = documentModels1.id }, documentModels1);
        }

        // DELETE: api/Documents/5
        [ResponseType(typeof(DocumentModels1))]
        public IHttpActionResult DeleteDocumentModels1(int id)
        {
            DocumentModels1 documentModels1 = db.documents.Find(id);
            if (documentModels1 == null)
            {
                return NotFound();
            }

            db.documents.Remove(documentModels1);
            db.SaveChanges();

            return Ok(documentModels1);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DocumentModels1Exists(int id)
        {
            return db.documents.Count(e => e.id == id) > 0;
        }
    }
}