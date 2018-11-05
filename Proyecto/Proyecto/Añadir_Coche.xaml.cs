using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using SQLite.Net;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Proyecto.Modelos;
using SQLite.Net.Platform.WinRT;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace Proyecto
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Añadir_Coche : Page
    {
        SQLiteConnection conn;
        private List<Coches> coche;
        public Añadir_Coche()
        {
            this.InitializeComponent();
            var path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "db.sqlite");
            conn = new SQLiteConnection(new SQLitePlatformWinRT(), path);
        }

        private void HandleCheck(object sender, RoutedEventArgs e)
        {
            RadioButton rb = sender as RadioButton;
        }

        public void Borrar_Datos_Click(object sender, RoutedEventArgs e)
        {
            marca.Text = "";
            modelo.Text = "";
            color.Text = "";
            matricula.Text = "";
        }

        public void Insertar_Datos_Click(object sender, RoutedEventArgs e)
        {
            Datos_Concesionario();
        }

        public void Datos_Concesionario()
        {
            String marca2, modelo2, color2, matricula2, pais2,fecha2;
            String combustible2 = "";
            DateTime fecha1 = fecha.Date.DateTime;
            //var date = this.fecha.Date;

            marca2 = marca.Text;
            modelo2 = modelo.Text;
            color2 = color.Text;
            pais2 = paises.SelectedItem.ToString();
            matricula2 = matricula.Text;
            fecha2 = fecha1.ToString();

            if (diesel.IsChecked==true)
            {
                combustible2 = "Diesel";
            }else if (gasolina.IsChecked == true)
            {
                combustible2 = "Gasolina";
            }else if (electrico.IsChecked == true)
            {
                combustible2 = "Electrico";
            }

            conn.Insert(new Coches()
            {
                marca = marca2,
                modelo = modelo2,
                color = color2,
                combustible=combustible2,
                matricula = matricula2,
                fecha=fecha2,
                pais = pais2

            });

            marca.Text = "";
            modelo.Text = "";
            color.Text = "";
            matricula.Text = "";

        }
    }
}
