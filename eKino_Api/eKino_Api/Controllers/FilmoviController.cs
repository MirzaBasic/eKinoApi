using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using eKino_Api.Models;
using eKino_Api.Models.Views;

namespace eKino_Api.Controllers
{
    
    
    public class FilmoviController : ApiController
    {
        eKinoEntities db = new eKinoEntities();

        [HttpGet]
        [ResponseType(typeof(FilmoviVM))]
        [Route("api/Filmovi/{id}")]

        public FilmoviVM GetMovieDetails(int id)
        {
            FilmoviVM film = db.Filmovis.Where(x => x.FilmID == id).Select(x => new FilmoviVM
            {
                FilmID = x.FilmID,
                Naziv = x.Naziv,
                IMDBOcjena = x.IMDBOcjena,
                Ocjena = x.Ocjena,
                Opis = x.Opis,
                Slika = x.Slika,
                Glumci=x.Glumci
                      

                   }).SingleOrDefault();

            film.Komentari = db.asp_KomentariGetByFilmID(id).ToList();
           
            film.Ocjene = db.asp_OcjeneGetByFilmID(id).ToList();
            film.Zanrovi = db.asp_ZanroviGetByFilmID(id).ToList();
            film.Dani = db.Danis.Select(x => new DaniVM
            {
                DanID=x.DanID,
                Naziv=x.Naziv,

            }).ToList();

            for (int i = 0; i < film.Dani.Count(); i++)
            {
                film.Dani[i].Projekcije = db.asp_SelectAktivneProjekcijeByFilmID(id, film.Dani[i].DanID).ToList();
            }

         
            return film;
        }

        [HttpGet]
        [ResponseType(typeof(Filmovi))]
        [Route("api/Filmovi/Naziv/{naziv?}")]

        public List<Filmovi> GetMoviesByNaziv(string naziv=null)
        {
            return db.asp_SelectAktivneProjekcijeByNaziv(naziv).ToList();
          
        }


        [HttpGet]
        [ResponseType(typeof(Filmovi))]
        [Route("api/Filmovi/Top10")]

        public List<Filmovi> GetMoviesTop10()
        {
            return db.asp_SelectTopAktivneProjekcije().ToList();

        }



        











    }
}
