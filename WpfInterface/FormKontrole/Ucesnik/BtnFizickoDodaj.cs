using DomenskeKlase;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using WpfInterface3.Form;
using WpfInterface3.KKI;
using WpfInterface3.Panel;
using WpfInterface3.PanelForm.Ucenik;

namespace WpfInterface3.FormKontrole.Ucesnik
{
    class BtnFizickoDodaj : DecoratorForm
    {
        public ButtonPanel buttonPanel;
        public LblRezultatOperacije lblRezultatOperacije;

        public BtnFizickoDodaj(UnosForm unosForm) : base(unosForm)
        {
            this.buttonPanel = new ButtonPanel("Dodaj");
            lblRezultatOperacije = new LblRezultatOperacije();
            buttonPanel.Margin = new Thickness(2);
            lblRezultatOperacije.Margin = new Thickness(2);
        }

        public override void SetControler()
        {
            base.SetControler();

            //new KontrolerBtnLiceFizikoDodaj(this);
            
            FizickoPanelForm fizickoPanelForm = panelForm as FizickoPanelForm;

            buttonPanel.btn.Click += delegate (object sender, RoutedEventArgs e)
            {
                prikaziPoruku(KKILicitacija.Instance.InsertFizickoSo(fizickoPanelForm.Fizicko), lblRezultatOperacije);
            };


        }
        public override void SetPanel()
        {
            base.SetPanel();
            if (unosForm.panelForm is FizickoPanelForm)
            {
                FizickoPanelForm fizickoPanelForm = unosForm.panelForm as FizickoPanelForm;
                fizickoPanelForm.gridBase.Children.Add(buttonPanel);
                Grid.SetColumn(buttonPanel, 0);
                Grid.SetRow(buttonPanel, 7);

                fizickoPanelForm.gridBase.Children.Add(lblRezultatOperacije);
                Grid.SetColumn(lblRezultatOperacije, 1);
                Grid.SetRow(lblRezultatOperacije, 7);
            }

        }

        public void prikaziPoruku(String poruka, LblRezultatOperacije lblRezultatOperacije)
        {

            switch (poruka)
            {
                case Konstante.INSERT_FIZICKO_OK:
                    lblRezultatOperacije.Content = Konstante.INSERT_FIZICKO_OK;
                    lblRezultatOperacije.Foreground = new SolidColorBrush(Colors.Green);
                    break;
                case Konstante.INSERT_FIZICKO_ERROR:
                    lblRezultatOperacije.Content = Konstante.INSERT_FIZICKO_ERROR;
                    lblRezultatOperacije.Foreground = new SolidColorBrush(Colors.Red);
                    break;
                default:
                    break;
            }
        }

    }
}
