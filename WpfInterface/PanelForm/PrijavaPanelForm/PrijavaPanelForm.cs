using DomenskeKlase.Licitacija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using WpfInterface3.Panel.PrijavaPanel;
using WpfInterface3.PanelForm.Ucenik;

namespace WpfInterface3.PanelForm.PrijavaPanelForm
{
    abstract class PrijavaPanelForm : UserControl
    {
        private Prijava _prijava;


        
        private RBtnObilazakZemlj _rbtnObilazakZemlj;
        private DatePickerDatumObilaska _datePickerDatumObilaska;
        private CBoxRegPoljGazd _cboxRegPoljGazd;       
        private CBoxDokazOVlasnistvu _cboxDokazOVlasnistvu;
        private CBoxResenjePio _cboxResenjePio;
        private CBoxDepozit _cbDepozit;

        public Grid gridBase;
        
        public PrijavaPanelForm(Prijava prijava)
        {
            _prijava = prijava;
            gridBase = new Grid();
            Content = gridBase;
            postaviGrid();
            DataContext = this;
            
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
        public RBtnObilazakZemlj RBtnObilazakZemlj
        {
            get { return _rbtnObilazakZemlj; }
            set
            {
                _rbtnObilazakZemlj = value;

                _rbtnObilazakZemlj.RBtnNisamObisaoZelj.SetBinding(RadioButton.IsCheckedProperty,
                          new Binding("Obisao")
                          {                                           
                              Source = _prijava,
                              Converter = new KonverterObilazakZemljista(),
                              Mode = BindingMode.TwoWay
                           }
                        );
                
                _rbtnObilazakZemlj.RBtnObisaoZelj.SetBinding(RadioButton.IsCheckedProperty,
                  new Binding("Obisao")
                  {                    
                    Source = _prijava,
                      Converter = new BoolConverter(),
                      Mode = BindingMode.OneWay
                  }
                );
                
                gridBase.Children.Add(_rbtnObilazakZemlj);
                Grid.SetColumn(_rbtnObilazakZemlj, 0);
                Grid.SetRow(_rbtnObilazakZemlj, 3);

            }
        }

        public DatePickerDatumObilaska DatePickerDatumObilaska
        {
            get
            {
                return _datePickerDatumObilaska;
            }
            set
            {
                _datePickerDatumObilaska = value;
                _datePickerDatumObilaska.dpDatumObilaska.SetBinding(DatePicker.SelectedDateProperty,
                    new Binding("DatumObilaska")
                    {
                        Source = _prijava,
                        Mode = BindingMode.TwoWay
                    });

                gridBase.Children.Add(_datePickerDatumObilaska);
                Grid.SetColumn(_datePickerDatumObilaska, 0);
                Grid.SetRow(_datePickerDatumObilaska, 2);
            }
        }

        public CBoxRegPoljGazd CBoxRegPoljGazd
        {
            get { return _cboxRegPoljGazd; }
            set
            {
                _cboxRegPoljGazd = value;
                _cboxRegPoljGazd.cboxRegPoljGazd.SetBinding(CheckBox.IsCheckedProperty,
                            new Binding("RegistarPoljGazd")
                            {
                                Source = _prijava,
                                Mode = BindingMode.TwoWay
                            }
                        );


                gridBase.Children.Add(_cboxRegPoljGazd);
                Grid.SetColumn(_cboxRegPoljGazd, 0);
                Grid.SetRow(_cboxRegPoljGazd, 4);
            }
        }

        public CBoxDokazOVlasnistvu CBoxDokazOVlasnistvu
        {
            get { return _cboxDokazOVlasnistvu; }
            set
            {
                _cboxDokazOVlasnistvu = value;
                _cboxDokazOVlasnistvu.cboxDokazOVlasnistvu.SetBinding(CheckBox.IsCheckedProperty,
                            new Binding("DokazOVlasnistvu")
                            {
                                Source = _prijava,
                                Mode = BindingMode.TwoWay
                            }
                        );


                gridBase.Children.Add(_cboxDokazOVlasnistvu);
                Grid.SetColumn(_cboxDokazOVlasnistvu, 0);
                Grid.SetRow(_cboxDokazOVlasnistvu, 5);
            }
        }

        public CBoxResenjePio CBoxResenjePio
        {
            get { return _cboxResenjePio; }
            set
            {
                _cboxResenjePio = value;
                _cboxResenjePio.cboxResenjePio.SetBinding(CheckBox.IsCheckedProperty,
                            new Binding("ResenjePio")
                            {
                                Source = _prijava,
                                Mode = BindingMode.TwoWay
                            }
                        );


                gridBase.Children.Add(_cboxResenjePio);
                Grid.SetColumn(_cboxResenjePio, 0);
                Grid.SetRow(_cboxResenjePio, 6);
            }
        }

        public CBoxDepozit CBDepozit
        {
            get { return _cbDepozit; }
            set
            {
                _cbDepozit = value;
                _cbDepozit.cboxDokazOVlasnistvu.SetBinding(CheckBox.IsCheckedProperty,
                            new Binding("DokazOUplatiDepozita")
                            {
                                Source = _prijava,
                                Mode = BindingMode.TwoWay
                            }
                        );


                gridBase.Children.Add(_cbDepozit);
                Grid.SetColumn(_cbDepozit, 0);
                Grid.SetRow(_cbDepozit, 7);
            }
        }

        public Prijava Prijava
        {
            get { return _prijava; }
        }

    }
}
