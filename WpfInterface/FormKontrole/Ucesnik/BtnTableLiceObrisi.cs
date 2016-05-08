using DomenskeKlase;
using DomenskeKlase.Ucenik;
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
    class BtnTableLiceObrisi : DecoratorForm
    {
        public ButtonPanel buttonPanel;
        public LblRezultatOperacije lblRezultatOperacije;
        public BtnTableLiceObrisi(UnosForm unosForm) : base(unosForm)
        {
            buttonPanel = new ButtonPanel("Obriši");
            lblRezultatOperacije = new LblRezultatOperacije();
            buttonPanel.Margin = new Thickness(2);
            lblRezultatOperacije.Margin = new Thickness(2);
        }

        public override void SetControler()
        {
            base.SetControler();
            //new KontrolerBtnTableLiceObrisi(this);

            
            
            buttonPanel.btn.Click += delegate (object sender, RoutedEventArgs e)
            {
                LicePanelFormTabela licePanelFormTabela = panelForm as LicePanelFormTabela;
                Lice lice = (Lice)licePanelFormTabela.tblLice.baseDataGrid.SelectedItem;

                if (lice != null)
                {
                    prikaziPoruku(KKILicitacija.Instance.DeleteLiceSo(lice), lblRezultatOperacije);
                    licePanelFormTabela.tblLice.baseDataGrid.ItemsSource = KKILicitacija.Instance.GetAllLiceSo();
                }
            };
        }
        public override void SetPanel()
        {
            base.SetPanel();
            if (unosForm.panelForm is LicePanelFormTabela)
            {
                LicePanelFormTabela licePanelFormTabela = unosForm.panelForm as LicePanelFormTabela;

                licePanelFormTabela.gridBase.Children.Add(buttonPanel);
                Grid.SetColumn(buttonPanel, 2);
                Grid.SetRow(buttonPanel, 2);

                licePanelFormTabela.gridBase.Children.Add(lblRezultatOperacije);
                Grid.SetColumn(lblRezultatOperacije, 2);
                Grid.SetRow(lblRezultatOperacije, 3);
            }

        }

        public void prikaziPoruku(String poruka, LblRezultatOperacije lblRezultatOperacije)
        {
            switch (poruka)
            {
                case Konstante.DELETE_LICE_OK:
                    lblRezultatOperacije.Content = Konstante.DELETE_LICE_OK;
                    lblRezultatOperacije.Foreground = new SolidColorBrush(Colors.Green);
                    break;
                case Konstante.DELETE_LICE_ERROR:
                    lblRezultatOperacije.Content = Konstante.DELETE_LICE_ERROR;
                    lblRezultatOperacije.Foreground = new SolidColorBrush(Colors.Red);
                    break;
                default:
                    break;

            }
        }
    }
}
