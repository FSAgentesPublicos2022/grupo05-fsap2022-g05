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
    public class COMPRASController : ApiController
    {
        private BACKcrypto2Context db = new BACKcrypto2Context();

        // GET: api/COMPRAS
        public IQueryable<COMPRA> GetCOMPRAS()
        {
            return db.COMPRAS;
        }

        // GET: api/COMPRAS/5
        [ResponseType(typeof(COMPRA))]
        public IHttpActionResult GetCOMPRA(int id)
        {
            COMPRA cOMPRA = db.COMPRAS.Find(id);
            if (cOMPRA == null)
            {
                return NotFound();
            }

            return Ok(cOMPRA);
        }

        // PUT: api/COMPRAS/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCOMPRA(int id, COMPRA cOMPRA)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != cOMPRA.Id_Compra)
            {
                return BadRequest();
            }

            db.Entry(cOMPRA).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!COMPRAExists(id))
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

        // POST: api/COMPRAS
        [ResponseType(typeof(COMPRA))]
        public IHttpActionResult PostCOMPRA(COMPRA cOMPRA)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.COMPRAS.Add(cOMPRA);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = cOMPRA.Id_Compra }, cOMPRA);
        }

        // DELETE: api/COMPRAS/5
        [ResponseType(typeof(COMPRA))]
        public IHttpActionResult DeleteCOMPRA(int id)
        {
            COMPRA cOMPRA = db.COMPRAS.Find(id);
            if (cOMPRA == null)
            {
                return NotFound();
            }

            db.COMPRAS.Remove(cOMPRA);
            db.SaveChanges();

            return Ok(cOMPRA);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool COMPRAExists(int id)
        {
            return db.COMPRAS.Count(e => e.Id_Compra == id) > 0;
        }
    }
}