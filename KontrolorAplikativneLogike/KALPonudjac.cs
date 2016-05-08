using System.Collections.Generic;
using DomenskeKlase.Ucenik;
using SistemskeOperacije.Ucesnik.SoFizicko;
using SistemskeOperacije.Ucesnik.SoPravno;
using SistemskeOperacije.Ucesnik.SoMesto;
using DomenskeKlase.LicitacijaPriprema;
using SistemskeOperacije.LicitacijaPriprema.SoOglas;
using SistemskeOperacije.LicitacijaPriprema.SoResenje;
using SistemskeOperacije.LicitacijaPriprema.SoNadmetanje;
using DomenskeKlase.Licitacija;
using SistemskeOperacije.LicitacijaPriprema.SoPrijavaPravno;
using SistemskeOperacije.Ucesnik.SoLice;
using SistemskeOperacije.LicitacijaPriprema.GetNadmetanje;
using SistemskeOperacije.SoPrijava;




namespace KontrolorAplikativnelogike
{
    public class KALPonudjac
    {


        #region Lice
        public void InsertLiceSo(Lice lice)
        {

            InsertLice so = new InsertLice();
            so.IzvrsiSo(lice);

        }

        public void DeleteLiceSo(Lice lice)
        {
            DeleteLice so = new DeleteLice();
            so.IzvrsiSo(lice);
        }

        public void AzurirajLiceSo(Lice lice)
        {
            AzurirajLice so = new AzurirajLice();
            so.IzvrsiSo(lice);
        }

        public Lice GetLiceSo(Lice lice)
        {
            GetLice so = new GetLice();
            so.IzvrsiSo(lice);
            return so.GetObject();
        }

        public List<Lice> GetAllLiceSo(Lice lice)
        {
            GetAllLice so = new GetAllLice();
            so.IzvrsiSo(lice);
            return so.GetList();
        }
      

        #endregion

        #region Fizicko
        public void InsertFizickoSo(Fizicko fizicko) 
        {

            InsertFizicko so = new InsertFizicko();
            so.IzvrsiSo(fizicko);

        }

        public void DeleteFizickoSo(Fizicko fizicko)
        {
            DeleteFizicko so = new DeleteFizicko();
            so.IzvrsiSo(fizicko);
        }

        public void AzurirajFizickoSo(Fizicko fizicko)
        {
            AzurirajFizicko so = new AzurirajFizicko();
            so.IzvrsiSo(fizicko);
        }

        public Fizicko GetFizickoSo(Fizicko fizicko) 
        {
            GetFizicko so = new GetFizicko();
            so.IzvrsiSo(fizicko);
            return so.GetObject();
        }

        public List<Fizicko> GetAllFizickoSo(Fizicko fizicko)
        {
            GetAllFizicko so = new GetAllFizicko();
            so.IzvrsiSo(fizicko);
            return so.GetList();
        }

        #endregion

        #region Pravno
        public void InsertPravnoSo(Pravno pravno)
        {
            InsertPravno so = new InsertPravno();
            so.IzvrsiSo(pravno);
        }

        public void DeletePravnoSo(Pravno pravno) 
        {
            DeletePravno so = new DeletePravno();
            so.IzvrsiSo(pravno);
        }

        public void AzurirajPravnoSo(Pravno pravno)
        {
            AzurirajPravno so = new AzurirajPravno();
            so.IzvrsiSo(pravno);
        }

        public Pravno GetPravnoSo(Pravno pravno)
        {
            GetPravno so = new GetPravno();
            so.IzvrsiSo(pravno);
            return so.GetObject();
        }

        public List<Pravno> GetAllPravnoSo(Pravno pravno)
        {
            GetAllPravno so = new GetAllPravno();
            so.IzvrsiSo(pravno);
            return so.GetList();
        }


        #endregion

        #region Mesto
        public void InsertMestoSo(Mesto mesto)
        {
            InsertMesto so = new InsertMesto();
            so.IzvrsiSo(mesto);
        }

        public void DeleteMestoSo(Mesto mesto)
        {
            DeleteMesto so = new DeleteMesto();
            so.IzvrsiSo(mesto);           
        }

        public void AzurirajMestoSo(Mesto mesto)
        {
            AzurirajMesto so = new AzurirajMesto();
            so.IzvrsiSo(mesto);
        }

        public Mesto GetMestoSo(Mesto mesto)
        {
            GetMesto so = new GetMesto();
            so.IzvrsiSo(mesto);
            return so.GetObject();
        }

        public List<Mesto> GetAllMestoSo(Mesto mesto)
        {
            GetAllMesto so = new GetAllMesto();
            so.IzvrsiSo(mesto);
            return so.GetList();
        }

        #endregion

        #region Oglas

        public List<Oglas> GetAllOglasSo(Oglas oglas)
        {

            GetAllOgals so = new GetAllOgals();
            so.IzvrsiSo(oglas);
            return so.Getlist();

        }

        #endregion

        #region Resenje

        public List<Resenje> GetAllResenjeSo(Resenje resenje)
        {

            GetAllResenje so = new GetAllResenje();
            so.IzvrsiSo(resenje);
            return so.Getlist();

        }

        #endregion

        #region Nadmetanje

        public Nadmetanje GetNadmetanjeSo(Nadmetanje nadmetanj)
        {
            GetNadmetanje so = new GetNadmetanje();
            so.IzvrsiSo(nadmetanj);
            return so.GetObject();
        }



        public List<Nadmetanje> GetAllNadmetanjeForOglasSo(Oglas oglas)
        {
            GetAllNadmetanjeForOglas so = new GetAllNadmetanjeForOglas();
            so.IzvrsiSo(oglas);
            return so.GetList();

        }

        #endregion

        #region Prijava

        public void InsertPrijavaSo(Prijava prijava)
        {
            InsertPrijava so = new InsertPrijava();
            so.IzvrsiSo(prijava);                        
        }

        public void DeletePrijavaSo(Prijava prijava)
        {
            DeletePrijava so = new DeletePrijava();
            so.IzvrsiSo(prijava);
        }

        public void AzurirajPrijavaSo(Prijava prijava)
        {
            AzurirajPrijava so = new AzurirajPrijava();
            so.IzvrsiSo(prijava);
        }

        public List<Lice> GetAllLicaForPrijavaSo(Nadmetanje nadmetanje)
        {
            GetAllLicaForPrijava so = new GetAllLicaForPrijava();
            so.IzvrsiSo(nadmetanje);
            return so.GetList();
        }

        public List<Prijava> GetAllPrijavaForNadmetanjeSo(Nadmetanje nadmetanje)
        {
            GetAllPrijaveForNademtanje so = new GetAllPrijaveForNademtanje();
            so.IzvrsiSo(nadmetanje);
            return so.GetList();
        }

        #endregion
    }
}
