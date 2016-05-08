using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfInterface3.Director
{
    interface BuilderForm
    {
        void KreirajFormu();

        //void PostaviKontrole();

        UserControl GetResult();
    }
}
