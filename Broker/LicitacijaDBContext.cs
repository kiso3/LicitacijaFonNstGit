using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using DomenskeKlase.Ucenik;
using DomenskeKlase.ProstorniPodaci;
using DomenskeKlase.Vlasnistvo;
using DomenskeKlase.LicitacijaPriprema;
using DomenskeKlase.Licitacija;
using System.Data.Entity.Infrastructure;




namespace Broker.LicitacijaDBContext
{
    public class LicitacijaDBContext : DbContext
    {
        private static LicitacijaDBContext licitacijaDBContext;
        
        private LicitacijaDBContext()
            : base("Data Source=ASPIRE\\MSSQLSERVER2014; database=LicitacijaFonNstV5; Integrated Security=true;")
           //: base("name=LicitacijaFonNst")                     
        {
        // the terrible hack
        var ensureDLLIsCopied =  System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        
         }


        
        public static LicitacijaDBContext getInstance()
        {
            if (licitacijaDBContext == null)
            {
                licitacijaDBContext = new LicitacijaDBContext();
            }

            return licitacijaDBContext;
        }
        
        //public DbSet<C__RefactorLog> C__RefactorLog { get; set; }
        
        #region Domenski objekti
        /*Lice*/
        public DbSet<Lice> Lice { get; set; }
        public DbSet<Pravno> Pravno { get; set; }
        public DbSet<Fizicko> Fizicko { get; set; }
        public DbSet<Mesto> Mesto { get; set; }
        public DbSet<Vlasnik> Vlasnik { get; set; }        
        public DbSet<Predstavnik> Predstavnik { get; set; }
        public DbSet<KontaktOsoba> KontaktOsoba { get; set; }
        public DbSet<Komisija> Komisija { get; set; }
        public DbSet<StrucnaSprema> StrucnaSprema { get; set; }
        
        ///*ProstorniEntiet*/
        public DbSet<Ko> Ko { get; set; }
        public DbSet<Parcela> Parcela { get; set; }
        public DbSet<DeoParcele> DeoParcele { get; set; }
        public DbSet<Objekat> Objekat { get; set; }
        public DbSet<VrstaZemljista> VrstaZemljista { get; set; }
        public DbSet<PravniStatusObj> PravniStatusObj { get; set; }
        public DbSet<NacinKoriscenjaObj> NacinKoriscenjaObj { get; set; }
        public DbSet<NacinKoriscenjaDelaObj> NacinKoriscenjaDelaObj { get; set; }
        
        //public DbSet<Mesto> Mesto { get; set; }

        /*Vlasnistvo*/
        public DbSet<UpisPrava> UpisPrava { get; set; }
        public DbSet<VlsnikNepo> VlsnikNepo { get; set; }
        public DbSet<Teret> Teret { get; set; }
        public DbSet<VrstaPrava> VrstaPrava { get; set; }
        public DbSet<OblikSvojine> OblikSvojine { get; set; }
        public DbSet<VrstaTereta> VrstaTereta { get; set; }
        public DbSet<ClanoviZapisnikKomisija> ClanoviZapisnikKomisija { get; set; }


        //public DbSet<IzreceneMere> IzreceneMere { get; set; }
        //public DbSet<Ugovor> Ugovor { get; set; }
        //public DbSet<Zapisnik> Zapisnik { get; set; }

        /*Licitacija*/
        public DbSet<Prijava> Prijava { get; set; }
        public DbSet<PrijavaFizicko> PrijavaFizicko { get; set; }
        public DbSet<PrijavaPravno> PrijavaPravno { get; set; }        
        public DbSet<IzreceneMere> IzreceneMere { get; set; }
        public DbSet<PrijavaUZapisniku> PrijavaUZapisniku { get; set; }
        public DbSet<Ugovor> Ugovor { get; set; }
        public DbSet<Zapisnik> Zapisnik { get; set; }

        /*LicitacijaPriprema*/
        public DbSet<KomisijaZaIzraduPonude> KomisijaZaIzraduPonude { get; set; }
        public DbSet<Kompleks> Kompleks { get; set; }
        public DbSet<Nadmetanje> Nadmetanje { get; set; }
        public DbSet<Oglas> Oglas { get; set; }
        public DbSet<Resenje> Resenje { get; set; }
        public DbSet<SluzbaKn> SluzbaKn { get; set; }
        public DbSet<UlogaClanaKomisije> UlogaClanaKomisije { get; set; }
        public DbSet<ZahtevZaPoljZemlj> ZahtevZaPoljZemlj { get; set; }

        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            /*Lice*/
            modelBuilder.Entity<Mesto>().ToTable("Mesto")
                                        .HasKey(m => m.MestoId);

            modelBuilder.Entity<Lice>().ToTable("Lice")
                                        .HasKey(l => l.LiceId)
                                        .HasOptional(l => l.Mesto)
                                        .WithMany()
                                        .Map(m => m.MapKey("MestoId"));

            modelBuilder.Entity<Pravno>().ToTable("Pravno")
                                         .HasKey(p => p.LiceId);

            modelBuilder.Entity<Fizicko>().ToTable("Fizicko")
                                          .HasKey(f => f.LiceId);

            modelBuilder.Entity<Vlasnik>().ToTable("Vlasnik")
                                          .HasKey(v => v.LiceId);

            modelBuilder.Entity<Predstavnik>().ToTable("Predstavnik")
                                              .HasKey(p => p.LiceId);

            modelBuilder.Entity<KontaktOsoba>().ToTable("KontaktOsoba")
                                               .HasKey(k => k.LiceId);

            modelBuilder.Entity<Komisija>().ToTable("Komisija")
                                            .HasKey(k => k.LiceId)
                                            .HasOptional<StrucnaSprema>(k => k.StrucnaSprema)
                                            .WithMany()
                                            .Map(k =>
                                            {
                                                k.ToTable("Komisija");
                                                k.MapKey("StrucnaSpremaId");
                                            });

            modelBuilder.Entity<StrucnaSprema>().ToTable("StrucnaSprema")
                                                        .HasKey(s => s.StrucnaSpremaId);



            ///*ProstorniEntiet*/
            //modelBuilder.Entity<ProstorniEntitet>();
            //.HasOptional(e => e.Nadredjeni)
            //.WithMany()
            //.HasForeignKey(a => a.NadredjeniId);

            //modelBuilder.Entity<ProstorniEntitet>();
            //.HasMany(e => e.UpisPrava);


            modelBuilder.Entity<Ko>().ToTable("Ko");
            modelBuilder.Entity<Parcela>().ToTable("Parcela");
            modelBuilder.Entity<DeoParcele>().ToTable("DeoParcele");
            modelBuilder.Entity<Objekat>().ToTable("Objekat");
            modelBuilder.Entity<DeloviObjekta>().ToTable("DeloviObjekta");

            modelBuilder.Entity<VrstaZemljista>().ToTable("VrstaZemljista");
            modelBuilder.Entity<NacinKoriscenja>().ToTable("NacinKoriscenja");
            modelBuilder.Entity<PravniStatusObj>().ToTable("PravniStatusObj");
            modelBuilder.Entity<NacinKoriscenjaObj>().ToTable("NacinKoriscenjaObj");
            modelBuilder.Entity<NacinKoriscenjaDelaObj>().ToTable("NacinKoriscenjaDelaObj");


            ///*Vlasnistvo*/
            modelBuilder.Entity<UpisPrava>().ToTable("UpisPrava");
            modelBuilder.Entity<VlsnikNepo>().ToTable("VlsnikNepo");
            modelBuilder.Entity<Teret>().ToTable("Teret");

            modelBuilder.Entity<VrstaPrava>().ToTable("VrstaPrava");
            modelBuilder.Entity<OblikSvojine>().ToTable("OblikSvojine");
            modelBuilder.Entity<VrstaTereta>().ToTable("VrstaTereta");

            /*LicitacijaPriprema*/
            modelBuilder.Entity<KomisijaZaIzraduPonude>().ToTable("KomisijaZaIzraduPonude")
                                                         .HasKey(k => k.KomisijaId)
                                                         .HasKey(k => k.ResenjeId);

            modelBuilder.Entity<Kompleks>().ToTable("Kompleks")
                                            .HasKey(k => k.KompleksId)
                                            .HasMany(k => k.Nadmetanje)
                                            .WithRequired(n => n.Kompleks);

            modelBuilder.Entity<Nadmetanje>().ToTable("Nadmetanje")
                                            .HasKey(t => t.NadmetanjeId);

            modelBuilder.Entity<Nadmetanje>().HasRequired(o => o.Kompleks)
                                            .WithMany(k => k.Nadmetanje)
                                            .Map(m => m.MapKey("KompleksId"));

            modelBuilder.Entity<Nadmetanje>().HasRequired(n => n.Oglas)
                                            .WithMany(o => o.NadmetanjeList)
                                            .Map(m => m.MapKey("OglasId"));

            modelBuilder.Entity<Nadmetanje>().HasMany(n => n.PrijavaList)
                                             .WithRequired(p => p.Nadmetanje);

            modelBuilder.Entity<Resenje>().ToTable("Resenje")
                                  .HasKey(t => t.ResenjeId)
                                  .HasOptional(r => r.Oglas)
                                  .WithRequired(o => o.Resenje)
                                  .Map(m => m.MapKey("ResenjeId"));

            modelBuilder.Entity<Oglas>().ToTable("Oglas")
                                        .HasKey(t => t.OglasId)
                                        .HasRequired(o => o.Resenje)
                                        //.WithMany(r=>r.OglasList)
                                        .WithMany()
                                        .Map(m =>
                                        {
                                            m.MapKey("ResenjeId");
                                        });

            /*
            modelBuilder.Entity<Oglas>()                             
                             .HasMany<Nadmetanje>(o=>o.NadmetanjeList)
                             .WithOptional(n=>n.Oglas)
                             .Map(m =>
                             {
                                 m.MapKey("OglasId");
                             });
            */
  

            modelBuilder.Entity<SluzbaKn>().ToTable("SluzbaKn");
            modelBuilder.Entity<UlogaClanaKomisije>().ToTable("UlogaClanaKomisije");
            modelBuilder.Entity<ZahtevZaPoljZemlj>().ToTable("ZahtevZaPoljZemlj");

            ///*Licitacija*/
            modelBuilder.Entity<Prijava>().ToTable("Prijava")
                                          .HasKey(p => p.PrijavaId)
                                          .HasRequired(p => p.Nadmetanje)
                                          .WithMany(n => n.PrijavaList)
                                          .Map(m => m.MapKey("NadmetanjeId"));

            modelBuilder.Entity<Prijava>()
                              .HasOptional(p => p.Predstavnik)
                              .WithMany()
                              .Map(m => m.MapKey("LiceId"));

            modelBuilder.Entity<Prijava>().HasOptional(p => p.PrijavaUZapisniku)
                                          .WithRequired(pz => pz.Prijava);

            modelBuilder.Entity<PrijavaFizicko>().HasKey(pf => pf.PrijavaId);

            modelBuilder.Entity<PrijavaFizicko>().ToTable("PrijavaFizicko")
                                                 .HasRequired(p => p.Fizicko)
                                                 .WithMany()
                                                 .Map(m => m.MapKey("LiceId"));

            modelBuilder.Entity<PrijavaPravno>().HasKey(pp => pp.PrijavaId);

            modelBuilder.Entity<PrijavaPravno>().ToTable("PrijavaPravno")
                                                .HasRequired(p => p.Pravno)
                                                .WithMany()
                                                .Map(m => m.MapKey("LiceId")); ;

            modelBuilder.Entity<Garancije>().ToTable("Garancije")
                                            .HasKey(g => g.GarancijeId);

            
            modelBuilder.Entity<ClanoviZapisnikKomisija>().ToTable("ClanoviZapisnikKomisija")
                                                            .HasKey(czp => new {
                                                                czp.ZapisnikId
                                                                ,czp.LiceId
                                                                ,czp.UlogaClanaKomisijeId
                                                            });


            modelBuilder.Entity<ClanoviZapisnikKomisija>().ToTable("ClanoviZapisnikKomisija")
                                                          .HasRequired(c => c.Komisija)
                                                          .WithMany()
                                                          .HasForeignKey(c => c.LiceId);
                                                          //.Map(m => m.MapKey("LiceId"));

            modelBuilder.Entity<ClanoviZapisnikKomisija>().ToTable("ClanoviZapisnikKomisija")
                                                          .HasRequired(c => c.Zapisnik)
                                                          .WithMany(z => z.ClanoviZapisnikKomisije)
                                                          .HasForeignKey(c => c.ZapisnikId);
                                                          //.Map(m => m.MapKey("ZapisnikId"));


            modelBuilder.Entity<ClanoviZapisnikKomisija>().ToTable("ClanoviZapisnikKomisija")
                                                          .HasRequired(c => c.UlogaClanaKomisije)
                                                          .WithMany()
                                                          .HasForeignKey(c => c.UlogaClanaKomisijeId);
                                                         // .Map(m => m.MapKey("UlogaClanaKomisijeId"));

            modelBuilder.Entity<Zapisnik>().ToTable("Zapisnik")
                                           .HasKey(z => z.ZapisnikId)
                                           .HasRequired(z => z.Nadmetanje)
                                           .WithOptional()
                                           .Map(m => m.MapKey("NadmetanjeId"));

            modelBuilder.Entity<Zapisnik>().ToTable("Zapisnik")
                                           .HasMany(z => z.PrijavaUZapisniku)
                                           .WithRequired(p => p.Zapisnik);

            modelBuilder.Entity<Zapisnik>().ToTable("Zapisnik")
                                           .HasMany(z => z.ClanoviZapisnikKomisije)
                                           .WithRequired(c => c.Zapisnik);


            
            modelBuilder.Entity<PrijavaUZapisniku>().ToTable("PrijavaUZapisniku")
                                                .HasKey(pz => new {
                                                    pz.ZapisnikId,
                                                    pz.Rb
                                                });
            
            modelBuilder.Entity<PrijavaUZapisniku>().ToTable("PrijavaUZapisniku")                                                                                                     
                                                    .HasRequired<Zapisnik>(p => p.Zapisnik)
                                                    .WithMany(z => z.PrijavaUZapisniku)
                                                    .HasForeignKey(c => c.ZapisnikId);
            //.Map(m => m.MapKey("ZapisnikId"));

            modelBuilder.Entity<PrijavaUZapisniku>().ToTable("PrijavaUZapisniku")
                                                    .HasRequired<Prijava>(p => p.Prijava)
                                                    .WithOptional(z => z.PrijavaUZapisniku)
                                                    //.WithOptional(z => z.PrijavaUZapisniku)                                                                                                       
                                                    //.HasForeignKey(p => p.PrijavaId);
                                                   .Map(m => m.MapKey("PrijavaId"));

            modelBuilder.Entity<PrijavaUZapisniku>().ToTable("PrijavaUZapisniku")
                                                    .HasOptional(p => p.IzreceneMere)
                                                    .WithMany()
                                                    .Map(m => m.MapKey("IzreceneMereId"));
            
            modelBuilder.Entity<IzreceneMere>().ToTable("IzreceneMere")
                                               .HasKey(c => c.IzreceneMereId);
            
            modelBuilder.Entity<Ugovor>().ToTable("Ugovor");
            



            base.OnModelCreating(modelBuilder);
        }
    }
}
