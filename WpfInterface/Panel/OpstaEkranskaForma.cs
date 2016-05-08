using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfInterface3.Panel
{
    public abstract class OpstaEkranskaForma : UserControl
    {
        public abstract Object KreirajObjekat();
        protected object obj;

    }
}
