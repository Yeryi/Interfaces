using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin_Sergio.Paginas;

namespace Xamarin_Sergio.ViewModel
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

        public void Navigate()
        {
            App.Master.IsPresented = false;
            switch (PageName)
            {
                case "Añadir_Coches":
                    App.Navigator.PushAsync(new Añadir_Coches());
                    break;
                case "Añadir_Concesionario":
                    App.Navigator.PushAsync(new Añadir_Concesionario());
                    break;
            }
        }
    }
}
