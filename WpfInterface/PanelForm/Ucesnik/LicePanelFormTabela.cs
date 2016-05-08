using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WpfInterface3.Panel.TablePanel;

namespace WpfInterface3.PanelForm.Ucesnik
{
    class LicePanelFormTabela : UserControl
    {
        protected TblLice _tblLice;

        public Grid gridBase;

        public LicePanelFormTabela()
        {
            gridBase = new Grid();
            this.Content = gridBase;
            postaviGrid();
        }

        public TblLice tblLice
        {
            get { return _tblLice; }
            set
            {
                _tblLice = value;

                gridBase.Children.Add(_tblLice);
                Grid.SetColumn(_tblLice, 0);
                Grid.SetRow(_tblLice, 1);
                Grid.SetColumnSpan(_tblLice, 3);
            }
        }

        protected void postaviGrid()
        {            
            gridBase.Margin = new Thickness(10);
            gridBase.ShowGridLines = false;
            
                //new RowDefinition() { Style = new Style() { TargetType=} };

            for (int i = 0; i < 3; i++)
            {
                gridBase.ColumnDefinitions.Add(new ColumnDefinition()
                {
                    Width = GridLength.Auto
                    
                });
            }

            for (int i = 0; i < 4; i++)
            {
                gridBase.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Auto });
            }
        }
    }
}
