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
using Proyecto.Modelos;
using SQLite.Net;
using SQLite.Net.Platform.WinRT;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace Proyecto
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Lista_Concesionarios : Page
    {
        SQLiteConnection conn;
        private List<Concesionario> concesionarios;
        int id;
        public Lista_Concesionarios()
        {
            this.InitializeComponent();
            var path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "db.sqlite");
            conn = new SQLiteConnection(new SQLitePlatformWinRT(), path);
            GetConcesionarios();
            listaConce.SelectionChanged += Lista_Seleccion;
        }

        private void Lista_Seleccion(object sender, SelectionChangedEventArgs e)
        {
            Concesionario selected = (Concesionario)listaConce.SelectedItem;
            if (selected != null)
            {
                id = selected.id;
            }
        }

        public void GetConcesionarios()
        {
            concesionarios = new List<Concesionario>();
            var query = conn.Table<Concesionario>();

            foreach(var data in query)
            {
                concesionarios.Add(new Concesionario {id=data.id, nombre=data.nombre,provincia=data.provincia,pais=data.pais,ntrabajadores=data.ntrabajadores, telefono = data.telefono });
            }

            listaConce.ItemsSource = null;
            listaConce.ItemsSource = concesionarios;
        }

        public void Click_Eliminar(Object sender, RoutedEventArgs e)
        {
            conn.RunInTransaction(() =>
            {
                var c = conn.Execute("DELETE FROM Concesionario WHERE id = ?", id);
            });
            GetConcesionarios();
        }
    }
}
