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
    public class CUENTASController : ApiController
    {
        private BACKcrypto2Context db = new BACKcrypto2Context();

        // GET: api/CUENTAS
        public IQueryable<CUENTA> GetCUENTAS()
        {
            return db.CUENTAS;
        }

        // GET: api/CUENTAS/5
        [ResponseType(typeof(CUENTA))]
        public IHttpActionResult GetCUENTA(int id)
        {
            CUENTA cUENTA = db.CUENTAS.Find(id);
            if (cUENTA == null)
            {
                return NotFound();
            }

            return Ok(cUENTA);
        }

        // PUT: api/CUENTAS/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCUENTA(int id, CUENTA cUENTA)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != cUENTA.Id_Cuenta)
            {
                return BadRequest();
            }

            db.Entry(cUENTA).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CUENTAExists(id))
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

        // POST: api/CUENTAS
        [ResponseType(typeof(CUENTA))]
        public IHttpActionResult PostCUENTA(CUENTA cUENTA)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.CUENTAS.Add(cUENTA);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = cUENTA.Id_Cuenta }, cUENTA);
        }

        // DELETE: api/CUENTAS/5
        [ResponseType(typeof(CUENTA))]
        public IHttpActionResult DeleteCUENTA(int id)
        {
            CUENTA cUENTA = db.CUENTAS.Find(id);
            if (cUENTA == null)
            {
                return NotFound();
            }

            db.CUENTAS.Remove(cUENTA);
            db.SaveChanges();

            return Ok(cUENTA);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CUENTAExists(int id)
        {
            return db.CUENTAS.Count(e => e.Id_Cuenta == id) > 0;
        }
    }
}