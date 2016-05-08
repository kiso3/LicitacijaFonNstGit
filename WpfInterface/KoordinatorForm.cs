using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WpfInterface3;

namespace WpfInterface3
{
    class KoordinatorForm
    {
        private static KoordinatorForm koordinatorForm;
        MainWindow mainWindow;

        private KoordinatorForm() {
            mainWindow = new MainWindow();
        }

        public static KoordinatorForm vratiKoordinatorForm()
        {
            if (koordinatorForm == null)
            {
                koordinatorForm = new KoordinatorForm();
            }
                return koordinatorForm;
            
        }

        public void postaviFormu(UserControl usercontrol)
        {
            mainWindow.postaviAktivnuFormu(usercontrol);
        }

        public UIElementCollection vratiAktivnuFormu()
        {
            return mainWindow.vatiAktivnuFormu();
        }
    }
}
