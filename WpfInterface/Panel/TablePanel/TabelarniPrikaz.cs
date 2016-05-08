using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace WpfInterface3.Panel.TablePanel
{
    abstract class TabelarniPrikaz : UserControl
    {
        protected CollectionViewSource itemCollectionViewSource;
        public DataGrid baseDataGrid;
        Grid gridBase;

        public TabelarniPrikaz()
        {
            kreirajKomponente();
            postaviKomponentu();
            this.Content = gridBase;
        }

        protected virtual void kreirajKomponente()
        {
            gridBase = new Grid();
            itemCollectionViewSource = new CollectionViewSource();
            baseDataGrid = new DataGrid();
        }

        protected virtual void postaviKomponentu()
        {
            gridBase.ColumnDefinitions.Add(new ColumnDefinition()
            {
                Width = GridLength.Auto
            });

            gridBase.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Auto });

            gridBase.Children.Add(baseDataGrid);
            Grid.SetColumn(baseDataGrid, 0);
            Grid.SetRow(baseDataGrid, 0);
        }

        protected abstract void addColumn();
        
        public void SetMinWidths(object source, EventArgs e)
        {
            double maxTableWidth = 0;
            foreach (var column in baseDataGrid.Columns)
            {
                column.MinWidth = column.ActualWidth;
                column.Width = new DataGridLength(1, DataGridLengthUnitType.Star);
                maxTableWidth += column.MinWidth;
            }            
        }
    }
}
