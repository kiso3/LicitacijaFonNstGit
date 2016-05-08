using System.Windows;
using WpfInterface3.Director;
using WpfInterface3.Director.Ucesnik;
using WpfInterface3.KKI;
using WpfInterface3.Panel.Ucesnik;
using WpfInterface3.PanelForm.Ucenik;

namespace WpfInterface3.Form.Ucesnik
{
    abstract class LiceForm : UnosForm
    {
        private LicePanelForm _licePanelForm;
        public LiceForm(LicePanelForm licePanelForm)
            :base(licePanelForm)
        {
            _licePanelForm = licePanelForm;
        }
        public override void SetControler()
        {

            _licePanelForm.cboxMesto.cboxMesto.ItemsSource = KKILicitacija.Instance.GetAllMestoSo();

            _licePanelForm.radioLice.radioFizicko.Checked += delegate (object sender, RoutedEventArgs e)
            {
                FizickoBuilderFormDodaj fizickoFormDodaj = new FizickoBuilderFormDodaj();
                DirectorForm directorForm = new DirectorForm(fizickoFormDodaj);
                KoordinatorForm.vratiKoordinatorForm().postaviFormu(directorForm.Konstrujisi());
            };

            _licePanelForm.radioLice.radioPravno.Checked += delegate (object sender, RoutedEventArgs e)
            {
                PravnoBuilderFormDodaj pravnoFormDodaj = new PravnoBuilderFormDodaj();
                DirectorForm directorForm = new DirectorForm(pravnoFormDodaj);
                KoordinatorForm.vratiKoordinatorForm().postaviFormu(directorForm.Konstrujisi());
            };
        }

        public override void SetPanel()
        {            
            _licePanelForm.radioLice = new RadioLice();
            _licePanelForm.tfLiceId = new TFLiceId();
            _licePanelForm.tfPib = new TFPib();
            _licePanelForm.cboxMesto = new ComboBoxMesto();
            _licePanelForm.tfAdresa = new TFAdresa();
            _licePanelForm.tfTelefon = new TFTelefon();
            _licePanelForm.tfEmail = new TFEmail();

        }

        public LicePanelForm LicePanelForm
        {
            get { return _licePanelForm; }
        }
    }
}
