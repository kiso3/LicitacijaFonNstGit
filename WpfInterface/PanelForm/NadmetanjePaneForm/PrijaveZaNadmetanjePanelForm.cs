using DomenskeKlase.LicitacijaPriprema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using WpfInterface3.Panel.NadmetanjePanel;
using WpfInterface3.Panel.TablePanel;

namespace WpfInterface3.PanelForm.NadmetanjePanelForm
{
    class PrijaveZaNadmetanjePanelForm : UserControl
    {
        private Nadmetanje _namdetanje;

        TFBrojOglasa _tfBrojOglasa;
        TFDatumObjave _tfDatumObjave;
        TFMaxPovZakupa _tfMaxPovZakupa;
        TFNadmetanjeOznaka _tfNadmetanjeOznaka;
        TblPrijave _tblPrijave;

        public Grid gridBase;

        public PrijaveZaNadmetanjePanelForm(Nadmetanje nadmetanje)
        {
            _namdetanje = nadmetanje;
            gridBase = new Grid();
            Content = gridBase;
            postaviGrid();
            DataContext = this;
        }

        protected virtual void postaviGrid()
        {
            gridBase.Margin = new Thickness(10);
            gridBase.ShowGridLines = false;
            for (int i = 0; i < 3; i++)
            {
                gridBase.ColumnDefinitions.Add(new ColumnDefinition()
                {
                    Width = GridLength.Auto
                });
            }

            for (int i = 0; i < 6; i++)
            {
                gridBase.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Auto });
            }
        }

        public TFBrojOglasa TFBrojOglasa
        {
            get { return _tfBrojOglasa; }
            set
            {
                _tfBrojOglasa = value;
                _tfBrojOglasa.txtBrojOglasa.DataContext = _namdetanje;
                _tfBrojOglasa.txtBrojOglasa.SetBinding(TextBox.TextProperty,
                                                new Binding("OglasId")
                                                {
                                                    Source = _namdetanje.Oglas,
                                                    Mode = BindingMode.TwoWay
                                                }
                                            );

                gridBase.Children.Add(_tfBrojOglasa);
                Grid.SetColumn(_tfBrojOglasa, 0);
                Grid.SetRow(_tfBrojOglasa, 1);

            }
        }

        public TFDatumObjave TFDatumObjave
        {
            get { return _tfDatumObjave; }
            set
            {
                _tfDatumObjave = value;
                _tfDatumObjave.txtDatumObjave.SetBinding(TextBox.TextProperty,
                                                new Binding("DatumObjave")
                                                {
                                                    Source = _namdetanje.Oglas,
                                                    Mode = BindingMode.TwoWay
                                                }
                                            );

                gridBase.Children.Add(_tfDatumObjave);
                Grid.SetColumn(_tfDatumObjave, 1);
                Grid.SetRow(_tfDatumObjave, 1);

            }
        }

        public TFMaxPovZakupa TFMaxPovZakupa
        {
            get { return _tfMaxPovZakupa; }
            set
            {
                _tfMaxPovZakupa = value;
                _tfMaxPovZakupa.txtMaxPovZakupa.SetBinding(TextBox.TextProperty,
                                                new Binding("MaxpovZakupa")
                                                {
                                                    Source = _namdetanje.Oglas,
                                                    Mode = BindingMode.TwoWay
                                                }
                                            );

                gridBase.Children.Add(_tfMaxPovZakupa);
                Grid.SetColumn(_tfMaxPovZakupa, 0);
                Grid.SetRow(_tfMaxPovZakupa, 2);

            }
        }


        public TFNadmetanjeOznaka TFNadmetanjeOznaka
        {
            get { return _tfNadmetanjeOznaka; }
            set
            {
                _tfNadmetanjeOznaka = value;
                _tfNadmetanjeOznaka.txtNadmetajeOznaka.SetBinding(TextBox.TextProperty,
                                                new Binding("OznakaNadmetanja")
                                                {
                                                    Source = _namdetanje,
                                                    Mode = BindingMode.TwoWay
                                                }
                                            );

                gridBase.Children.Add(_tfNadmetanjeOznaka);
                Grid.SetColumn(_tfNadmetanjeOznaka, 1);
                Grid.SetRow(_tfNadmetanjeOznaka, 2);

            }
        }

        public TblPrijave TblPrijave
        {
            get { return _tblPrijave; }
            set
            {
                _tblPrijave = value;


                gridBase.Children.Add(_tblPrijave);
                Grid.SetColumn(_tblPrijave, 0);
                Grid.SetRow(_tblPrijave, 3);
                Grid.SetColumnSpan(_tblPrijave, 3);
            }
        }

        public Nadmetanje Nadmetanje
        {
            get { return _namdetanje; }
        }
    }
}
