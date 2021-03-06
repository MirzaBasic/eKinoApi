//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eKino_Api.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Korisnici
    {
        public Korisnici()
        {
            this.KorisniciUloges = new HashSet<KorisniciUloge>();
            this.Ocjenes = new HashSet<Ocjene>();
            this.Komentaris = new HashSet<Komentari>();
            this.Rezervacijes = new HashSet<Rezervacije>();
        }
    
        public int KorisnikID { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Spol { get; set; }
        public System.DateTime DatumRegistracije { get; set; }
        public string Email { get; set; }
        public bool Aktivan { get; set; }
    
        public virtual ICollection<KorisniciUloge> KorisniciUloges { get; set; }
        public virtual ICollection<Ocjene> Ocjenes { get; set; }
        public virtual ICollection<Komentari> Komentaris { get; set; }
        public virtual ICollection<Rezervacije> Rezervacijes { get; set; }
    }
}
