using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomenskeKlase
{
    public struct Konstante
    {
        #region DTO
        public const String DTO_NULL = "Data transfer objekat null";
        public const String DTO_ZAHTEV_NULL = "Data transfer objekat zahtev null";
        #endregion

        #region Lice
        public const String INSERT_LICE_OK = "Uspešno dodat lice";
        public const String INSERT_LICE_ERROR = "Neuspešno dodavanje lice";
        public const String DELETE_LICE_OK = "Uspešno obrisano lice";
        public const String DELETE_LICE_ERROR = "Neuspešno obrisano lice";
        public const String AZURIAJ_LICE_OK = "Uspešno ažurirano lice";
        public const String AZURIAJ_LICE_ERROR = "Neuspešno ažurirano lice";
        public const String GET_LICE_OK = "Uspešno pronađeno lice";
        public const String GET_LICE_ERROR = "Neuspešno pronađeno lice";
        public const String GET_ALL_LICE_OK = "Uspešno pronađena lica";
        public const String GET_ALL_LICE_ERROR = "Neuspešno pronađena lica";
        #endregion        
        
        #region Fizicko
        public const String INSERT_FIZICKO_OK = "Uspešno dodato fizičko";
        public const String INSERT_FIZICKO_ERROR = "Neuspešno dodavanje fizičko";
        public const String DELETE_FIZICKO_OK = "Uspešno obrisano fizičko";
        public const String DELETE_FIZICKO_ERROR = "Neuspešno obrisano fizičko";
        public const String AZURIAJ_FIZICKO_OK = "Uspešno ažurirano fizičko";
        public const String AZURIAJ_FIZICKO_ERROR = "Neuspešno ažurirano fizičko";
        public const String GET_FIZICKO_OK = "Uspešno pronađeno fizičko";
        public const String GET_FIZICKO_ERROR = "Neuspešno pronađeno fizičko";
        public const String GET_ALL_FIZICKO_OK = "Uspešno pronađena fizička lica";
        public const String GET_ALL_FIZICKO_ERROR = "Neuspešno pronađena fizička lica";
        #endregion

        #region Pravno
        public const String INSERT_PRAVNO_OK = "Uspešno dodato pravno";
        public const String INSERT_PRAVNO_ERROR = "Neuspešno dadavanje pravno";
        public const String DELETE_PRAVNO_OK = "Uspešno obrisano pravno";
        public const String DELETE_PRAVNO_ERROR = "Neuspešno obrisano pravno";
        public const String AZURIAJ_PRAVNO_OK = "Uspešno ažurirano pravno";
        public const String AZURIAJ_PRAVNO_ERROR = "Neuspešno ažurirano pravno";
        public const String GET_PRAVNO_OK = "Uspešno pronađeno pravno";
        public const String GET_PRAVNO_ERROR = "Neuspešno pronađeno pravno";
        public const String GET_ALL_PRAVNO_OK = "Uspešno pronađena pravna lica";
        public const String GET_ALL_PRAVNO_ERROR = "Neuspešno pronađena pravno lica";
        #endregion

        #region Mesto
        public const String INSERT_MESTO_OK = "Uspešno dodato mesto";
        public const String INSERT_MESTO_ERROR = "Neuspešno dodavanje mesto";
        public const String DELETE_MESTO_OK = "Uspešno obrisano mesto";
        public const String DELETE_MESTO_ERROR = "Neuspešno obrisano mesto";
        public const String AZURIAJ_MESTO_OK = "Uspešno ažurirano mesto";
        public const String AZURIAJ_MESTO_ERROR = "Neuspešno ažurirano mesto";
        public const String GET_MESTO_OK = "Uspešno pronađeno mesto";
        public const String GET_MESTO_ERROR = "Neuspešno pronađeno mesto";
        public const String GET_ALL_MESTO_OK = "Uspešno pronađena mesta";
        public const String GET_ALL_MESTO_ERROR = "Neuspešno pronađena mesta";
        #endregion

        #region Oglas
        public const String INSERT_OGLAS_OK = "Uspešno ubačeno oglas";
        public const String INSERT_OGLAS_ERROR = "Neuspešno ubačeno oglas";
        public const String DELETE_OGLAS_OK = "Uspešno obrisano oglas";
        public const String DELETE_OGLAS_ERROR = "Neuspešno obrisano oglas";
        public const String AZURIAJ_OGLAS_OK = "Uspešno ažurirano oglas";
        public const String AZURIAJ_OGLAS_ERROR = "Neuspešno ažurirano oglas";
        public const String GET_OGLAS_OK = "Uspešno pronadjeno oglas";
        public const String GET_OGLAS_ERROR = "Neuspešno pronađeno oglas";
        public const String GET_ALL_OGLAS_OK = "Uspešno pronađeni oglasi";
        public const String GET_ALL_OGLAS_ERROR = "Neuspešno pronađena oglasi";
        #endregion

        #region Resene
        public const String INSERT_RESENJE_OK = "Uspešno dodato rešenje";
        public const String INSERT_RESENJE_ERROR = "Neuspešno dodavanje rešenje";
        public const String DELETE_RESENJE_OK = "Uspešno obrisano rešenje";
        public const String DELETE_RESENJE_ERROR = "Neuspešno nrianje rešenja";
        public const String AZURIAJ_RESENJE_OK = "Uspešno ažurirano rešenje";
        public const String AZURIAJ_RESENJE_ERROR = "Neuspešno ažurirano rešenje";
        public const String GET_RESENJE_OK = "Uspešno pronađeno rešenje";
        public const String GET_RESENJE_ERROR = "Neuspešno pronađeno rešenje";
        public const String GET_ALL_RESENJE_OK = "Uspešno pronađena rešenja";
        public const String GET_ALL_RESENJE_ERROR = "Neuspešno pronađena rešenja";
        #endregion

        #region Nadmetanje
        public const String INSERT_NADMETANJE_OK = "Uspešno dodato nadmetanje";
        public const String INSERT_NADMETANJE_ERROR = "Neuspešno dodavanje nadmetanje";
        public const String DELETE_NADMETANJE_OK = "Uspešno obrisano nadmetanje";
        public const String DELETE_NADMETANJE_ERROR = "Neuspešno brianje nadmetanje";
        public const String AZURIAJ_NADMETANJE_OK = "Uspešno ažurirano nadmetanje";
        public const String AZURIAJ_NADMETANJE_ERROR = "Neuspešno ažurirano nadmetanje";
        public const String GET_NADMETANJE_OK = "Uspešno pronađeno nadmetanje";
        public const String GET_NADMETANJE_ERROR = "Neuspešno pronađeno nadmetanje";
        public const String GET_ALL_NADMETANJE_OK = "Uspešno pronađena nadmetanja";
        public const String GET_ALL_NADMETANJE_ERROR = "Neuspešno pronađena nadmetanja";
        #endregion

        #region Prijava
        public const String INSERT_PRIJAVA_OK = "Uspešno dodata prijava";
        public const String INSERT_PRIJAVA_ERROR = "Neuspešno dodavanje prijava";
        public const String DELETE_PRIJAVA_OK = "Uspešno obrisana prijava";
        public const String DELETE_PRIJAVA_ERROR = "Neuspešno brisanje priajve";
        public const String AZURIAJ_PRIJAVA_OK = "Uspešno ažurirana prijava";
        public const String AZURIAJ_PRIJAVA_ERROR = "Neuspešno ažurirnje prijava";
        public const String GET_PRIJAVA_OK = "Uspešno pronađena prijava";
        public const String GET_PRIJAVA_ERROR = "Neuspešno pronađena prijava";
        public const String GET_ALL_PRIJAVA_OK = "Uspešno pronađene prijave";
        public const String GET_ALL_PRIJAVA_ERROR = "Neuspešno pronađene prijave";
        #endregion
    }
}
