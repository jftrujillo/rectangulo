using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Media;

namespace PhoneApp1
{
    public partial class checkbox : PhoneApplicationPage
    {
        public checkbox()
        {
            InitializeComponent();
        }

        private void cambiar(object sender, RoutedEventArgs e)
        {
            if (Rojo.IsChecked == true && Azul.IsChecked == false && Amarillo.IsChecked == false) {
                rectangulo2.Fill = new SolidColorBrush(Colors.Red);            
            }
            if (Rojo.IsChecked == true && Azul.IsChecked == false && Amarillo.IsChecked == true)
            {
                rectangulo2.Fill = new SolidColorBrush(Colors.Orange);
            }
            if (Rojo.IsChecked == true && Azul.IsChecked == true && Amarillo.IsChecked == false)
            {
                rectangulo2.Fill = new SolidColorBrush(Colors.Purple);
            }
            if (Rojo.IsChecked == true && Azul.IsChecked == true && Amarillo.IsChecked == true)
            {
                rectangulo2.Fill = new SolidColorBrush(Colors.Black);
            }
            if (Rojo.IsChecked == false && Azul.IsChecked == false && Amarillo.IsChecked == false)
            {
                rectangulo2.Fill = new SolidColorBrush(Colors.White);

            }
            if (Rojo.IsChecked == false && Azul.IsChecked == false && Amarillo.IsChecked == true)
            {
                rectangulo2.Fill = new SolidColorBrush(Colors.Yellow);
            }
            if (Rojo.IsChecked == false && Azul.IsChecked == true && Amarillo.IsChecked == false)
            {
                rectangulo2.Fill = new SolidColorBrush(Colors.Blue);
            }
            if (Rojo.IsChecked == false && Azul.IsChecked == true && Amarillo.IsChecked == true)
            {
                rectangulo2.Fill = new SolidColorBrush(Colors.Green);
            }
           
        }

        private void cambiar2(object sender, RoutedEventArgs e)
        {
            if (Rojo.IsChecked == true && Azul.IsChecked == false && Amarillo.IsChecked == false)
            {
                rectangulo2.Fill = new SolidColorBrush(Colors.Red);
            }
            if (Rojo.IsChecked == true && Azul.IsChecked == false && Amarillo.IsChecked == true)
            {
                rectangulo2.Fill = new SolidColorBrush(Colors.Orange);
            }
            if (Rojo.IsChecked == true && Azul.IsChecked == true && Amarillo.IsChecked == false)
            {
                rectangulo2.Fill = new SolidColorBrush(Colors.Purple);
            }
            if (Rojo.IsChecked == true && Azul.IsChecked == true && Amarillo.IsChecked == true)
            {
                rectangulo2.Fill = new SolidColorBrush(Colors.Black);
            }
            if (Rojo.IsChecked == false && Azul.IsChecked == false && Amarillo.IsChecked == false)
            {
                rectangulo2.Fill = new SolidColorBrush(Colors.White);

            }
            if (Rojo.IsChecked == false && Azul.IsChecked == false && Amarillo.IsChecked == true)
            {
                rectangulo2.Fill = new SolidColorBrush(Colors.Yellow);
            }
            if (Rojo.IsChecked == false && Azul.IsChecked == true && Amarillo.IsChecked == false)
            {
                rectangulo2.Fill = new SolidColorBrush(Colors.Blue);
            }
            if (Rojo.IsChecked == false && Azul.IsChecked == true && Amarillo.IsChecked == true)
            {
                rectangulo2.Fill = new SolidColorBrush(Colors.Green);
            }
        }

        private void cambiar3(object sender, RoutedEventArgs e)
        {
            if (Rojo.IsChecked == true && Azul.IsChecked == false && Amarillo.IsChecked == false)
            {
                rectangulo2.Fill = new SolidColorBrush(Colors.Red);
            }
            if (Rojo.IsChecked == true && Azul.IsChecked == false && Amarillo.IsChecked == true)
            {
                rectangulo2.Fill = new SolidColorBrush(Colors.Orange);
            }
            if (Rojo.IsChecked == true && Azul.IsChecked == true && Amarillo.IsChecked == false)
            {
                rectangulo2.Fill = new SolidColorBrush(Colors.Purple);
            }
            if (Rojo.IsChecked == true && Azul.IsChecked == true && Amarillo.IsChecked == true)
            {
                rectangulo2.Fill = new SolidColorBrush(Colors.Black);
            }
            if (Rojo.IsChecked == false && Azul.IsChecked == false && Amarillo.IsChecked == false)
            {
                rectangulo2.Fill = new SolidColorBrush(Colors.White);

            }
            if (Rojo.IsChecked == false && Azul.IsChecked == false && Amarillo.IsChecked == true)
            {
                rectangulo2.Fill = new SolidColorBrush(Colors.Yellow);
            }
            if (Rojo.IsChecked == false && Azul.IsChecked == true && Amarillo.IsChecked == false)
            {
                rectangulo2.Fill = new SolidColorBrush(Colors.Blue);
            }
            if (Rojo.IsChecked == false && Azul.IsChecked == true && Amarillo.IsChecked == true)
            {
                rectangulo2.Fill = new SolidColorBrush(Colors.Green);
            }
        }

        private void gotopage(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

    }
}