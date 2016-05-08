using DomenskeKlase.Ucenik;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using WpfInterface3.Panel.Ucesnik;
using WpfInterface3.PanelForm.Ucenik;

namespace WpfInterface3.PanelForm.Ucesnik
{
    class PravnoPanelForm : LicePanelForm
    {
        private Pravno _pravno;

        TFMb _tfMb;
        TFNaziv _tfNaziv;

        public PravnoPanelForm(Pravno pravno) : base(pravno)
        {
            this._pravno = pravno;
            postaviGrid();
        }

        public TFMb tfMb
        {
            get { return _tfMb; }
            set
            {
                _tfMb = value;
                _tfMb.txtMb.SetBinding(TextBox.TextProperty,
                             new Binding("Mb")
                             {
                                 Source = _pravno,
                                 Mode = BindingMode.TwoWay
                             }
                         );


                gridBase.Children.Add(_tfMb);
                Grid.SetColumn(_tfMb, 0);
                Grid.SetRow(_tfMb, 3);
            }

        }

        public TFNaziv tfNaziv
        {
            get { return _tfNaziv; }
            set
            {
                _tfNaziv = value;
                _tfNaziv.txtNaziv.SetBinding(TextBox.TextProperty,
                             new Binding("Naziv")
                             {
                                 Source = _pravno,
                                 Mode = BindingMode.TwoWay
                             }
                         );


                gridBase.Children.Add(_tfNaziv);
                Grid.SetColumn(_tfNaziv, 0);
                Grid.SetRow(_tfNaziv, 4);
            }

        }

        public Pravno Pravno
        {
            get { return _pravno; }
        }
    }
}
