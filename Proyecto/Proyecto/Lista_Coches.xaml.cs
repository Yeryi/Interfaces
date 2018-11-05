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
    /// 
    public sealed partial class Lista_Coches : Page
    {
        SQLiteConnection conn;
        private List<Coches> coche;
        String matricula;
        public Lista_Coches()
        {
            this.InitializeComponent();
            var path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "db.sqlite");
            conn = new SQLiteConnection(new SQLitePlatformWinRT(), path);
            GetCoches();
            listaCoche.SelectionChanged += Lista_Seleccion;
        }

        public void GetCoches()
        {
            coche = new List<Coches>();
            var query = conn.Table<Coches>();

            foreach (var data in query)
            {
                coche.Add(new Coches { marca = data.marca, modelo = data.modelo, color = data.color,combustible=data.combustible, matricula = data.matricula,fecha=data.fecha, pais = data.pais});
            }

            listaCoche.ItemsSource = null;
            listaCoche.ItemsSource = coche;
        }

        public void Lista_Seleccion(Object sender, SelectionChangedEventArgs e)
        {
            Coches selected = (Coches)listaCoche.SelectedItem;
            if (selected != null)
            {
                matricula = selected.matricula;
            }
        }

        public void Click_Eliminar(Object sender, RoutedEventArgs e)
        {
            conn.RunInTransaction(() =>
            {
                var c = conn.Execute("DELETE FROM Coches WHERE matricula = ?", matricula);
            });
            GetCoches();
        }
    }
}
