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
using BACKcrypto.Data;
using BACKcrypto.Models;

namespace BACKcrypto.Controllers
{
    public class EMAILSController : ApiController
    {
        private BACKcryptoContext db = new BACKcryptoContext();

        // GET: api/EMAILS
        public IQueryable<EMAIL> GetEMAILS()
        {
            return db.EMAILS;
        }

        // GET: api/EMAILS/5
        [ResponseType(typeof(EMAIL))]
        public IHttpActionResult GetEMAIL(int id)
        {
            EMAIL eMAIL = db.EMAILS.Find(id);
            if (eMAIL == null)
            {
                return NotFound();
            }

            return Ok(eMAIL);
        }

        // PUT: api/EMAILS/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEMAIL(int id, EMAIL eMAIL)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != eMAIL.Id)
            {
                return BadRequest();
            }

            db.Entry(eMAIL).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EMAILExists(id))
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

        // POST: api/EMAILS
        [ResponseType(typeof(EMAIL))]
        public IHttpActionResult PostEMAIL(EMAIL eMAIL)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.EMAILS.Add(eMAIL);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = eMAIL.Id }, eMAIL);
        }

        // DELETE: api/EMAILS/5
        [ResponseType(typeof(EMAIL))]
        public IHttpActionResult DeleteEMAIL(int id)
        {
            EMAIL eMAIL = db.EMAILS.Find(id);
            if (eMAIL == null)
            {
                return NotFound();
            }

            db.EMAILS.Remove(eMAIL);
            db.SaveChanges();

            return Ok(eMAIL);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EMAILExists(int id)
        {
            return db.EMAILS.Count(e => e.Id == id) > 0;
        }
    }
}