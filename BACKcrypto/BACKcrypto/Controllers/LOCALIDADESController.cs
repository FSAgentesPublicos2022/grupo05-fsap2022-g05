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
    public class LOCALIDADESController : ApiController
    {
        private BACKcryptoContext db = new BACKcryptoContext();

        // GET: api/LOCALIDADES
        public IQueryable<LOCALIDAD> GetLOCALIDADES()
        {
            return db.LOCALIDADES;
        }

        // GET: api/LOCALIDADES/5
        [ResponseType(typeof(LOCALIDAD))]
        public IHttpActionResult GetLOCALIDAD(int id)
        {
            LOCALIDAD lOCALIDAD = db.LOCALIDADES.Find(id);
            if (lOCALIDAD == null)
            {
                return NotFound();
            }

            return Ok(lOCALIDAD);
        }

        // PUT: api/LOCALIDADES/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutLOCALIDAD(int id, LOCALIDAD lOCALIDAD)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != lOCALIDAD.Id)
            {
                return BadRequest();
            }

            db.Entry(lOCALIDAD).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LOCALIDADExists(id))
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

        // POST: api/LOCALIDADES
        [ResponseType(typeof(LOCALIDAD))]
        public IHttpActionResult PostLOCALIDAD(LOCALIDAD lOCALIDAD)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.LOCALIDADES.Add(lOCALIDAD);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = lOCALIDAD.Id }, lOCALIDAD);
        }

        // DELETE: api/LOCALIDADES/5
        [ResponseType(typeof(LOCALIDAD))]
        public IHttpActionResult DeleteLOCALIDAD(int id)
        {
            LOCALIDAD lOCALIDAD = db.LOCALIDADES.Find(id);
            if (lOCALIDAD == null)
            {
                return NotFound();
            }

            db.LOCALIDADES.Remove(lOCALIDAD);
            db.SaveChanges();

            return Ok(lOCALIDAD);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LOCALIDADExists(int id)
        {
            return db.LOCALIDADES.Count(e => e.Id == id) > 0;
        }
    }
}