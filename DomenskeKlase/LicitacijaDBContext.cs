using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DomenskeKlase.Ucenik;
using DomenskeKlase.ProstorniPodaci;
using DomenskeKlase.Vlasnistvo;
using DomenskeKlase.LicitacijaPriprema;
using DomenskeKlase.Licitacija;

namespace DomenskeKlase
{
    class LicitacijaDBContext : DbContext
    {
        //public Lice Lice { get; set; }
        public DbSet<Lice>  Lice { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            /*Lice*/
            modelBuilder.Entity<Lice>().ToTable("Lice");
            modelBuilder.Entity<Pravno>().ToTable("Pravno");
            modelBuilder.Entity<Fizicko>().ToTable("Fizicko");
            modelBuilder.Entity<Vlasnik>().ToTable("Vlanik");
            modelBuilder.Entity<Ponudjac>().ToTable("Ponudjac");
            modelBuilder.Entity<Predstavnik>().ToTable("Predstavnik");
            modelBuilder.Entity<KontaktOsoba>().ToTable("KontaktOsoba");
            modelBuilder.Entity<Komisija>().ToTable("Komisija");
            modelBuilder.Entity<StrucnaSprema>().ToTable("StrucnaSprema");

            /*ProstorniEntiet*/
            modelBuilder.Entity<ProstorniEntitet>()
                .HasOptional(e => e.Nadredjeni)
                .WithMany()
                .HasForeignKey(a => a.NadredjeniId);
            
            modelBuilder.Entity<ProstorniEntitet>()
                .HasMany(e => e.UpisPrava);


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


            /*Vlasnistvo*/
            modelBuilder.Entity<UpisPrava>().ToTable("UpisPrava");
            modelBuilder.Entity<VlsnikNepo>().ToTable("VlsnikNepo");
            modelBuilder.Entity<Teret>().ToTable("Teret");

            modelBuilder.Entity<VrstaPrava>().ToTable("VrstaPrava");
            modelBuilder.Entity<OblikSvojine>().ToTable("OblikSvojine");
            modelBuilder.Entity<VrstaTereta>().ToTable("VrstaTereta");

            

            
            base.OnModelCreating(modelBuilder);
        }
    }
}
