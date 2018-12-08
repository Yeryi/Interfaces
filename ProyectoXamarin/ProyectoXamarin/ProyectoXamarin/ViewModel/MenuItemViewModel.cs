using GalaSoft.MvvmLight.Command;
using ProyectoXamarin.Paginas;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace ProyectoXamarin.ViewModel
{
    public class MenuItemViewModel
    {
        public string Icon { get; set; }
        public string Title { get; set; }
        public string PageName { get; set; }

        public ICommand NavigateCommand
        {
            get { return new RelayCommand(Navigate); }
        }

        private void Navigate()
        {
            App.Master.IsPresented = false;
            switch (PageName)
            {
                case "AñadirCoche":
                    App.Navigator.PushAsync(new AñadirCoche());
                    break;
                case "AñadirConcesionario":
                    App.Navigator.PushAsync(new AñadirConcesionario());
                    break;
                case "ListaCoches":
                    App.Navigator.PushAsync(new ListaCoches());
                    break;

                case "ListaConcesionarios":
                    App.Navigator.PushAsync(new ListaConcesionarios());
                    break;
            }
        }
    }
}
