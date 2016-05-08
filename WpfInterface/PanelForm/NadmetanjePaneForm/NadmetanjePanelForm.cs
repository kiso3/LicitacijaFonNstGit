using DomenskeKlase.LicitacijaPriprema;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    class NadmetanjePanelForm : UserControl
    {
        private Resenje _resenje;


        protected TblNadmetanje _tblNadmetanje;

        ComboBoxNadmetanjeZaGodinu _cBoxNadmetanjeZaGodinu;
        TFBrojOglasa _tfBrojOglasa;
        TFDatumObjave _tfDatumObjave;
        TFMaxPovZakupa _tfMaxPovZakupa;

        public Grid gridBase;
        
        public NadmetanjePanelForm(Resenje resenje)
        {
            _resenje = resenje;
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

        public Resenje Resenje
        {
            get { return _resenje; }
            set
            {
                _resenje = value;
                
            }
        }

        public ComboBoxNadmetanjeZaGodinu CBoxNadmetanjeZaGodinu
        {
            get { return _cBoxNadmetanjeZaGodinu; }
            set
            {
                _cBoxNadmetanjeZaGodinu = value;

                
                _cBoxNadmetanjeZaGodinu.cboxNadmetanjeZaGodinu.SetBinding(
                    ComboBox.SelectedValueProperty,
                    new Binding("DatumObjave")
                    {
                        Source = _resenje.Oglas,                        
                        Mode = BindingMode.TwoWay
                    });
                    

                gridBase.Children.Add(_cBoxNadmetanjeZaGodinu);
                Grid.SetColumn(_cBoxNadmetanjeZaGodinu, 0);
                Grid.SetRow(_cBoxNadmetanjeZaGodinu, 0);
            }

        }
            
        public TFBrojOglasa TFBrojOglasa
        {
            get { return _tfBrojOglasa; }
            set
            {
                _tfBrojOglasa = value;
               _tfBrojOglasa.txtBrojOglasa.DataContext = _resenje;
                _tfBrojOglasa.txtBrojOglasa.SetBinding(TextBox.TextProperty,
                                                new Binding("OglasId")
                                                {
                                                    Source = _resenje.Oglas,
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
                                                    Source = _resenje.Oglas,
                                                    StringFormat = "dd-MM-yyyy",
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
                                                    Source = _resenje.Oglas,
                                                    Mode = BindingMode.TwoWay
                                                }
                                            );

                gridBase.Children.Add(_tfMaxPovZakupa);
                Grid.SetColumn(_tfMaxPovZakupa, 0);
                Grid.SetRow(_tfMaxPovZakupa, 2);

            }
        }

        public TblNadmetanje TblNadmetanje
        {
            get { return _tblNadmetanje; }
            set
            {
                _tblNadmetanje = value;


                gridBase.Children.Add(_tblNadmetanje);
                Grid.SetColumn(_tblNadmetanje, 0);
                Grid.SetRow(_tblNadmetanje, 3);
                Grid.SetColumnSpan(_tblNadmetanje, 3);
            }
        }


    }
}
