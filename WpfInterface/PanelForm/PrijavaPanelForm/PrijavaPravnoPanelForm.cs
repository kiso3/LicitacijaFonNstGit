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
using WpfInterface3.PanelForm.Ucesnik;

namespace WpfInterface3.PanelForm.PrijavaPanelForm
{
    class PrijavaPravnoPanelForm : PrijavaPanelForm
    {
        private PrijavaPravno _prijavaPravno;

        private PravnoPanelForm _pravnoPanelForm;        
        private CBoxPrivredniRegistar _cboxPrivredniRegistar;

        public PrijavaPravnoPanelForm(PrijavaPravno prijavaPravno) : base(prijavaPravno)
        {
            _prijavaPravno = prijavaPravno;
            postaviGrid();


        }

        public PravnoPanelForm PravnoPanelForm
        {
            get { return _pravnoPanelForm; }
            set
            {
                _pravnoPanelForm = value;

                gridBase.Children.Add(_pravnoPanelForm);
                Grid.SetColumn(_pravnoPanelForm, 0);
                Grid.SetRow(_pravnoPanelForm, 1);

            }
        }
        public CBoxPrivredniRegistar CBoxPrivredniRegistar
        {
            get { return _cboxPrivredniRegistar; }
            set
            {
                _cboxPrivredniRegistar = value;
                _cboxPrivredniRegistar.cboxDokazOVlasnistvu.SetBinding(CheckBox.IsCheckedProperty,
                            new Binding("IzvodizprivrednogRegistra")
                            {
                                Source = _prijavaPravno,
                                Mode = BindingMode.TwoWay
                            }
                        );


                gridBase.Children.Add(_cboxPrivredniRegistar);
                Grid.SetColumn(_cboxPrivredniRegistar, 0);
                Grid.SetRow(_cboxPrivredniRegistar, 8);
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

        public PrijavaPravno PrijavaPravno
        {
            get { return _prijavaPravno; }
        }
    }
}
