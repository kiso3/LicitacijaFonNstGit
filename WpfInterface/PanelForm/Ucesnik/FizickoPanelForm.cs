using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomenskeKlase.Ucenik;
using System.Windows.Controls;
using WpfInterface3.Panel.Ucesnik;
using System.Windows;
using System.Windows.Data;

namespace WpfInterface3.PanelForm.Ucenik
{
    class FizickoPanelForm : LicePanelForm
    {
        private Fizicko _fizicko;
        
        TFJmbg _tfJmbg;
        TFIme _tfIme;
        TFPrezime _tfPrezime;
        TFImeRoditelja _tfImeRoditelja;

        public FizickoPanelForm(Fizicko fizicko) : base(fizicko)
        {
            this._fizicko = fizicko;            
            postaviGrid();            
        }
        public TFJmbg tfJmbg
        {
            get { return _tfJmbg; }
            set
            {
                _tfJmbg = value;
                _tfJmbg.txtJmbg.SetBinding(TextBox.TextProperty,
                                            new Binding("Jmbg")
                                            {
                                                Source = _fizicko,
                                                Mode = BindingMode.TwoWay
                                            }
                                        );


                gridBase.Children.Add(_tfJmbg);
                Grid.SetColumn(_tfJmbg, 0);
                Grid.SetRow(_tfJmbg,3);
            }
        }
        public TFIme tfIme
        {
            get { return _tfIme; }
            set
            {
                _tfIme = value;
                _tfIme.txtIme.SetBinding(TextBox.TextProperty,
                                            new Binding("Ime")
                                            {
                                                Source = _fizicko,
                                                Mode = BindingMode.TwoWay
                                            }
                                        );


                gridBase.Children.Add(_tfIme);
                Grid.SetColumn(_tfIme, 0);
                Grid.SetRow(_tfIme, 4);
            }
        }
        public TFPrezime tfPrezime
        {
            get { return _tfPrezime; }
            set
            {
                _tfPrezime = value;
                _tfPrezime.txtPrezime.SetBinding(TextBox.TextProperty,
                                                    new Binding("Prezime")
                                                    {
                                                        Source = _fizicko,
                                                        Mode = BindingMode.TwoWay
                                                    }
                                                );

                gridBase.Children.Add(_tfPrezime);
                Grid.SetColumn(_tfPrezime, 0);
                Grid.SetRow(_tfPrezime, 6);
            }
        }
        public TFImeRoditelja tfImeRoditelja
        {
            get { return _tfImeRoditelja; }
            set
            {
                _tfImeRoditelja = value;
                _tfImeRoditelja.txtImeRoditelja.SetBinding(TextBox.TextProperty,
                                                    new Binding("ImeRoditelja")
                                                    {
                                                        Source = _fizicko,
                                                        Mode = BindingMode.TwoWay
                                                    }
                                                );

                gridBase.Children.Add(_tfImeRoditelja);
                Grid.SetColumn(_tfImeRoditelja, 0);
                Grid.SetRow(_tfImeRoditelja, 5);
            }
        }
        protected override void postaviGrid()
        {
            base.postaviGrid();
            gridBase.Margin = new Thickness(10);
            gridBase.ShowGridLines = false;
            for (int i = 0; i < 2; i++)
            {
                gridBase.ColumnDefinitions.Add(new ColumnDefinition()
                {
                    Width = GridLength.Auto
                });
            }

            for (int i = 0; i < 3; i++)
            {
                gridBase.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Auto });
            }
        }

        public Fizicko Fizicko
        {
            get { return _fizicko; }
        }
    }
}
