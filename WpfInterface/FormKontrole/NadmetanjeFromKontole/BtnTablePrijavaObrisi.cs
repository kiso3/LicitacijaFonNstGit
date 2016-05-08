using DomenskeKlase;
using DomenskeKlase.Licitacija;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using WpfInterface3.Form;
using WpfInterface3.KKI;
using WpfInterface3.Panel;
using WpfInterface3.PanelForm.NadmetanjePanelForm;

namespace WpfInterface3.FormKontrole.NadmetanjeFromKontole
{
    class BtnTablePrijavaObrisi : DecoratorForm
    {
        public ButtonPanel buttonPanel;
        public LblRezultatOperacije lblRezultatOperacije;

        public BtnTablePrijavaObrisi(UnosForm unosForm) : base(unosForm)
        {
            this.buttonPanel = new ButtonPanel("Obriši");
            lblRezultatOperacije = new LblRezultatOperacije();
            buttonPanel.Margin = new Thickness(2);
            lblRezultatOperacije.Margin = new Thickness(2);
        }

        public override void SetControler()
        {
            base.SetControler();

            //new TablePrijavaObrisiKontroler(this);

            

            PrijaveZaNadmetanjePanelForm prijaveZaNadmetanjePanelForm = panelForm as PrijaveZaNadmetanjePanelForm;

            buttonPanel.btn.Click += delegate (object sender, RoutedEventArgs e)
            {
                Prijava prijava = (Prijava)prijaveZaNadmetanjePanelForm.TblPrijave.baseDataGrid.SelectedItem;

                if (prijava != null)
                {
                    prikaziPoruku(KKILicitacija.Instance.DeletePrijavaSo(prijava), lblRezultatOperacije);
                    prijaveZaNadmetanjePanelForm.TblPrijave.baseDataGrid.ItemsSource = KKILicitacija.Instance.GetAllPrijavaForNadmetanjeSo(prijaveZaNadmetanjePanelForm.Nadmetanje); 
                }
            };

        }
        public override void SetPanel()
        {
            base.SetPanel();
            if (unosForm.panelForm is PrijaveZaNadmetanjePanelForm)
            {

                PrijaveZaNadmetanjePanelForm prijaveZaNadmetanjePanelForm = unosForm.panelForm as PrijaveZaNadmetanjePanelForm;

                prijaveZaNadmetanjePanelForm.gridBase.Children.Add(buttonPanel);
                Grid.SetColumn(buttonPanel, 2);
                Grid.SetRow(buttonPanel, 4);

                prijaveZaNadmetanjePanelForm.gridBase.Children.Add(lblRezultatOperacije);
                Grid.SetColumn(lblRezultatOperacije, 2);
                Grid.SetRow(lblRezultatOperacije, 5);
            }

        }

        public void prikaziPoruku(String poruka, LblRezultatOperacije lblRezultatOperacije)
        {
            switch (poruka)
            {
                case Konstante.DELETE_PRAVNO_OK:
                    lblRezultatOperacije.Content = Konstante.DELETE_PRAVNO_OK;
                    lblRezultatOperacije.Foreground = new SolidColorBrush(Colors.Green);
                    break;
                case Konstante.DELETE_PRIJAVA_ERROR:
                    lblRezultatOperacije.Content = Konstante.DELETE_PRIJAVA_ERROR;
                    lblRezultatOperacije.Foreground = new SolidColorBrush(Colors.Red);
                    break;
                default:
                    break;

            }
        }
    }
}
