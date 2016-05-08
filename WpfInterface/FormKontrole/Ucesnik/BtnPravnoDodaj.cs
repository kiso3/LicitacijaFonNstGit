using DomenskeKlase;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using WpfInterface3.Form;
using WpfInterface3.KKI;
using WpfInterface3.Panel;
using WpfInterface3.PanelForm.Ucesnik;

namespace WpfInterface3.FormKontrole.Ucesnik
{
    class BtnPravnoDodaj : DecoratorForm
    {
        public ButtonPanel buttonPanel;
        public LblRezultatOperacije lblRezultatOperacije;

        public BtnPravnoDodaj(UnosForm unosForm) : base(unosForm)
        {
            buttonPanel = new ButtonPanel("Dodaj");
            lblRezultatOperacije = new LblRezultatOperacije();
            buttonPanel.Margin = new Thickness(2);
            lblRezultatOperacije.Margin = new Thickness(2);
        }

        public override void SetControler()
        {
            base.SetControler();

            //new KontrolerBtnLicePravnoDodaj(this);            
            PravnoPanelForm pravnoPanelForm = panelForm as PravnoPanelForm;
            buttonPanel.btn.Click += delegate (object sender, RoutedEventArgs e)
            {
                prikaziPoruku(KKILicitacija.Instance.AzurirajPravnoSo(pravnoPanelForm.Pravno), lblRezultatOperacije);
            };
        }
        public override void SetPanel()
        {
            base.SetPanel();
            if (unosForm.panelForm is PravnoPanelForm)
            {
                PravnoPanelForm pravnoPanelForm = unosForm.panelForm as PravnoPanelForm;
                pravnoPanelForm.gridBase.Children.Add(buttonPanel);
                Grid.SetColumn(buttonPanel, 0);
                Grid.SetRow(buttonPanel, 7);

                pravnoPanelForm.gridBase.Children.Add(lblRezultatOperacije);
                Grid.SetColumn(lblRezultatOperacije, 1);
                Grid.SetRow(lblRezultatOperacije, 7);
            }

        }

        public void prikaziPoruku(String poruka, LblRezultatOperacije lblRezultatOperacije)
        {

            switch (poruka)
            {
                case Konstante.INSERT_PRAVNO_OK:
                    lblRezultatOperacije.Content = Konstante.INSERT_PRAVNO_OK;
                    lblRezultatOperacije.Foreground = new SolidColorBrush(Colors.Green);
                    break;
                case Konstante.INSERT_PRAVNO_ERROR:
                    lblRezultatOperacije.Content = Konstante.INSERT_PRAVNO_ERROR;
                    lblRezultatOperacije.Foreground = new SolidColorBrush(Colors.Red);
                    break;
                default:
                    break;
            }
        }

    }
}
