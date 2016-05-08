using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DomenskeKlase.ProstorniPodaci
{
    public class DeoParcele : ProstorniEntitet 
    {
        public int DeoParceleId { get; set; }
        public int ParcelaId { get; set; }
        public int BrojDela { get; set; }
        public NacinKoriscenja NacinKoriscenja { get; set; }
        public int Klasa { get; set; }
        public double KatPrih { get; set; }
        //public Objekat Objekat { get; set; }
        public IList<Objekat> Objekat { get; set; }



        public Parcela Parcela { get; set; }
    }
}
