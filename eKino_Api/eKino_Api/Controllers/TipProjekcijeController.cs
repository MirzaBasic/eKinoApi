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
    public class TipProjekcijeController : ApiController
    {
        private eKinoEntities db = new eKinoEntities();

        // GET: api/TipProjekcije
        public IQueryable<TipProjekcije> GetTipProjekcijes()
        {
            return db.TipProjekcijes;
        }

        // GET: api/TipProjekcije/5
        [ResponseType(typeof(TipProjekcije))]
        public IHttpActionResult GetTipProjekcije(int id)
        {
            TipProjekcije tipProjekcije = db.TipProjekcijes.Find(id);
            if (tipProjekcije == null)
            {
                return NotFound();
            }

            return Ok(tipProjekcije);
        }

        // PUT: api/TipProjekcije/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTipProjekcije(int id, TipProjekcije tipProjekcije)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tipProjekcije.TipID)
            {
                return BadRequest();
            }

            db.Entry(tipProjekcije).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipProjekcijeExists(id))
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

        // POST: api/TipProjekcije
        [ResponseType(typeof(TipProjekcije))]
        public IHttpActionResult PostTipProjekcije(TipProjekcije tipProjekcije)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TipProjekcijes.Add(tipProjekcije);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tipProjekcije.TipID }, tipProjekcije);
        }

        // DELETE: api/TipProjekcije/5
        [ResponseType(typeof(TipProjekcije))]
        public IHttpActionResult DeleteTipProjekcije(int id)
        {
            TipProjekcije tipProjekcije = db.TipProjekcijes.Find(id);
            if (tipProjekcije == null)
            {
                return NotFound();
            }

            db.TipProjekcijes.Remove(tipProjekcije);
            db.SaveChanges();

            return Ok(tipProjekcije);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TipProjekcijeExists(int id)
        {
            return db.TipProjekcijes.Count(e => e.TipID == id) > 0;
        }
    }
}