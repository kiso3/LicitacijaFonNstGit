using DomenskeKlase.Licitacija;
using DomenskeKlase.LicitacijaPriprema;
using DomenskeKlase.Ucenik;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace ServiceProxies
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        #region Lice WCF
        [OperationContract]
        DTOLice InsertLiceSoWcf(DTOLice lice);

        [OperationContract]
        DTOLice DeleteLiceSoWcf(DTOLice lice);

        [OperationContract]
        DTOLice AzurirajLiceSoWcf(DTOLice lice);

        [OperationContract]
        DTOLice GetLiceSoWcf(DTOLice lice);

        [OperationContract]
        DTOLice GetAllLiceSoWcf(DTOLice lice);
        #endregion

        #region Fizicko WCF
        [OperationContract]
        DTOFizicko InsertFizickoSoWcf(DTOFizicko fizicko);

        [OperationContract]
        DTOFizicko DeleteFizickoSoWcf(DTOFizicko fizicko);
        
        [OperationContract]
        DTOFizicko AzurirajFizickoSoWcf(DTOFizicko fizicko);
        
        [OperationContract]
        DTOFizicko GetFizickoSoWcf(DTOFizicko fizicko);
        
        [OperationContract]
        DTOFizicko GetAllFizickoSoWcf(DTOFizicko fizicko);
        #endregion

        #region Pravno WCF
        [OperationContract]
        DTOPravno InsertPravnoSoWcf(DTOPravno pravno);

        [OperationContract]
        DTOPravno DeletePravnoSoWcf(DTOPravno pravno);

        [OperationContract]
        DTOPravno AzurirajPravnoSoWcf(DTOPravno pravno);

        [OperationContract]
        DTOPravno GetPravnoSoWcf(DTOPravno pravno);

        [OperationContract]
        DTOPravno GetAllPravnoSoWcf(DTOPravno pravno);
        #endregion

        #region Mesto WCF
        [OperationContract]
        DTOMesto IsertMestoSoWcf(DTOMesto mesto);

        [OperationContract]
        DTOMesto DeleteMestoSoWcf(DTOMesto mesto);

        [OperationContract]
        DTOMesto AzurirajMestooSoWcf(DTOMesto mesto);

        [OperationContract]
        DTOMesto GetMestoSoWcf(DTOMesto mesto);

        [OperationContract]
        DTOMesto GetAllMestoSoWcf(DTOMesto mesto);
        #endregion

        #region Oglas
        [OperationContract]
        DTOOglas GetAllOglasSoWcf(DTOOglas oglas);
        #endregion

        #region Resnje
        [OperationContract]
        DTOResenje GetAllResenjeSoWcf(DTOResenje resenje);
        #endregion

        #region Nadmetanje
        [OperationContract]
        DTONadmetanje GetNadmetanjeSoWcf(DTONadmetanje nadmetaje);

        [OperationContract]
        DTONadmetanje GetAllNadmetanjeForOglasSoWcf(DTOOglas oglas);
        #endregion    

        #region Prijava
        [OperationContract]
        DTOPrijava InsertPrijavaSoWcf(DTOPrijava prijava);
        
        [OperationContract]
        DTOPrijava DeletePrijavaSoWcf(DTOPrijava prijava);


        [OperationContract]
        DTOPrijava AzurirajPrijavaSoWcf(DTOPrijava prijava);
        
        [OperationContract]
        DTOLice GetAllLiceForPrijavaSoWcf(DTONadmetanje nadmetanje);

        [OperationContract]
        DTOPrijava GetAllPrijavaForNadmetanjeSoWcf(DTONadmetanje nadmetanje);



        #endregion
    }


    [DataContract]    
    [KnownType(typeof(Pravno))]
    [KnownType(typeof(Fizicko))]    
    public class DTOLice
    {
        [DataMember]
        public Lice liceZahtev { get; set; }
        [DataMember]
        public Lice liceOdgovor { get; set; }
        [DataMember]
        public List<Lice> liceOdgovorList { get; set; }
        [DataMember]
        public string poruka { get; set; }

    }

    [DataContract]
    public class DTOFizicko
    { 
        [DataMember]
        public Fizicko fizickoZahtev { get; set; }
        [DataMember]
        public Fizicko fizickoOdgovor { get; set; }
        [DataMember]
        public List<Fizicko> fizickoOdgovorList { get; set; }
        [DataMember]
        public string poruka { get; set; }
    
    }

    [DataContract]
    public class DTOPravno
    {
        [DataMember]
        public Pravno pravnoZahtev { get; set; }
        [DataMember]
        public Pravno pravnoOdgovor { get; set; }
        [DataMember]
        public List<Pravno> pravnoOdgovorList { get; set; }
        [DataMember]
        public string poruka { get; set; }

    }

    [DataContract]
    public class DTOMesto
    {
        [DataMember]
        public Mesto mestoZahtev { get; set; }
        [DataMember]
        public Mesto mestoOdgovor { get; set; }
        [DataMember]
        public List<Mesto> mestoOdgovorList { get; set; }
        [DataMember]
        public string poruka { get; set; }

    }

    [KnownType(typeof(Resenje))]
    [DataContract]
    public class DTOOglas
    {
        [DataMember]
        public Oglas oglasZahtev { get; set; }
        [DataMember]
        public Oglas oglasOdgovor { get; set; }
        [DataMember]
        public List<Oglas> oglasOdgovorList { get; set; }
        [DataMember]
        public string poruka { get; set; }

    }
  
    [DataContract]    
    public class DTOResenje
    {
        [DataMember]
        public Resenje resenjeZahtev { get; set; }
        [DataMember]
        public Resenje resenjeOdgovor { get; set; }
        [DataMember]
        public List<Resenje> resenjeOdgovorList { get; set; }
        [DataMember]
        public string poruka { get; set; }
    
    }
    
    [DataContract]
    [KnownType(typeof(PrijavaPravno))]
    [KnownType(typeof(PrijavaFizicko))]
    public class DTONadmetanje
    {
        [DataMember]
        public Nadmetanje nadmetanjeZahtev { get; set; }
        [DataMember]
        public Nadmetanje nadmetanjeOdgovor { get; set; }
        [DataMember]
        public List<Nadmetanje> nadmetanjeOdgovorList { get; set; }
        [DataMember]
        public string poruka { get; set; }
    
    }

    [DataContract]
    [KnownType(typeof(PrijavaPravno))]
    [KnownType(typeof(PrijavaFizicko))]
    public class DTOPrijava
    {
        [DataMember]
        public Prijava prijavaZahtev { get; set; }
        [DataMember]
        public Prijava prijavaOdgovor { get; set; }
        [DataMember]
        public List<Prijava> prijavaOdgovorList { get; set; }
        [DataMember]
        public string poruka { get; set; }

    }

      
    
}
