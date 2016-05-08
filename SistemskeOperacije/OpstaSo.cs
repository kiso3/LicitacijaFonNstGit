using System;
using Broker.LicitacijaDBContext;
using System.Runtime.CompilerServices;

namespace SistemskeOperacije
{
    public abstract class OpstaSo<TEntity>
    {

        protected LicitacijaDBContext licitacijaDBContext;

        public OpstaSo()
        {           
            licitacijaDBContext = LicitacijaDBContext.getInstance();
        }

    [MethodImpl(MethodImplOptions.Synchronized)]
     public void IzvrsiSo(TEntity entity)       
       {
           try
           {
               proveriPreduslov(entity);
               izvrsiKonkretnuOperaciju(entity);
           }
           catch (Exception e)
           {
               
               throw e;
           }
           
       }

       protected abstract void izvrsiKonkretnuOperaciju(TEntity entity);


       protected abstract void proveriPreduslov(TEntity entity);

    }
}
