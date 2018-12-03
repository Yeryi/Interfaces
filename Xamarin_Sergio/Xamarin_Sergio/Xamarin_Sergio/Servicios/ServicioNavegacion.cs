using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin_Sergio.Paginas;

namespace Xamarin_Sergio.Servicios
{
    public class ServicioNavegacion
    {
        public async void Navigate(string pageName)
        {
            App.Master.IsPresented = false;
            switch (pageName)
            {
                case "Añadir_Coches":
                    await Navigate(new Añadir_Coches());
                    break;
                case "MainPage":
                    await App.Navigator.PopToRootAsync();
                    break;
            }
        }

        private static async Task Navigate<T>(T page) where T : Page
        {
            NavigationPage.SetHasBackButton(page, false);
            NavigationPage.SetBackButtonTitle(page, "Atrás");

            await App.Navigator.PushAsync(page);
        }

        internal void SetMainPage(string pageName)
        {
            switch (pageName)
            {
                case "PaginaMaestra":
                    App.Current.MainPage = new PaginaMaestra();
                    break;
                default:
                    break;
            }
        }
    }
}
