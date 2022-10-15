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
    public class TRANSFERENCIASController : ApiController
    {
        private BACKcryptoContext db = new BACKcryptoContext();

        // GET: api/TRANSFERENCIAS
        public IQueryable<TRANSFERENCIA> GetTRANSFERENCIAS()
        {
            return db.TRANSFERENCIAS;
        }

        // GET: api/TRANSFERENCIAS/5
        [ResponseType(typeof(TRANSFERENCIA))]
        public IHttpActionResult GetTRANSFERENCIA(int id)
        {
            TRANSFERENCIA tRANSFERENCIA = db.TRANSFERENCIAS.Find(id);
            if (tRANSFERENCIA == null)
            {
                return NotFound();
            }

            return Ok(tRANSFERENCIA);
        }

        // PUT: api/TRANSFERENCIAS/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTRANSFERENCIA(int id, TRANSFERENCIA tRANSFERENCIA)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tRANSFERENCIA.Id)
            {
                return BadRequest();
            }

            db.Entry(tRANSFERENCIA).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TRANSFERENCIAExists(id))
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

        // POST: api/TRANSFERENCIAS
        [ResponseType(typeof(TRANSFERENCIA))]
        public IHttpActionResult PostTRANSFERENCIA(TRANSFERENCIA tRANSFERENCIA)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TRANSFERENCIAS.Add(tRANSFERENCIA);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tRANSFERENCIA.Id }, tRANSFERENCIA);
        }

        // DELETE: api/TRANSFERENCIAS/5
        [ResponseType(typeof(TRANSFERENCIA))]
        public IHttpActionResult DeleteTRANSFERENCIA(int id)
        {
            TRANSFERENCIA tRANSFERENCIA = db.TRANSFERENCIAS.Find(id);
            if (tRANSFERENCIA == null)
            {
                return NotFound();
            }

            db.TRANSFERENCIAS.Remove(tRANSFERENCIA);
            db.SaveChanges();

            return Ok(tRANSFERENCIA);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TRANSFERENCIAExists(int id)
        {
            return db.TRANSFERENCIAS.Count(e => e.Id == id) > 0;
        }
    }
}