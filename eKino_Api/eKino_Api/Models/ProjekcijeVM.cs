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
    
    public partial class ProjekcijeVM
    {
        public int ProjekcijaID { get; set; }
        public Nullable<int> FilmID { get; set; }
        public Nullable<double> Cijena { get; set; }
        public Nullable<System.TimeSpan> Vrijeme { get; set; }
        public string NazivFilma { get; set; }
        public string TipProjekcije { get; set; }
        public string Dan { get; set; }
    }
}
