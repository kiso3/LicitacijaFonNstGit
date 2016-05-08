using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfInterface3.Panel.Ucesnik
{
    class TFEmail : UserControl
    {
        Label lblRmail;
        public TextBox txtEmail;
        Grid gridBase;
        public TFEmail()
        {
            kreirajKomoponentu();
            postaviKomponentu();
            this.Content = gridBase;
        }

        void kreirajKomoponentu()
        {
            this.gridBase = new Grid();
            this.lblRmail = new Label() { Content = "Email:" };
            this.txtEmail = new TextBox() { IsEnabled = true, Text = "" };
        }

        void postaviKomponentu()
        {

            this.txtEmail.Margin = new Thickness(2);

            gridBase.ColumnDefinitions.Add(new ColumnDefinition()
            {
                Width = GridLength.Auto,
                MinWidth = 80,
                MaxWidth = 300
            });
            gridBase.ColumnDefinitions.Add(new ColumnDefinition()
            {
                Width = GridLength.Auto,
                MinWidth = 150,
                MaxWidth = 300

            });

            gridBase.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Auto, MaxHeight = 24 });

            gridBase.Children.Add(lblRmail);
            gridBase.Children.Add(txtEmail);
            Grid.SetColumn(lblRmail, 0);
            Grid.SetRow(lblRmail, 0);
            Grid.SetColumn(txtEmail, 1);
            Grid.SetRow(txtEmail, 0);
        }
    }
}
