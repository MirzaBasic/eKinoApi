using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eKino_Api.Models.Views
{
    public class FilmoviVM
    {

        public int FilmID { get; set; }
        public string Naziv { get; set; }
        public string Glumci { get; set; }
        public string Opis { get; set; }
        public bool Akrivan { get; set; }
        public System.DateTime DatumKreiranja { get; set; }
        public System.DateTime DatumModifikacije { get; set; }
        public double IMDBOcjena { get; set; }
        public double Ocjena { get; set; }
        public byte[] Slika { get; set; }

        public  List<KomentariVM> Komentari { get; set; }
        public  List<OcjeneVM> Ocjene { get; set; }
        public  List<Zanrovi> Zanrovi { get; set; }
        public List<DaniVM> Dani { get; set; }

        
    }

  
 
    
}