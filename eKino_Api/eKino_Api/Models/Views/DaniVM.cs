using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eKino_Api.Models.Views
{
    public class DaniVM
    {

        public int DanID { get; set; }
        public string Naziv { get; set; }
        public List<ProjekcijeVM> Projekcije {get; set;}
    }
}