using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin_Sergio.Paginas;
using Xamarin_Sergio.Servicios;

namespace Xamarin_Sergio.ViewModel
{
    public class MenuItemViewModel
    {
        ServicioNavegacion servicioNavegacion;

        public MenuItemViewModel()
        {
            servicioNavegacion = new ServicioNavegacion();
        }
        public string Icon { get; set; }
        public string Title { get; set; }
        public string PageName { get; set; }

        public ICommand NavigateCommand
        {
            get { return new RelayCommand(() => servicioNavegacion.Navigate(PageName)); }
        }

    }
}
