using DomenskeKlase;
using DomenskeKlase.Ucenik;
using KontrolorAplikativnelogike;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ServiceProxies;

namespace WCFlicitacija
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        KALPonudjac kALPonudjac;

        public Service1()
        {
            kALPonudjac = new KALPonudjac();
        }

        #region Lice
        public DTOLice InsertLiceSoWcf(DTOLice lice)
        {
            if (lice == null)
            {
                lice.poruka = Konstante.DTO_NULL;
            }
            if (lice.liceZahtev != null)
            {
                try
                {
                    kALPonudjac.InsertLiceSo(lice.liceZahtev);
                    lice.poruka = Konstante.INSERT_LICE_OK;
                }
                catch (Exception)
                {

                    lice.poruka = Konstante.INSERT_LICE_ERROR;
                }

            }
            else
            {
                lice.poruka = Konstante.DTO_ZAHTEV_NULL;
            }
            return lice;
        }

        public DTOLice DeleteLiceSoWcf(DTOLice lice)
        {
            if (lice == null)
            {
                lice.poruka = Konstante.DTO_NULL;
            }
            if (lice.liceZahtev != null)
            {
                try
                {
                    kALPonudjac.DeleteLiceSo(lice.liceZahtev);
                    lice.poruka = Konstante.DELETE_LICE_OK;
                }
                catch (Exception)
                {

                    lice.poruka = Konstante.DELETE_LICE_ERROR;
                }

            }
            else
            {
                lice.poruka = Konstante.DTO_ZAHTEV_NULL;
            }
            return lice;
        }

        public DTOLice AzurirajLiceSoWcf(DTOLice lice)
        {
            if (lice == null)
            {
                lice.poruka = Konstante.DTO_NULL;
            }
            if (lice.liceZahtev != null)
            {
                try
                {
                    kALPonudjac.AzurirajLiceSo(lice.liceZahtev);
                    lice.poruka = Konstante.AZURIAJ_LICE_OK;
                }
                catch (Exception)
                {

                    lice.poruka = Konstante.AZURIAJ_LICE_ERROR;
                }

            }
            else
            {
                lice.poruka = Konstante.DTO_ZAHTEV_NULL;
            }
            return lice;
        }

        public DTOLice GetLiceSoWcf(DTOLice lice)
        {
            if (lice == null)
            {
                lice.poruka = Konstante.DTO_NULL;
            }
            if (lice.liceZahtev != null)
            {
                try
                {
                    lice.liceOdgovor = kALPonudjac.GetLiceSo(lice.liceZahtev);
                    lice.poruka = Konstante.GET_LICE_OK;
                }
                catch (Exception)
                {

                    lice.poruka = Konstante.GET_LICE_ERROR;
                }

            }
            else
            {
                lice.poruka = Konstante.DTO_ZAHTEV_NULL;
            }
            return lice;
        }

        public DTOLice GetAllLiceSoWcf(DTOLice lice)
        {
            if (lice == null)
            {
                lice.poruka = Konstante.DTO_NULL;
            }
            
                try
                {
                    lice.liceOdgovorList = kALPonudjac.GetAllLiceSo(lice.liceZahtev);
                    lice.poruka = Konstante.GET_ALL_LICE_OK;
                }
                catch (Exception)
                {

                    lice.poruka = Konstante.GET_ALL_LICE_ERROR;
                }
            
            return lice;
        }

        #endregion

        #region Fizicko
        public DTOFizicko InsertFizickoSoWcf(DTOFizicko fizicko)
        {
            if (fizicko == null)
            {
                fizicko.poruka = Konstante.DTO_NULL;
            }
            if (fizicko.fizickoZahtev != null)
            {
                try
                {
                    kALPonudjac.InsertFizickoSo(fizicko.fizickoZahtev);
                    fizicko.poruka = Konstante.INSERT_FIZICKO_OK;
                }
                catch (Exception)
                {

                    fizicko.poruka = Konstante.INSERT_FIZICKO_ERROR;
                }
                
            }
            else
            { 
                fizicko.poruka = Konstante.DTO_ZAHTEV_NULL; 
            }
            return fizicko;
        }

        public DTOFizicko DeleteFizickoSoWcf(DTOFizicko fizicko)
        {
            if (fizicko == null)
            {
                fizicko.poruka = Konstante.DTO_NULL;
            }
            if (fizicko.fizickoZahtev != null)
            {
                try
                {
                    kALPonudjac.DeleteFizickoSo(fizicko.fizickoZahtev);
                    fizicko.poruka = Konstante.DELETE_FIZICKO_OK;
                }
                catch (Exception)
                {

                    fizicko.poruka = Konstante.DELETE_FIZICKO_ERROR;
                }
                
            }
            else
            {
                fizicko.poruka = Konstante.DTO_ZAHTEV_NULL;
            }
            return fizicko;
        }

        public DTOFizicko AzurirajFizickoSoWcf(DTOFizicko fizicko)
        {
            if (fizicko == null)
            {
                fizicko.poruka = Konstante.DTO_NULL;
            }
            if (fizicko.fizickoZahtev != null)
            {
                try
                {
                    kALPonudjac.AzurirajFizickoSo(fizicko.fizickoZahtev);
                    fizicko.poruka = Konstante.AZURIAJ_FIZICKO_OK;
                }
                catch (Exception)
                {

                    fizicko.poruka = Konstante.AZURIAJ_FIZICKO_ERROR;
                }
                
            }
            else
            {
                fizicko.poruka = Konstante.DTO_ZAHTEV_NULL;
            }
            return fizicko;
        }

        public DTOFizicko GetFizickoSoWcf(DTOFizicko fizicko)
        {
            if (fizicko == null)
            {
                fizicko.poruka = Konstante.DTO_NULL;
            }
            if (fizicko.fizickoZahtev != null)
            {
                try 
	            {
                    fizicko.fizickoOdgovor = kALPonudjac.GetFizickoSo(fizicko.fizickoZahtev);
                    fizicko.poruka = Konstante.GET_FIZICKO_OK;
	            }
	            catch (Exception)
	            {

                    fizicko.poruka = Konstante.GET_FIZICKO_ERROR;
	            }
                
            }
            else
            {
                fizicko.poruka = Konstante.DTO_ZAHTEV_NULL;
            }
            return fizicko;
        }

        public DTOFizicko GetAllFizickoSoWcf(DTOFizicko fizicko)
        {
            if (fizicko == null)
            {
                fizicko.poruka = Konstante.DTO_NULL;
            }
            if (fizicko.fizickoZahtev != null)
            {
                try
                {
                    fizicko.fizickoOdgovorList = kALPonudjac.GetAllFizickoSo(fizicko.fizickoZahtev);
                    fizicko.poruka = Konstante.GET_ALL_FIZICKO_OK;
                }
                catch (Exception)
                {

                    fizicko.poruka = Konstante.GET_ALL_FIZICKO_ERROR;
                }
                
            }
            else
            {
                fizicko.poruka = Konstante.DTO_ZAHTEV_NULL;
            }
            return fizicko;
        }
        #endregion

        #region Pravno
        public DTOPravno InsertPravnoSoWcf(DTOPravno pravno)
        {
            if (pravno == null)
            {
                pravno.poruka = Konstante.DTO_NULL;
            }
            if (pravno.pravnoZahtev != null)
            {
                try
                {
                    kALPonudjac.InsertPravnoSo(pravno.pravnoZahtev);
                    pravno.poruka = Konstante.INSERT_PRAVNO_OK;
                }
                catch (Exception)
                {

                    pravno.poruka = Konstante.INSERT_PRAVNO_ERROR;
                }
                
            }
            else
            {
                pravno.poruka = Konstante.DTO_ZAHTEV_NULL;
            }
            return pravno;
        }

        public DTOPravno DeletePravnoSoWcf(DTOPravno pravno)
        {
            if (pravno == null)
            {
                pravno.poruka = Konstante.DTO_NULL;
            }
            if (pravno.pravnoZahtev != null)
            {
                try
                {
                    kALPonudjac.DeletePravnoSo(pravno.pravnoZahtev);
                    pravno.poruka = Konstante.DELETE_FIZICKO_OK;
                }
                catch (Exception)
                {

                    pravno.poruka = Konstante.DELETE_FIZICKO_ERROR;
                }
                
            }
            else
            {
                pravno.poruka = Konstante.DTO_ZAHTEV_NULL;
            }
            return pravno;
        }

        public DTOPravno AzurirajPravnoSoWcf(DTOPravno pravno)
        {
            if (pravno == null)
            {
                pravno.poruka = Konstante.DTO_NULL;
            }
            if (pravno.pravnoZahtev != null)
            {
                try 
	            {
                    kALPonudjac.AzurirajPravnoSo(pravno.pravnoZahtev);
                    pravno.poruka = Konstante.AZURIAJ_PRAVNO_OK;
	            }
	            catch (Exception)
	            {

                    pravno.poruka = Konstante.AZURIAJ_PRAVNO_ERROR;
	            }
                
            }
            else
            {
                pravno.poruka = Konstante.DTO_ZAHTEV_NULL;
            }
            return pravno;
        }

        public DTOPravno GetPravnoSoWcf(DTOPravno pravno)
        {
            if (pravno == null)
            {
                pravno.poruka = Konstante.DTO_NULL;
            }
            if (pravno.pravnoZahtev != null)
            {
                try
                {
                    pravno.pravnoOdgovor = kALPonudjac.GetPravnoSo(pravno.pravnoZahtev);
                    pravno.poruka = Konstante.GET_PRAVNO_OK;
                }
                catch (Exception)
                {

                    pravno.poruka = Konstante.GET_PRAVNO_ERROR;
                }
                
            }
            else
            {
                pravno.poruka = Konstante.DTO_ZAHTEV_NULL;
            }
            return pravno;
        }

        public DTOPravno GetAllPravnoSoWcf(DTOPravno pravno)
        {
            if (pravno == null)
            {
                pravno.poruka = Konstante.DTO_NULL;
            }
            if (pravno.pravnoZahtev != null)
            {
                try
                {
                    pravno.pravnoOdgovorList = kALPonudjac.GetAllPravnoSo(pravno.pravnoZahtev);
                    pravno.poruka = Konstante.GET_ALL_PRAVNO_OK;
                }
                catch (Exception)
                {

                    pravno.poruka = Konstante.GET_ALL_PRAVNO_ERROR;
                }
                
            }
            else
            {
                pravno.poruka = Konstante.DTO_ZAHTEV_NULL;
            }
            return pravno;
        }
        #endregion

        #region Mesto
        public DTOMesto IsertMestoSoWcf(DTOMesto mesto)
        {
            if (mesto == null)
            {
                mesto.poruka = Konstante.DTO_NULL;
            }
            if (mesto.mestoZahtev != null)
            {
                try
                {
                    kALPonudjac.InsertMestoSo(mesto.mestoZahtev);
                    mesto.poruka = Konstante.INSERT_MESTO_OK;
                }
                catch (Exception)
                {

                    mesto.poruka = Konstante.INSERT_MESTO_ERROR;
                }
                
            }
            else
            {
                mesto.poruka = Konstante.DTO_ZAHTEV_NULL;
            }
            return mesto;
        }

        public DTOMesto DeleteMestoSoWcf(DTOMesto mesto)
        {
            if (mesto == null)
            {
                mesto.poruka = Konstante.DTO_NULL;
            }
            if (mesto.mestoZahtev != null)
            {
                try
                {
                    kALPonudjac.DeleteMestoSo(mesto.mestoZahtev);
                    mesto.poruka = Konstante.DELETE_MESTO_OK;
                }
                catch (Exception)
                {

                    mesto.poruka = Konstante.DELETE_MESTO_ERROR;
                }
                
            }
            else
            {
                mesto.poruka = Konstante.DTO_ZAHTEV_NULL;
            }
            return mesto;
        }

        public DTOMesto AzurirajMestooSoWcf(DTOMesto mesto)
        {
            if (mesto == null)
            {
                mesto.poruka = Konstante.DTO_NULL;
            }
            if (mesto.mestoZahtev != null)
            {
                try
                {
                    kALPonudjac.AzurirajMestoSo(mesto.mestoZahtev);
                    mesto.poruka = Konstante.AZURIAJ_MESTO_OK;
                }
                catch (Exception)
                {

                    mesto.poruka = Konstante.AZURIAJ_MESTO_ERROR;
                }
                
            }
            else
            {
                mesto.poruka = Konstante.DTO_ZAHTEV_NULL;
            }
            return mesto;
        }

        public DTOMesto GetMestoSoWcf(DTOMesto mesto)
        {
            if (mesto == null)
            {
                mesto.poruka = Konstante.DTO_NULL;
            }
            if (mesto.mestoZahtev != null)
            {
                try
                {
                    mesto.mestoOdgovor = kALPonudjac.GetMestoSo(mesto.mestoZahtev);
                    mesto.poruka = Konstante.GET_MESTO_OK;
                }
                catch (Exception)
                {

                    mesto.poruka = Konstante.GET_MESTO_ERROR;
                }
                
            }
            else
            {
                mesto.poruka = Konstante.DTO_ZAHTEV_NULL;
            }
            return mesto;
        }

        public DTOMesto GetAllMestoSoWcf(DTOMesto mesto)
        {
            if (mesto == null)
            {
                mesto.poruka = Konstante.DTO_NULL;
            }
            if (mesto.mestoZahtev != null)
            {
                try
                {
                    mesto.mestoOdgovorList = kALPonudjac.GetAllMestoSo(mesto.mestoZahtev);
                    mesto.poruka = Konstante.GET_ALL_MESTO_OK;
                }
                catch (Exception)
                {

                    mesto.poruka = Konstante.GET_MESTO_ERROR;
                }
                
            }
            else
            {
                mesto.poruka = Konstante.DTO_ZAHTEV_NULL;
            }
            return mesto;
        }
        #endregion

        #region Oglas
        public DTOOglas GetAllOglasSoWcf(DTOOglas oglas)
        {
            if (oglas == null)
            {
                oglas.poruka = Konstante.DTO_NULL;
            }
            if (oglas.oglasZahtev != null)
            {
                try
                {
                    oglas.oglasOdgovorList = kALPonudjac.GetAllOglasSo(oglas.oglasZahtev);
                    oglas.poruka = Konstante.GET_ALL_OGLAS_OK;
                }
                catch (Exception)
                {

                    oglas.poruka = Konstante.GET_ALL_OGLAS_ERROR;
                }

            }
            else
            {
                oglas.poruka = Konstante.DTO_ZAHTEV_NULL;
            }
            return oglas;
        }
        #endregion

        #region Resenje
        public DTOResenje GetAllResenjeSoWcf(DTOResenje resenje)
        {
            if (resenje == null)
            {
                resenje.poruka = Konstante.DTO_NULL;
            }
            if (resenje.resenjeZahtev != null)
            {
                try
                {
                    resenje.resenjeOdgovorList = kALPonudjac.GetAllResenjeSo(resenje.resenjeZahtev);
                    resenje.poruka = Konstante.GET_ALL_RESENJE_OK;
                }
                catch (Exception)
                {

                    resenje.poruka = Konstante.GET_ALL_RESENJE_ERROR;
                }

            }
            else
            {
                resenje.poruka = Konstante.DTO_ZAHTEV_NULL;
            }
            return resenje;
        
        }
        #endregion

        #region Nadmetanje
        public DTONadmetanje GetNadmetanjeSoWcf(DTONadmetanje nadmetanje)
        {
            if (nadmetanje == null)
            {
                nadmetanje.poruka = Konstante.DTO_NULL;
            }
            if (nadmetanje.nadmetanjeZahtev != null)
            {
                try
                {
                    nadmetanje.nadmetanjeOdgovor = kALPonudjac.GetNadmetanjeSo(nadmetanje.nadmetanjeZahtev);
                    nadmetanje.poruka = Konstante.GET_NADMETANJE_OK;
                }
                catch (Exception)
                {

                    nadmetanje.poruka = Konstante.GET_NADMETANJE_ERROR;
                }

            }
            else
            {
                nadmetanje.poruka = Konstante.DTO_ZAHTEV_NULL;
            }
            return nadmetanje;
        }



        public DTONadmetanje GetAllNadmetanjeForOglasSoWcf(DTOOglas oglas)
        {
            DTONadmetanje nadmetanje = new DTONadmetanje();
            if (oglas == null)
            {
                oglas.poruka = Konstante.DTO_NULL;
            }
            if (oglas.oglasZahtev != null)
            {
                try
                {
                    nadmetanje.nadmetanjeOdgovorList = kALPonudjac.GetAllNadmetanjeForOglasSo(oglas.oglasZahtev);
                    nadmetanje.poruka = Konstante.GET_ALL_NADMETANJE_OK;
                }
                catch (Exception)
                {

                    nadmetanje.poruka = Konstante.GET_ALL_NADMETANJE_ERROR;
                }

            }
            else
            {
                nadmetanje.poruka = Konstante.DTO_ZAHTEV_NULL;
            }
            return nadmetanje;
        }

        #endregion

        

        #region Prijava
        public DTOPrijava InsertPrijavaSoWcf(DTOPrijava priava)
        {
            if (priava == null)
            {
                priava.poruka = Konstante.DTO_NULL;
            }
            if (priava.prijavaZahtev != null)
            {
                try
                {
                    kALPonudjac.InsertPrijavaSo(priava.prijavaZahtev);
                    priava.poruka = Konstante.INSERT_PRIJAVA_OK;
                }
                catch (Exception)
                {

                    priava.poruka = Konstante.INSERT_PRIJAVA_ERROR;
                }

            }
            else
            {
                priava.poruka = Konstante.DTO_ZAHTEV_NULL;
            }
            return priava;
        }
        #endregion



        public DTOPrijava DeletePrijavaSoWcf(DTOPrijava prijava)
        {
            if (prijava == null)
            {
                prijava.poruka = Konstante.DTO_NULL;
            }
            if (prijava.prijavaZahtev != null)
            {
                try
                {
                    kALPonudjac.DeletePrijavaSo(prijava.prijavaZahtev);
                    prijava.poruka = Konstante.DELETE_PRIJAVA_OK;
                }
                catch (Exception)
                {

                    prijava.poruka = Konstante.DELETE_PRIJAVA_ERROR;
                }

            }
            else
            {
                prijava.poruka = Konstante.DTO_ZAHTEV_NULL;
            }
            return prijava;
        }

        public DTOPrijava AzurirajPrijavaSoWcf(DTOPrijava prijava)
        {
            if (prijava == null)
            {
                prijava.poruka = Konstante.DTO_NULL;
            }
            if (prijava.prijavaZahtev != null)
            {
                try
                {
                    kALPonudjac.AzurirajPrijavaSo(prijava.prijavaZahtev);
                    prijava.poruka = Konstante.AZURIAJ_PRIJAVA_OK;
                }
                catch (Exception)
                {

                    prijava.poruka = Konstante.AZURIAJ_PRIJAVA_ERROR;
                }

            }
            else
            {
                prijava.poruka = Konstante.DTO_ZAHTEV_NULL;
            }
            return prijava;
        }


        public DTOLice GetAllLiceForPrijavaSoWcf(DTONadmetanje nadmetanje)
        {
            DTOLice lice = new DTOLice();
            if (nadmetanje == null)
            {
                lice.poruka = Konstante.DTO_NULL;
            }
            if (nadmetanje.nadmetanjeZahtev != null)
            {
                try
                {
                    
                    lice.liceOdgovorList = kALPonudjac.GetAllLicaForPrijavaSo(nadmetanje.nadmetanjeZahtev);
                    //lice.liceOdgovorList = kALPonudjac.GetAllLiceSo(lice.liceZahtev);
                    lice.poruka = Konstante.AZURIAJ_PRIJAVA_OK;
                }
                catch (Exception)
                {

                    lice.poruka = Konstante.AZURIAJ_PRIJAVA_ERROR;
                }

            }
            else
            {
                lice.poruka = Konstante.DTO_ZAHTEV_NULL;
            }
            return lice;
        }

        public DTOPrijava GetAllPrijavaForNadmetanjeSoWcf(DTONadmetanje nadmetanje)
        {
            DTOPrijava prijave = new DTOPrijava();
            if (nadmetanje == null)
            {
                prijave.poruka = Konstante.DTO_NULL;
            }
            if (nadmetanje.nadmetanjeZahtev != null)
            {
                try
                {

                    prijave.prijavaOdgovorList = kALPonudjac.GetAllPrijavaForNadmetanjeSo(nadmetanje.nadmetanjeZahtev);                   
                    prijave.poruka = Konstante.GET_ALL_PRIJAVA_OK;
                }
                catch (Exception)
                {

                    prijave.poruka = Konstante.GET_ALL_PRIJAVA_ERROR;
                }

            }
            else
            {
                prijave.poruka = Konstante.DTO_ZAHTEV_NULL;
            }
            return prijave;
        }



    }
}
