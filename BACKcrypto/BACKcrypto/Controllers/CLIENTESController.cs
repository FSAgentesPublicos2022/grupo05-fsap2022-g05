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
    public class CLIENTESController : ApiController
    {
        private BACKcryptoContext db = new BACKcryptoContext();

        // GET: api/CLIENTES
        public IQueryable<CLIENTE> GetCLIENTES()
        {
            return db.CLIENTES;
        }

        // GET: api/CLIENTES/5
        [ResponseType(typeof(CLIENTE))]
        public IHttpActionResult GetCLIENTE(int id)
        {
            CLIENTE cLIENTE = db.CLIENTES.Find(id);
            if (cLIENTE == null)
            {
                return NotFound();
            }

            return Ok(cLIENTE);
        }

        // PUT: api/CLIENTES/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCLIENTE(int id, CLIENTE cLIENTE)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != cLIENTE.Id)
            {
                return BadRequest();
            }

            db.Entry(cLIENTE).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CLIENTEExists(id))
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

        // POST: api/CLIENTES
        [ResponseType(typeof(CLIENTE))]
        public IHttpActionResult PostCLIENTE(CLIENTE cLIENTE)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.CLIENTES.Add(cLIENTE);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = cLIENTE.Id }, cLIENTE);
        }

        // DELETE: api/CLIENTES/5
        [ResponseType(typeof(CLIENTE))]
        public IHttpActionResult DeleteCLIENTE(int id)
        {
            CLIENTE cLIENTE = db.CLIENTES.Find(id);
            if (cLIENTE == null)
            {
                return NotFound();
            }

            db.CLIENTES.Remove(cLIENTE);
            db.SaveChanges();

            return Ok(cLIENTE);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CLIENTEExists(int id)
        {
            return db.CLIENTES.Count(e => e.Id == id) > 0;
        }
    }
}