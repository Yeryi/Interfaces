using ProyectoXamarin.Datos;
using ProyectoXamarin.Paginas;
using ProyectoXamarin.ViewModel;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ProyectoXamarin
{
    public partial class App : Application
    {
        public static NavigationPage Navigator { get; internal set; }
        public static MasterDetailPage Master { get; internal set; }
        static BaseCoches databaseC;

        public App()
        {
            InitializeComponent();

            MainPage = new MasterDetail();
        }

        public static BaseCoches Database
        {
            get
            {
                if (databaseC == null)
                {
                    databaseC = new BaseCoches(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "TodoSQLite.db3"));
                }
                return databaseC;
            }
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
