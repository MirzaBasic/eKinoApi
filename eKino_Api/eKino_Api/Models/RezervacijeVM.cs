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
    
    public partial class RezervacijeVM
    {
        public int RezervacijaID { get; set; }
        public int ProjekcijaID { get; set; }
        public byte[] Slika { get; set; }
        public Nullable<double> Cijena { get; set; }
        public int KorisnikID { get; set; }
        public string DatumRezervacije { get; set; }
        public string Red { get; set; }
        public Nullable<int> BrojSjedista { get; set; }
        public string NazivFilma { get; set; }
        public string TipProjekcije { get; set; }
        public string Dan { get; set; }
    }
}
