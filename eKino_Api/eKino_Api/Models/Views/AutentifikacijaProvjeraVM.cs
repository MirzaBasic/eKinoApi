using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eKino_Api.Models.Views
{
    public class AutentifikacijaProvjeraVM
    {

        public int KorisnikID { get; set; }
        public string KorisnickoIme { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public string Email { get; set; }
        public string Spol { get; set; }
        public string Lozinka { get; set; }
    }
}