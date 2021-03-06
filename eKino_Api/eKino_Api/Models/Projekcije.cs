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
    
    public partial class Projekcije
    {
        public Projekcije()
        {
            this.Rezervacijes = new HashSet<Rezervacije>();
        }
    
        public int ProjekcijaID { get; set; }
        public Nullable<int> FilmID { get; set; }
        public Nullable<int> TipProjekcijeID { get; set; }
        public Nullable<double> Cijena { get; set; }
        public Nullable<int> DanID { get; set; }
        public Nullable<System.TimeSpan> Vrijeme { get; set; }
        public Nullable<bool> Aktivna { get; set; }
    
        public virtual Dani Dani { get; set; }
        public virtual Filmovi Filmovi { get; set; }
        public virtual TipProjekcije TipProjekcije { get; set; }
        public virtual ICollection<Rezervacije> Rezervacijes { get; set; }
    }
}
