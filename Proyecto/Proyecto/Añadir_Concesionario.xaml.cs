using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Proyecto.Modelos;
using SQLite.Net;
using SQLite.Net.Platform.WinRT;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace Proyecto
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Añadir_Concesionario : Page
    {
        SQLiteConnection conn;
        private List<Concesionario> concesionario;
        public Añadir_Concesionario()
        {
            this.InitializeComponent();
            var path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "db.sqlite");
            conn = new SQLiteConnection(new SQLitePlatformWinRT(), path);
        }

        public void Borrar_Datos_Click(object sender, RoutedEventArgs e)
        {
            id.Text = "";
            nombre.Text = "";
            provincia.Text = "";
            trabajadores.Text = "";
            telefono.Text = "";
        }

        public void Insertar_Datos_Click(object sender, RoutedEventArgs e)
        {
            Datos_Concesionario();
        }

        public void Datos_Concesionario()
        {
            int id2, trabajadores2;
            String nombre2,pais2,provincia2, telefono2;

            id2 = int.Parse(id.Text);
            nombre2 = nombre.Text;
            provincia2 = provincia.Text;
            pais2 = pais.SelectedItem.ToString();
            telefono2 = telefono.Text;
            trabajadores2 = int.Parse(trabajadores.Text);

            conn.Insert(new Concesionario() {
                id = id2,
                nombre = nombre2,
                provincia = provincia2,
                pais=pais2,
                ntrabajadores = trabajadores2,
                telefono = telefono2
            });
            id.Text = "";
            nombre.Text = "";
            provincia.Text = "";
            trabajadores.Text = "";
            telefono.Text = "";

        }
    }
}
