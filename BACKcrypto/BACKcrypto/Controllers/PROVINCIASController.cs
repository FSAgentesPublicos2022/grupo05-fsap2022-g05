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
    public class PROVINCIASController : ApiController
    {
        private BACKcryptoContext db = new BACKcryptoContext();

        // GET: api/PROVINCIAS
        public IQueryable<PROVINCIA> GetPROVINCIAS()
        {
            return db.PROVINCIAS;
        }

        // GET: api/PROVINCIAS/5
        [ResponseType(typeof(PROVINCIA))]
        public IHttpActionResult GetPROVINCIA(int id)
        {
            PROVINCIA pROVINCIA = db.PROVINCIAS.Find(id);
            if (pROVINCIA == null)
            {
                return NotFound();
            }

            return Ok(pROVINCIA);
        }

        // PUT: api/PROVINCIAS/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPROVINCIA(int id, PROVINCIA pROVINCIA)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pROVINCIA.Id)
            {
                return BadRequest();
            }

            db.Entry(pROVINCIA).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PROVINCIAExists(id))
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

        // POST: api/PROVINCIAS
        [ResponseType(typeof(PROVINCIA))]
        public IHttpActionResult PostPROVINCIA(PROVINCIA pROVINCIA)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.PROVINCIAS.Add(pROVINCIA);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = pROVINCIA.Id }, pROVINCIA);
        }

        // DELETE: api/PROVINCIAS/5
        [ResponseType(typeof(PROVINCIA))]
        public IHttpActionResult DeletePROVINCIA(int id)
        {
            PROVINCIA pROVINCIA = db.PROVINCIAS.Find(id);
            if (pROVINCIA == null)
            {
                return NotFound();
            }

            db.PROVINCIAS.Remove(pROVINCIA);
            db.SaveChanges();

            return Ok(pROVINCIA);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PROVINCIAExists(int id)
        {
            return db.PROVINCIAS.Count(e => e.Id == id) > 0;
        }
    }
}