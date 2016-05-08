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
    class PrijavaFizickoPanelForm : PrijavaPanelForm
    {
        private PrijavaFizicko _prijavaFizicko;

        private FizickoPanelForm _fizickoPanelForm;
        private CBoxLicnaKarta _cboxLicnaKarta;
        private CBoxDokazOGranZemlj _cboxDokazOGranZemlj;

        public PrijavaFizickoPanelForm(PrijavaFizicko prijavaFizicko) : base(prijavaFizicko)
        {
            _prijavaFizicko = prijavaFizicko;            
            postaviGrid();
            
            
        }

        public FizickoPanelForm FizickoPanelForm
        {
            get { return _fizickoPanelForm; }
            set
            {
                _fizickoPanelForm = value;

                gridBase.Children.Add(_fizickoPanelForm);
                Grid.SetColumn(_fizickoPanelForm, 0);
                Grid.SetRow(_fizickoPanelForm, 1);

            }
        }
        public CBoxLicnaKarta CBoxLicnaKarta
        {
            get { return _cboxLicnaKarta; }
            set
            {
                _cboxLicnaKarta = value;
                _cboxLicnaKarta.cboxRegPoljGazd.SetBinding(CheckBox.IsCheckedProperty,
                            new Binding("LicnaKarta")
                            {
                                Source = _prijavaFizicko,
                                Mode = BindingMode.TwoWay
                            }
                        );


                gridBase.Children.Add(_cboxLicnaKarta);
                Grid.SetColumn(_cboxLicnaKarta, 0);
                Grid.SetRow(_cboxLicnaKarta, 8);
            }
        }

        public CBoxDokazOGranZemlj CBoxDokazOGranZemlj
        {
            get { return _cboxDokazOGranZemlj; }
            set
            {
                _cboxDokazOGranZemlj = value;
                _cboxDokazOGranZemlj.cboxDokazOVlasnistvu.SetBinding(CheckBox.IsCheckedProperty,
                            new Binding("DokazOGranicnomZemljistu")
                            {
                                Source = _prijavaFizicko,
                                Mode = BindingMode.TwoWay
                            }
                        );


                gridBase.Children.Add(_cboxDokazOGranZemlj);
                Grid.SetColumn(_cboxDokazOGranZemlj, 0);
                Grid.SetRow(_cboxDokazOGranZemlj, 9);
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

        public PrijavaFizicko PrijavaFizicko
        {
            get { return _prijavaFizicko; }
        }

    }
}
