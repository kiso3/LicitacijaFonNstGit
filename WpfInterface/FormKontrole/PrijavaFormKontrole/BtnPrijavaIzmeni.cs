using DomenskeKlase;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using WpfInterface3.Form;
using WpfInterface3.KKI;
using WpfInterface3.Panel;
using WpfInterface3.PanelForm.PrijavaPanelForm;

namespace WpfInterface3.FormKontrole.PrijavaFormKontrole
{
    class BtnPrijavaIzmeni : DecoratorForm
    {
        public ButtonPanel buttonPanel;
        public LblRezultatOperacije lblRezultatOperacije;

        public BtnPrijavaIzmeni(UnosForm unosForm) : base(unosForm)
        {
            this.buttonPanel = new ButtonPanel("Izmeni");
            lblRezultatOperacije = new LblRezultatOperacije();
            buttonPanel.Margin = new Thickness(2);
            lblRezultatOperacije.Margin = new Thickness(2);
        }

        public override void SetControler()
        {            
            base.SetControler();
            //new KontorlerBtnPrijavaIzmeni(this);
                        
            PrijavaPanelForm _prijavaPanelForm = panelForm as PrijavaPanelForm;

            
            buttonPanel.btn.Click += delegate (object sender, RoutedEventArgs e)
            {
                prikaziPoruku(KKILicitacija.Instance.AzurirajPrijavaSo(_prijavaPanelForm.Prijava), lblRezultatOperacije);
            };

        }
        public override void SetPanel()
        {
            base.SetPanel();
            if (unosForm.panelForm is PrijavaPanelForm)
            {
                PrijavaPanelForm prijavaPanelForm = unosForm.panelForm as PrijavaPanelForm;
                prijavaPanelForm.gridBase.Children.Add(buttonPanel);
                Grid.SetColumn(buttonPanel, 0);
                Grid.SetRow(buttonPanel, 10);

                prijavaPanelForm.gridBase.Children.Add(lblRezultatOperacije);
                Grid.SetColumn(lblRezultatOperacije, 0);
                Grid.SetRow(lblRezultatOperacije, 11);
            }

        }

        public void prikaziPoruku(String poruka, LblRezultatOperacije lblRezultatOperacije)
        {

            switch (poruka)
            {
                case Konstante.AZURIAJ_PRIJAVA_OK:
                    lblRezultatOperacije.Content = Konstante.AZURIAJ_FIZICKO_OK;
                    lblRezultatOperacije.Foreground = new SolidColorBrush(Colors.Green);
                    break;
                case Konstante.AZURIAJ_PRIJAVA_ERROR:
                    lblRezultatOperacije.Content = Konstante.AZURIAJ_FIZICKO_ERROR;
                    lblRezultatOperacije.Foreground = new SolidColorBrush(Colors.Red);
                    break;
                default:
                    break;
            }
        }

    }
}
