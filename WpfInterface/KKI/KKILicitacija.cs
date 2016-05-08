using DomenskeKlase;
using DomenskeKlase.Ucenik;
using DomenskeKlase.LicitacijaPriprema;
using DomenskeKlase.Licitacija;
using System;
using System.Collections.Generic;
using WpfInterface3.ServiceLicitacija;
using WpfInterface3.Panel;

namespace WpfInterface3.KKI
{
    class KKILicitacija
    {
        ServiceLicitacija.Service1Client serviceLicitacija;
        //protected OpstaEkranskaForma oef;
        private static KKILicitacija instance;
        public static KKILicitacija Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new KKILicitacija();
                }
                return instance;
            }
        }
        private KKILicitacija()
        {
            try
            {
                serviceLicitacija = new ServiceLicitacija.Service1Client("BasicHttpBinding_IService1");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    
        
        #region Lice

        public string InsertLiceSo(Lice lice)
        {
            DTOLice dtoLice = new DTOLice();
            dtoLice.liceZahtev = lice;
            return serviceLicitacija.InsertLiceSoWcf(dtoLice).poruka;
        }

        public string DeleteLiceSo(Lice lice)
        {
            DTOLice dtoLice = new DTOLice();
            dtoLice.liceZahtev = lice;
            return serviceLicitacija.DeleteLiceSoWcf(dtoLice).poruka;
        }

        public string AzurirajLiceSo(Lice lice)
        {
            DTOLice dtoLice = new DTOLice();
            dtoLice.liceZahtev = lice;
            return serviceLicitacija.AzurirajLiceSoWcf(dtoLice).poruka;
        }

        public List<Lice> GetAllLiceSo()
        {
            DTOLice dtoLice = new DTOLice();
            //dtoLice.liceZahtev = new Lice();
            dtoLice = serviceLicitacija.GetAllLiceSoWcf(dtoLice);
            if (dtoLice.poruka.Equals(Konstante.GET_ALL_LICE_OK))
            {
                return dtoLice.liceOdgovorList;
            }
            return null;
        }

        #endregion

        #region Fizicko

        public string InsertFizickoSo(Fizicko fizicko)
        {
            //obj = oef.kreirajObjekat();
            //KonvertujGrafickiObjekatUDomenskiObjekat();

            DTOFizicko dtoFizicko = new DTOFizicko();
            dtoFizicko.fizickoZahtev = fizicko;

            dtoFizicko = serviceLicitacija.InsertFizickoSoWcf(dtoFizicko);
            //obj = dtoFizicko.fizickoZahtev;

            //KonvertujDomenskiObjekatUGrafickiObjekat();
            return dtoFizicko.poruka;
        }

        public string DeleteFizickoSo(Fizicko fizicko)
        {
            DTOFizicko dtoFizicko = new DTOFizicko();
            dtoFizicko.fizickoZahtev = fizicko;
            return serviceLicitacija.DeleteFizickoSoWcf(dtoFizicko).poruka;
        }

        public string AzurirajFizickoSo(Fizicko fizicko)
        {
            //obj = oef.kreirajObjekat();
            //KonvertujGrafickiObjekatUDomenskiObjekat();

            DTOFizicko dtoFizicko = new DTOFizicko();
            dtoFizicko.fizickoZahtev = fizicko;

            dtoFizicko = serviceLicitacija.AzurirajFizickoSoWcf(dtoFizicko);
            //obj = dtoFizicko.fizickoZahtev;

           // KonvertujDomenskiObjekatUGrafickiObjekat();
            return dtoFizicko.poruka;
        }

        public List<Fizicko> GetAllFizickoSo()
        {
            DTOFizicko dtoFizicko = new DTOFizicko();
            dtoFizicko.fizickoZahtev = new Fizicko();
            dtoFizicko = serviceLicitacija.GetAllFizickoSoWcf(dtoFizicko);
            if (dtoFizicko.poruka.Equals(Konstante.GET_ALL_FIZICKO_OK))
            {
                return dtoFizicko.fizickoOdgovorList;
            }
            return null;
        }

        #endregion

        #region Pravno

        public string InsertPravnoSo(Pravno pravno)
        {
            //obj = oef.kreirajObjekat();
            //KonvertujGrafickiObjekatUDomenskiObjekat();

            DTOPravno dtoPravno = new DTOPravno();
            dtoPravno.pravnoZahtev = pravno;

            dtoPravno = serviceLicitacija.InsertPravnoSoWcf(dtoPravno);
            //obj = dtoPravno.pravnoZahtev;

            //KonvertujDomenskiObjekatUGrafickiObjekat();
            return dtoPravno.poruka;
        }

        public string DeletePravnoSo(Pravno pravno)
        {
            DTOPravno dtoPravno = new DTOPravno();
            dtoPravno.pravnoZahtev = pravno;
            return serviceLicitacija.DeletePravnoSoWcf(dtoPravno).poruka;
        }

        public string AzurirajPravnoSo(Pravno pravno)
        {
            //obj = oef.kreirajObjekat();
            //KonvertujGrafickiObjekatUDomenskiObjekat();

            DTOPravno dtoPravno = new DTOPravno();
            dtoPravno.pravnoZahtev = pravno;

            dtoPravno = serviceLicitacija.AzurirajPravnoSoWcf(dtoPravno);
            //obj = dtoPravno.pravnoZahtev;

            //KonvertujDomenskiObjekatUGrafickiObjekat();
            return dtoPravno.poruka;

        }

        public List<Pravno> GetAllPravnoSo()
        {
            DTOPravno dtoPravno = new DTOPravno();
            dtoPravno.pravnoZahtev = new Pravno();
            dtoPravno = serviceLicitacija.GetAllPravnoSoWcf(dtoPravno);
            if (dtoPravno.poruka.Equals(Konstante.GET_ALL_PRAVNO_OK))
            {
                return dtoPravno.pravnoOdgovorList;
            }
            return null;
        }

        #endregion

        #region Mesto

        public List<Mesto> GetAllMestoSo()
        {
            DTOMesto dtoMesto = new DTOMesto();
            dtoMesto.mestoZahtev = new Mesto();
            dtoMesto = serviceLicitacija.GetAllMestoSoWcf(dtoMesto);
            if (dtoMesto.poruka.Equals(Konstante.GET_ALL_MESTO_OK))
            {
                return dtoMesto.mestoOdgovorList;
            }
            return null;
        }

        #endregion

        #region Ogals

        public List<Oglas> GetAllOglasSo()
        {
            DTOOglas dtoOglas = new DTOOglas();
            dtoOglas.oglasZahtev = new Oglas();
            dtoOglas = serviceLicitacija.GetAllOglasSoWcf(dtoOglas);
            if (dtoOglas.poruka.Equals(Konstante.GET_ALL_OGLAS_OK))
            {
                return dtoOglas.oglasOdgovorList;
            }
            return null;
        }

        #endregion

        #region Resenje

        public List<Resenje> GetAllResenjeSo()
        {
            DTOResenje dtoResenje = new DTOResenje();
            dtoResenje.resenjeZahtev = new Resenje();
            dtoResenje = serviceLicitacija.GetAllResenjeSoWcf(dtoResenje);
            if (dtoResenje.poruka.Equals(Konstante.GET_ALL_RESENJE_OK))
            {
                return dtoResenje.resenjeOdgovorList;
            }
            return null;
        }

        #endregion

        #region Nadmetanje

        public Nadmetanje GetNadmetanjeSo(Nadmetanje nadmetanje)
        {
            DTONadmetanje dtoNadmetanje = new DTONadmetanje();
            dtoNadmetanje.nadmetanjeZahtev = nadmetanje;
            dtoNadmetanje = serviceLicitacija.GetNadmetanjeSoWcf(dtoNadmetanje);
            if (dtoNadmetanje.poruka.Equals(Konstante.GET_NADMETANJE_OK))
            {
                return dtoNadmetanje.nadmetanjeOdgovor;
            }
            return null;
        }


        public List<Nadmetanje> GetAllNadmetanjeForOglasSo(Oglas oglas)
        {
            DTOOglas dtoOglas = new DTOOglas();
            dtoOglas.oglasZahtev = oglas;
            DTONadmetanje dtoNadmetanje = serviceLicitacija.GetAllNadmetanjeForOglasSoWcf(dtoOglas);
            if (dtoNadmetanje.poruka.Equals(Konstante.GET_ALL_NADMETANJE_OK))
            {
                return dtoNadmetanje.nadmetanjeOdgovorList;
            }
            return null;
        }

        #endregion

        #region Prijava

        public string InsertPrijavaSo(Prijava prijava)
        {
            DTOPrijava dtoPrijava = new DTOPrijava();
            dtoPrijava.prijavaZahtev = prijava;
            dtoPrijava = serviceLicitacija.InsertPrijavaSoWcf(dtoPrijava);
            return dtoPrijava.poruka;
        }

        public string DeletePrijavaSo(Prijava prijava)
        {
            DTOPrijava dtoPrijava = new DTOPrijava();
            dtoPrijava.prijavaZahtev = prijava;
            dtoPrijava = serviceLicitacija.DeletePrijavaSoWcf(dtoPrijava);
            return dtoPrijava.poruka;
        }


        public string AzurirajPrijavaSo(Prijava prijava)
        {
            DTOPrijava dtoPrijava = new DTOPrijava();
            dtoPrijava.prijavaZahtev = prijava;
            dtoPrijava = serviceLicitacija.AzurirajPrijavaSoWcf(dtoPrijava);
            return dtoPrijava.poruka;
        }

        public List<Lice> GetAllLicaForPrijavaSo(Nadmetanje nadmetanje)
        {
            DTONadmetanje dtoNadmetanje = new DTONadmetanje();
            dtoNadmetanje.nadmetanjeZahtev = nadmetanje;
            DTOLice dtoLice = serviceLicitacija.GetAllLiceForPrijavaSoWcf(dtoNadmetanje);
            return dtoLice.liceOdgovorList;
        }

        public List<Prijava> GetAllPrijavaForNadmetanjeSo(Nadmetanje nademtanje)
        {
            DTONadmetanje dtoNadmetanje = new DTONadmetanje();
            dtoNadmetanje.nadmetanjeZahtev = nademtanje;
            DTOPrijava dtoPrijava = serviceLicitacija.GetAllPrijavaForNadmetanjeSoWcf(dtoNadmetanje);
            return dtoPrijava.prijavaOdgovorList;

        }

        #endregion
    }
}

