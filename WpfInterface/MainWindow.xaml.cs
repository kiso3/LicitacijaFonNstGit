using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfInterface3.Director;
using WpfInterface3.Director.NadmetanjeDirector;
using WpfInterface3.Director.Ucesnik;
using WpfInterface3.FormKontrole;
using WpfInterface3.Panel;
using WpfInterface3.Panel.Ucesnik;

namespace WpfInterface3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Show();
            
        }

        internal UIElementCollection vatiAktivnuFormu()
        {
            return mainGrid.Children;
        }

        public void postaviAktivnuFormu(UserControl usercontol)
        {

            mainGrid.Children.Clear();
            mainGrid.Children.Add(usercontol);      
        }
        private void MenuItemNoviPonudjac_Click(object sender, RoutedEventArgs e)
        {
            FizickoBuilderFormDodaj fizickoFormDodaj = new FizickoBuilderFormDodaj();
            DirectorForm directorForm = new DirectorForm(fizickoFormDodaj);
            KoordinatorForm.vratiKoordinatorForm().postaviFormu(directorForm.Konstrujisi());
        }

        private void MenuItemSviPonudjac_Click(object sender, RoutedEventArgs e)
        {

            LiceFormTableBuilderIzmeni liceFormTableBuilderIzmeni = new LiceFormTableBuilderIzmeni();
            DirectorForm directorForm = new DirectorForm(liceFormTableBuilderIzmeni);
            KoordinatorForm.vratiKoordinatorForm().postaviFormu(directorForm.Konstrujisi());
        }

        private void MenuItemNoviOglasi_Click(object sender, RoutedEventArgs e)
        {
            NadmetanjeTableFormBuilderPrikaz nadmetanjeTableFormBuilderPrikaz = new NadmetanjeTableFormBuilderPrikaz();
            DirectorForm directorForm = new DirectorForm(nadmetanjeTableFormBuilderPrikaz);
            KoordinatorForm.vratiKoordinatorForm().postaviFormu(directorForm.Konstrujisi());
        }
    }
}
