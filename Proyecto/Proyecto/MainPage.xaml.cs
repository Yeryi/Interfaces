using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace Proyecto
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
			frame.Navigate(typeof(Principal));
		}

        public void boton_menu_click(object sender, RoutedEventArgs e)
        {
            MiSplitView.IsPaneOpen = !MiSplitView.IsPaneOpen;
        }

        public void Boton_lista_click(object sender,RoutedEventArgs e)
        {
            frame.Navigate(typeof(Lista));
        }

        public void Boton_añadir_coche_click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(typeof(Añadir_Coche));
        }

        public void Boton_añadir_concesionario_click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(typeof(Añadir_Concesionario));
        }

        public void Boton_eliminar_click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(typeof(Eliminar));
        }

		public void boton_home_click(object sender, RoutedEventArgs e)
		{
			frame.Navigate(typeof(Principal));
		}

		public void boton_atras_click(object sender, RoutedEventArgs e)
		{
			if (frame.CanGoBack)
			{
				frame.GoBack();
			}
		}

		public void boton_adelante_click(object sender, RoutedEventArgs e)
		{
			if (frame.CanGoForward)
			{
				frame.GoForward();
			}
		}
	}
}
