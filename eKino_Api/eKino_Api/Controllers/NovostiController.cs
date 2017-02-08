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
using eKino_Api.Models;

namespace eKino_Api.Controllers
{
    public class NovostiController : ApiController
    {
        private eKinoEntities db = new eKinoEntities();

        // GET: api/Novosti
        public IQueryable<Novosti> GetNovostis()
        {
            return db.Novostis;
        }

        // GET: api/Novosti/5
        [ResponseType(typeof(Novosti))]
        public IHttpActionResult GetNovosti(int id)
        {
            Novosti novosti = db.Novostis.Find(id);
            if (novosti == null)
            {
                return NotFound();
            }

            return Ok(novosti);
        }

        // PUT: api/Novosti/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutNovosti(int id, Novosti novosti)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != novosti.NovostID)
            {
                return BadRequest();
            }

            db.Entry(novosti).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NovostiExists(id))
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

        // POST: api/Novosti
        [ResponseType(typeof(Novosti))]
        public IHttpActionResult PostNovosti(Novosti novosti)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Novostis.Add(novosti);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = novosti.NovostID }, novosti);
        }

        // DELETE: api/Novosti/5
        [ResponseType(typeof(Novosti))]
        public IHttpActionResult DeleteNovosti(int id)
        {
            Novosti novosti = db.Novostis.Find(id);
            if (novosti == null)
            {
                return NotFound();
            }

            db.Novostis.Remove(novosti);
            db.SaveChanges();

            return Ok(novosti);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool NovostiExists(int id)
        {
            return db.Novostis.Count(e => e.NovostID == id) > 0;
        }
    }
}