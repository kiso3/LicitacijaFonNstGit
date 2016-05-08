using DomenskeKlase.Ucenik;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using WpfInterface3.Panel.Ucesnik;

namespace WpfInterface3.PanelForm.Ucenik
{
    abstract class LicePanelForm : UserControl
    {
        private Lice _lice;

        public Grid gridBase;

        RadioLice _radioLice;
        TFLiceId _tfLiceId;
        TFPib _tfPib;
        ComboBoxMesto _cboxMesto;
        TFAdresa _tfAdresa;
        TFTelefon _tfTelefon;
        TFEmail _tfEmail;

        public LicePanelForm(Lice lice)
        {
            _lice = lice;
            gridBase = new Grid();
            Content = gridBase;
            postaviGrid();
            DataContext = this;   
        }

        public RadioLice radioLice
        {
            get { return _radioLice; }
            set
            {
                _radioLice = value;
                //_cboxMesto.cboxMesto.DataContext = lice.Mesto.Naziv;

                gridBase.Children.Add(_radioLice);
                Grid.SetColumn(_radioLice, 0);
                Grid.SetRow(_radioLice, 0);
                Grid.SetColumnSpan(_radioLice, 2);
            }
        }

        public TFLiceId tfLiceId
        {
            get { return _tfLiceId; }
            set
            {
                _tfLiceId = value;
                _tfLiceId.txtLiceId.SetBinding(TextBox.TextProperty,
                            new Binding("LiceId")
                            {
                                Source = _lice,
                                Mode = BindingMode.TwoWay
                            }
                        );


                gridBase.Children.Add(_tfLiceId);
                Grid.SetColumn(_tfLiceId, 0);
                Grid.SetRow(_tfLiceId, 1);
            }
        }

        public ComboBoxMesto cboxMesto
        {
            get { return _cboxMesto; }
            set
            {
                _cboxMesto = value;
                
                _cboxMesto.cboxMesto.SetBinding(ComboBox.SelectedItemProperty,
                        new Binding("Mesto")
                        {
                            Source = _lice,
                            Mode = BindingMode.TwoWay
                        }
                    );

                gridBase.Children.Add(_cboxMesto);
                Grid.SetColumn(_cboxMesto, 1);
                Grid.SetRow(_cboxMesto, 2);

                //Selektuj Mesto u ComboBox panelu
                _cboxMesto.cboxMesto.Loaded += delegate (object sender, RoutedEventArgs e)
                {
                    var list = _cboxMesto.cboxMesto.ItemsSource;
                    int i = 0;
                    foreach (var item in list)
                    {
                        if(_lice.Mesto != null && _lice.Mesto.MestoId == ((Mesto)item).MestoId)
                        {
                            _cboxMesto.cboxMesto.SelectedIndex = i;
                            return;
                        }
                        i++;
                    }
                };
            }
        }

        public TFPib tfPib
        {
            get { return _tfPib; }
            set
            {
                _tfPib = value;                
                _tfPib.txtPib.SetBinding(TextBox.TextProperty, 
                                            new Binding("Pib")
                                            {
                                                Source = _lice,
                                                Mode = BindingMode.TwoWay                                            
                                            }
                                        );

                gridBase.Children.Add(_tfPib);
                Grid.SetColumn(_tfPib, 0);
                Grid.SetRow(_tfPib, 2);
            }
        }

        public TFAdresa tfAdresa
        {
            get { return _tfAdresa; }
            set
            {
                _tfAdresa = value;
                _tfAdresa.txtAdresa.SetBinding(TextBox.TextProperty,
                                                new Binding("Adresa")
                                                {
                                                    Source = _lice,
                                                    Mode = BindingMode.TwoWay
                                                }
                                            );

                gridBase.Children.Add(_tfAdresa);
                Grid.SetColumn(_tfAdresa, 1);
                Grid.SetRow(_tfAdresa, 3);
            }
        }

        public TFTelefon tfTelefon
        {
            get { return _tfTelefon; }
            set
            {
                _tfTelefon = value;
                _tfTelefon.txtTelefon.SetBinding(TextBox.TextProperty,
                                 new Binding("Telefon")
                                 {
                                     Source = _lice,
                                     Mode = BindingMode.TwoWay
                                 }
                             );

                gridBase.Children.Add(_tfTelefon);
                Grid.SetColumn(_tfTelefon, 1);
                Grid.SetRow(_tfTelefon, 4);
            }
        }

        public TFEmail tfEmail
        {
            get { return _tfEmail; }
            set
            {
                _tfEmail = value;
                _tfEmail.txtEmail.SetBinding(TextBox.TextProperty,
                                             new Binding("Email")
                                             {
                                                 Source = _lice,
                                                 Mode = BindingMode.TwoWay
                                             }
                                         );

                gridBase.Children.Add(_tfEmail);
                Grid.SetColumn(_tfEmail, 1);
                Grid.SetRow(_tfEmail, 5);
            }
        }

        public Lice Lice
        {
            get {return _lice; }

        }
        protected virtual void postaviGrid()
        {
            gridBase.Margin = new Thickness(10);
            gridBase.ShowGridLines = false;
            for (int i = 0; i < 2; i++)
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

        public void DisableRadioLice()
        {
            _radioLice.radioFizicko.IsEnabled = false;
            _radioLice.radioPravno.IsEnabled = false;
        }
    }
}
