using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfInterface3.Form
{
    abstract class UnosForm
    {
        public UserControl panelForm;

        public UnosForm(UserControl panelForm)
        {
            this.panelForm = panelForm;
        }

        public abstract void SetPanel();

        public abstract void SetControler();

    }
}
