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
    public class VENTASController : ApiController
    {
        private BACKcryptoContext db = new BACKcryptoContext();

        // GET: api/VENTAS
        public IQueryable<VENTA> GetVENTAS()
        {
            return db.VENTAS;
        }

        // GET: api/VENTAS/5
        [ResponseType(typeof(VENTA))]
        public IHttpActionResult GetVENTA(int id)
        {
            VENTA vENTA = db.VENTAS.Find(id);
            if (vENTA == null)
            {
                return NotFound();
            }

            return Ok(vENTA);
        }

        // PUT: api/VENTAS/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutVENTA(int id, VENTA vENTA)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != vENTA.Id)
            {
                return BadRequest();
            }

            db.Entry(vENTA).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VENTAExists(id))
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

        // POST: api/VENTAS
        [ResponseType(typeof(VENTA))]
        public IHttpActionResult PostVENTA(VENTA vENTA)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.VENTAS.Add(vENTA);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = vENTA.Id }, vENTA);
        }

        // DELETE: api/VENTAS/5
        [ResponseType(typeof(VENTA))]
        public IHttpActionResult DeleteVENTA(int id)
        {
            VENTA vENTA = db.VENTAS.Find(id);
            if (vENTA == null)
            {
                return NotFound();
            }

            db.VENTAS.Remove(vENTA);
            db.SaveChanges();

            return Ok(vENTA);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VENTAExists(int id)
        {
            return db.VENTAS.Count(e => e.Id == id) > 0;
        }
    }
}