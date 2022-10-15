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
    public class INGRESOSController : ApiController
    {
        private BACKcryptoContext db = new BACKcryptoContext();

        // GET: api/INGRESOS
        public IQueryable<INGRESO> GetINGRESOS()
        {
            return db.INGRESOS;
        }

        // GET: api/INGRESOS/5
        [ResponseType(typeof(INGRESO))]
        public IHttpActionResult GetINGRESO(int id)
        {
            INGRESO iNGRESO = db.INGRESOS.Find(id);
            if (iNGRESO == null)
            {
                return NotFound();
            }

            return Ok(iNGRESO);
        }

        // PUT: api/INGRESOS/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutINGRESO(int id, INGRESO iNGRESO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != iNGRESO.Id)
            {
                return BadRequest();
            }

            db.Entry(iNGRESO).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!INGRESOExists(id))
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

        // POST: api/INGRESOS
        [ResponseType(typeof(INGRESO))]
        public IHttpActionResult PostINGRESO(INGRESO iNGRESO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.INGRESOS.Add(iNGRESO);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = iNGRESO.Id }, iNGRESO);
        }

        // DELETE: api/INGRESOS/5
        [ResponseType(typeof(INGRESO))]
        public IHttpActionResult DeleteINGRESO(int id)
        {
            INGRESO iNGRESO = db.INGRESOS.Find(id);
            if (iNGRESO == null)
            {
                return NotFound();
            }

            db.INGRESOS.Remove(iNGRESO);
            db.SaveChanges();

            return Ok(iNGRESO);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool INGRESOExists(int id)
        {
            return db.INGRESOS.Count(e => e.Id == id) > 0;
        }
    }
}