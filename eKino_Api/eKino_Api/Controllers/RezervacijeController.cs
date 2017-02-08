using eKino_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace eKino_Api.Controllers
{
    public class RezervacijeController : ApiController
    {
        eKinoEntities db=new eKinoEntities();
        [HttpGet]
        [ResponseType(typeof(RezervacijeVM))]
        [Route("api/Rezervacije/Korisnik/{id}")]
        public List<RezervacijeVM> GetRezervacijeByKorisnikID(int id)
        {
            return db.asp_GetRezervacijeByKorisnikID(id).ToList();
            
        }





        [HttpGet]
        [ResponseType(typeof(Sjedista))]
        [Route("api/Sjedista/Zauzeta/{id}")]
        public List<Sjedista> GetSjedistaByProjekcijaID(int id)
        {
            return db.usp_GetZauzetaSjedistaByProjekcijaID(id).ToList();

        }
        [HttpPost]
        [ResponseType(typeof(Rezervacije))] 
        [Route("api/Rezervacije")]
        public IHttpActionResult PostRezervacija(Rezervacije rezervacije)

        {


            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.asp_RezervacijeInsert(rezervacije.KorisnikID,rezervacije.ProjekcijaID,rezervacije.SjedisteID);
         

            return CreatedAtRoute("DefaultApi", new { id = rezervacije.RezervacijaID }, rezervacije);


          

          
          

        }


        [HttpDelete]
        [ResponseType(typeof(Rezervacije))]
        [Route("api/DeleteRezervacije/{id}")]
        public IHttpActionResult DelRezervacija(int id)

        {

            Rezervacije rezervacija = db.Rezervacijes.Find(id);
            if (rezervacija == null)
            {
                return NotFound();
            }

            db.Rezervacijes.Remove(rezervacija);
            db.SaveChanges();

            return Ok(rezervacija);
        }







    }














    }

