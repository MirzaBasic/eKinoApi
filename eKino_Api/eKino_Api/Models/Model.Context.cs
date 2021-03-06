﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class eKinoEntities : DbContext
    {
        public eKinoEntities()
            : base("name=eKinoEntities")
        {
            Configuration.ProxyCreationEnabled = false;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Filmovi> Filmovis { get; set; }
        public virtual DbSet<Korisnici> Korisnicis { get; set; }
        public virtual DbSet<KorisniciUloge> KorisniciUloges { get; set; }
        public virtual DbSet<Ocjene> Ocjenes { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Uloge> Uloges { get; set; }
        public virtual DbSet<Zanrovi> Zanrovis { get; set; }
        public virtual DbSet<Dani> Danis { get; set; }
        public virtual DbSet<Projekcije> Projekcijes { get; set; }
        public virtual DbSet<TipProjekcije> TipProjekcijes { get; set; }
        public virtual DbSet<Komentari> Komentaris { get; set; }
        public virtual DbSet<Rezervacije> Rezervacijes { get; set; }
        public virtual DbSet<Sjedista> Sjedistas { get; set; }
        public virtual DbSet<Novosti> Novostis { get; set; }
    
        public virtual ObjectResult<KomentariVM> asp_KomentariGetByFilmID(Nullable<int> filmID)
        {
            var filmIDParameter = filmID.HasValue ?
                new ObjectParameter("FilmID", filmID) :
                new ObjectParameter("FilmID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<KomentariVM>("asp_KomentariGetByFilmID", filmIDParameter);
        }
    
        public virtual ObjectResult<OcjeneVM> asp_OcjeneGetByFilmID(Nullable<int> filmID)
        {
            var filmIDParameter = filmID.HasValue ?
                new ObjectParameter("FilmID", filmID) :
                new ObjectParameter("FilmID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<OcjeneVM>("asp_OcjeneGetByFilmID", filmIDParameter);
        }
    
        public virtual ObjectResult<Zanrovi> asp_ZanroviGetByFilmID(Nullable<int> filmID)
        {
            var filmIDParameter = filmID.HasValue ?
                new ObjectParameter("FilmID", filmID) :
                new ObjectParameter("FilmID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Zanrovi>("asp_ZanroviGetByFilmID", filmIDParameter);
        }
    
        public virtual ObjectResult<Zanrovi> asp_ZanroviGetByFilmID(Nullable<int> filmID, MergeOption mergeOption)
        {
            var filmIDParameter = filmID.HasValue ?
                new ObjectParameter("FilmID", filmID) :
                new ObjectParameter("FilmID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Zanrovi>("asp_ZanroviGetByFilmID", mergeOption, filmIDParameter);
        }
    
        public virtual ObjectResult<Filmovi> asp_SelectAktivneProjekcije()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Filmovi>("asp_SelectAktivneProjekcije");
        }
    
        public virtual ObjectResult<Filmovi> asp_SelectAktivneProjekcije(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Filmovi>("asp_SelectAktivneProjekcije", mergeOption);
        }
    
        public virtual ObjectResult<ProjekcijeVM> asp_SelectAktivneProjekcijeByFilmID(Nullable<int> filmID, Nullable<int> danID)
        {
            var filmIDParameter = filmID.HasValue ?
                new ObjectParameter("FilmID", filmID) :
                new ObjectParameter("FilmID", typeof(int));
    
            var danIDParameter = danID.HasValue ?
                new ObjectParameter("DanID", danID) :
                new ObjectParameter("DanID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ProjekcijeVM>("asp_SelectAktivneProjekcijeByFilmID", filmIDParameter, danIDParameter);
        }
    
        public virtual ObjectResult<KomentariVM> aps_GetKomentariKomentara(Nullable<int> komentarID)
        {
            var komentarIDParameter = komentarID.HasValue ?
                new ObjectParameter("KomentarID", komentarID) :
                new ObjectParameter("KomentarID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<KomentariVM>("aps_GetKomentariKomentara", komentarIDParameter);
        }
    
        public virtual int asp_RezervacijeInsert(Nullable<int> korisnikID, Nullable<int> projekcijaID, Nullable<int> sjedisteID)
        {
            var korisnikIDParameter = korisnikID.HasValue ?
                new ObjectParameter("KorisnikID", korisnikID) :
                new ObjectParameter("KorisnikID", typeof(int));
    
            var projekcijaIDParameter = projekcijaID.HasValue ?
                new ObjectParameter("ProjekcijaID", projekcijaID) :
                new ObjectParameter("ProjekcijaID", typeof(int));
    
            var sjedisteIDParameter = sjedisteID.HasValue ?
                new ObjectParameter("SjedisteID", sjedisteID) :
                new ObjectParameter("SjedisteID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("asp_RezervacijeInsert", korisnikIDParameter, projekcijaIDParameter, sjedisteIDParameter);
        }
    
        public virtual ObjectResult<RezervacijeVM> asp_GetRezervacijeByKorisnikID(Nullable<int> korisnikID)
        {
            var korisnikIDParameter = korisnikID.HasValue ?
                new ObjectParameter("KorisnikID", korisnikID) :
                new ObjectParameter("KorisnikID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RezervacijeVM>("asp_GetRezervacijeByKorisnikID", korisnikIDParameter);
        }
    
        public virtual ObjectResult<Sjedista> usp_GetZauzetaSjedistaByProjekcijaID(Nullable<int> projekcijaID)
        {
            var projekcijaIDParameter = projekcijaID.HasValue ?
                new ObjectParameter("ProjekcijaID", projekcijaID) :
                new ObjectParameter("ProjekcijaID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Sjedista>("usp_GetZauzetaSjedistaByProjekcijaID", projekcijaIDParameter);
        }
    
        public virtual ObjectResult<Sjedista> usp_GetZauzetaSjedistaByProjekcijaID(Nullable<int> projekcijaID, MergeOption mergeOption)
        {
            var projekcijaIDParameter = projekcijaID.HasValue ?
                new ObjectParameter("ProjekcijaID", projekcijaID) :
                new ObjectParameter("ProjekcijaID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Sjedista>("usp_GetZauzetaSjedistaByProjekcijaID", mergeOption, projekcijaIDParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int asp_KorisnikInsert(string korisnickoIme, string lozinka, string ime, string prezime, string spol, string email)
        {
            var korisnickoImeParameter = korisnickoIme != null ?
                new ObjectParameter("KorisnickoIme", korisnickoIme) :
                new ObjectParameter("KorisnickoIme", typeof(string));
    
            var lozinkaParameter = lozinka != null ?
                new ObjectParameter("Lozinka", lozinka) :
                new ObjectParameter("Lozinka", typeof(string));
    
            var imeParameter = ime != null ?
                new ObjectParameter("Ime", ime) :
                new ObjectParameter("Ime", typeof(string));
    
            var prezimeParameter = prezime != null ?
                new ObjectParameter("Prezime", prezime) :
                new ObjectParameter("Prezime", typeof(string));
    
            var spolParameter = spol != null ?
                new ObjectParameter("Spol", spol) :
                new ObjectParameter("Spol", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("asp_KorisnikInsert", korisnickoImeParameter, lozinkaParameter, imeParameter, prezimeParameter, spolParameter, emailParameter);
        }
    
        public virtual int asp_DeleteRezervacija(Nullable<int> rezervacijaID)
        {
            var rezervacijaIDParameter = rezervacijaID.HasValue ?
                new ObjectParameter("RezervacijaID", rezervacijaID) :
                new ObjectParameter("RezervacijaID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("asp_DeleteRezervacija", rezervacijaIDParameter);
        }
    
        public virtual int asp_DodajKomentar(string komentar, Nullable<int> korisnikID, Nullable<int> filmID, Nullable<int> komentarKomentaraID)
        {
            var komentarParameter = komentar != null ?
                new ObjectParameter("Komentar", komentar) :
                new ObjectParameter("Komentar", typeof(string));
    
            var korisnikIDParameter = korisnikID.HasValue ?
                new ObjectParameter("KorisnikID", korisnikID) :
                new ObjectParameter("KorisnikID", typeof(int));
    
            var filmIDParameter = filmID.HasValue ?
                new ObjectParameter("FilmID", filmID) :
                new ObjectParameter("FilmID", typeof(int));
    
            var komentarKomentaraIDParameter = komentarKomentaraID.HasValue ?
                new ObjectParameter("KomentarKomentaraID", komentarKomentaraID) :
                new ObjectParameter("KomentarKomentaraID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("asp_DodajKomentar", komentarParameter, korisnikIDParameter, filmIDParameter, komentarKomentaraIDParameter);
        }
    
        public virtual int asp_KomentarInsert(string komentar, Nullable<int> korisnikID, Nullable<int> filmID, Nullable<int> komentarKomentaraID)
        {
            var komentarParameter = komentar != null ?
                new ObjectParameter("Komentar", komentar) :
                new ObjectParameter("Komentar", typeof(string));
    
            var korisnikIDParameter = korisnikID.HasValue ?
                new ObjectParameter("KorisnikID", korisnikID) :
                new ObjectParameter("KorisnikID", typeof(int));
    
            var filmIDParameter = filmID.HasValue ?
                new ObjectParameter("FilmID", filmID) :
                new ObjectParameter("FilmID", typeof(int));
    
            var komentarKomentaraIDParameter = komentarKomentaraID.HasValue ?
                new ObjectParameter("KomentarKomentaraID", komentarKomentaraID) :
                new ObjectParameter("KomentarKomentaraID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("asp_KomentarInsert", komentarParameter, korisnikIDParameter, filmIDParameter, komentarKomentaraIDParameter);
        }
    
        public virtual ObjectResult<Filmovi> asp_SelectAktivneProjekcijeByNaziv(string naziv)
        {
            var nazivParameter = naziv != null ?
                new ObjectParameter("Naziv", naziv) :
                new ObjectParameter("Naziv", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Filmovi>("asp_SelectAktivneProjekcijeByNaziv", nazivParameter);
        }
    
        public virtual ObjectResult<Filmovi> asp_SelectAktivneProjekcijeByNaziv(string naziv, MergeOption mergeOption)
        {
            var nazivParameter = naziv != null ?
                new ObjectParameter("Naziv", naziv) :
                new ObjectParameter("Naziv", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Filmovi>("asp_SelectAktivneProjekcijeByNaziv", mergeOption, nazivParameter);
        }
    
        public virtual ObjectResult<Filmovi> asp_SelectTopAktivneProjekcije()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Filmovi>("asp_SelectTopAktivneProjekcije");
        }
    
        public virtual ObjectResult<Filmovi> asp_SelectTopAktivneProjekcije(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Filmovi>("asp_SelectTopAktivneProjekcije", mergeOption);
        }
    
        public virtual int asp_KorisniciUpdate(Nullable<int> korisnikID, string korisnickoIme, string ime, string prezime, string spol, string email, string lozinka)
        {
            var korisnikIDParameter = korisnikID.HasValue ?
                new ObjectParameter("KorisnikID", korisnikID) :
                new ObjectParameter("KorisnikID", typeof(int));
    
            var korisnickoImeParameter = korisnickoIme != null ?
                new ObjectParameter("KorisnickoIme", korisnickoIme) :
                new ObjectParameter("KorisnickoIme", typeof(string));
    
            var imeParameter = ime != null ?
                new ObjectParameter("Ime", ime) :
                new ObjectParameter("Ime", typeof(string));
    
            var prezimeParameter = prezime != null ?
                new ObjectParameter("Prezime", prezime) :
                new ObjectParameter("Prezime", typeof(string));
    
            var spolParameter = spol != null ?
                new ObjectParameter("Spol", spol) :
                new ObjectParameter("Spol", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var lozinkaParameter = lozinka != null ?
                new ObjectParameter("Lozinka", lozinka) :
                new ObjectParameter("Lozinka", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("asp_KorisniciUpdate", korisnikIDParameter, korisnickoImeParameter, imeParameter, prezimeParameter, spolParameter, emailParameter, lozinkaParameter);
        }
    
        public virtual int asp_FilmInsert(string naziv, byte[] slika)
        {
            var nazivParameter = naziv != null ?
                new ObjectParameter("Naziv", naziv) :
                new ObjectParameter("Naziv", typeof(string));
    
            var slikaParameter = slika != null ?
                new ObjectParameter("Slika", slika) :
                new ObjectParameter("Slika", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("asp_FilmInsert", nazivParameter, slikaParameter);
        }
    }
}
