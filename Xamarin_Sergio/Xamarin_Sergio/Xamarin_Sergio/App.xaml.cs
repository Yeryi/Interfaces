using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin_Sergio.Paginas;

namespace Xamarin_Sergio
{
    public partial class App : Application
    {
        public static NavigationPage Navigator { get; internal set; }
        public static PaginaMaestra Master { get; internal set; }

        public App()
        {
            InitializeComponent();

            MainPage = new PaginaMaestra();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
