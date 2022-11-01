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
using BACKcrypto2.Data;
using BACKcrypto2.Models;

namespace BACKcrypto2.Controllers
{
    public class MONEDASController : ApiController
    {
        private BACKcrypto2Context db = new BACKcrypto2Context();

        // GET: api/MONEDAS
        public IQueryable<MONEDA> GetMONEDAS()
        {
            return db.MONEDAS;
        }

        // GET: api/MONEDAS/5
        [ResponseType(typeof(MONEDA))]
        public IHttpActionResult GetMONEDA(int id)
        {
            MONEDA mONEDA = db.MONEDAS.Find(id);
            if (mONEDA == null)
            {
                return NotFound();
            }

            return Ok(mONEDA);
        }

        // PUT: api/MONEDAS/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutMONEDA(int id, MONEDA mONEDA)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mONEDA.Id_Moneda)
            {
                return BadRequest();
            }

            db.Entry(mONEDA).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MONEDAExists(id))
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

        // POST: api/MONEDAS
        [ResponseType(typeof(MONEDA))]
        public IHttpActionResult PostMONEDA(MONEDA mONEDA)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.MONEDAS.Add(mONEDA);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = mONEDA.Id_Moneda }, mONEDA);
        }

        // DELETE: api/MONEDAS/5
        [ResponseType(typeof(MONEDA))]
        public IHttpActionResult DeleteMONEDA(int id)
        {
            MONEDA mONEDA = db.MONEDAS.Find(id);
            if (mONEDA == null)
            {
                return NotFound();
            }

            db.MONEDAS.Remove(mONEDA);
            db.SaveChanges();

            return Ok(mONEDA);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MONEDAExists(int id)
        {
            return db.MONEDAS.Count(e => e.Id_Moneda == id) > 0;
        }
    }
}