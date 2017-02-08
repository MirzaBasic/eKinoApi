using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using eKino_Api.Models;
using eKino_Api.Models.Views;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;
using System.Web.Http.Description;
using System.Web.Http.ModelBinding;

namespace eKino_Api.Controllers
{
    public class KorisniciController : ApiController
    {
        eKinoEntities db = new eKinoEntities();


        [HttpPost]
        [ResponseType(typeof(Korisnici))]
        [Route("api/Korisnici")]
        public IHttpActionResult PostKorisnik(Korisnici korisnici)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.asp_KorisnikInsert(korisnici.KorisnickoIme, korisnici.Lozinka, korisnici.Ime, korisnici.Prezime, korisnici.Spol, korisnici.Email);

            return CreatedAtRoute("DefaultApi", new { id = korisnici.KorisnikID }, korisnici);
        }


        [HttpGet]
        [ResponseType(typeof(Korisnici))]
        [Route("api/Autentifikacija/Provjera/{username}/{password}")]

        public AutentifikacijaProvjeraVM Provjera(string username, string password)
        {


            AutentifikacijaProvjeraVM korisnik = db.Korisnicis.Where(x => x.KorisnickoIme == username && x.Lozinka == password)
                .Select(x => new AutentifikacijaProvjeraVM
                {
                    KorisnikID = x.KorisnikID,
                    KorisnickoIme = x.KorisnickoIme,
                    Ime = x.Ime,
                    Prezime = x.Prezime,
                    Email = x.Email,
                    Spol = x.Spol


                }).SingleOrDefault();
            return korisnik;


        }


        [HttpPost]
        [ResponseType(typeof(Komentari))]
        [Route("api/Komentari")]
        public IHttpActionResult PostKomentar(Komentari k)
        {
            db.asp_KomentarInsert(k.Komentar, k.KorisnikID, k.FilmID, k.KomentarKomentaraID);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);


            }
            return CreatedAtRoute("DefaultApi", new { id = k.KomentarID }, k);

        }




        [HttpPut]
        [ResponseType(typeof(Korisnici))]
        [Route("api/UpdateKorisnici")]

        public IHttpActionResult PutKorisnik(Korisnici korisnici)
        {
            
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

           
            db.asp_KorisniciUpdate(korisnici.KorisnikID, korisnici.KorisnickoIme, korisnici.Ime, korisnici.Prezime, korisnici.Spol, korisnici.Email, korisnici.Lozinka);
          

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KorisnikExists(korisnici.KorisnikID))
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


        private bool KorisnikExists(int id)
        {
            return db.Korisnicis.Count(e => e.KorisnikID == id) > 0;
        }
    }

    }
