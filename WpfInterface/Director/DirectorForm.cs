using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfInterface3.Director
{
    class DirectorForm
    {
        BuilderForm builderForm;

        public DirectorForm(BuilderForm builderForm)
        {
            this.builderForm = builderForm;
        }
        public UserControl Konstrujisi()
        {
            builderForm.KreirajFormu();            
            return builderForm.GetResult();
        }
    }
}
