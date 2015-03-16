using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using PhoneApp1.Resources;
using System.Windows.Media;

namespace PhoneApp1
{
    public partial class MainPage : PhoneApplicationPage
    {
        
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Código de ejemplo para traducir ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void cambiarcolor(object sender, RoutedEventArgs e)
        {
            if (rojo.IsChecked==true){
              
                rectangulo.Fill =new SolidColorBrush(Colors.Red) ;                 
            
            }
        }

        private void cambiarcolor2(object sender, RoutedEventArgs e)
        {
            if (azul.IsChecked == true) {
                rectangulo.Fill = new SolidColorBrush(Colors.Blue);
            }
        }

        private void cambiarcolor3(object sender, RoutedEventArgs e)
        {
            if (amarillo.IsChecked == true) {
                rectangulo.Fill = new SolidColorBrush(Colors.Yellow);
            }
        }

        private void gotopage(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/checkbox.xaml", UriKind.Relative));
        }

        // Código de ejemplo para compilar una ApplicationBar traducida
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Establecer ApplicationBar de la página en una nueva instancia de ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Crear un nuevo botón y establecer el valor de texto en la cadena traducida de AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Crear un nuevo elemento de menú con la cadena traducida de AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}

        
    }
}