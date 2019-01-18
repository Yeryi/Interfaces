using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin_Sergio.Servicios;

namespace Xamarin_Sergio.ViewModel
{
    public class MainViewMenu
    {
        public ObservableCollection<MenuItemViewModel> Menu { get; set; }
        ServicioNavegacion servicioNavegacion;

        public MainViewMenu()
        {
            servicioNavegacion = new ServicioNavegacion();
            LoadMenu();
        }

        public ICommand GoToCommand
        {
            get { return new RelayCommand<string>(GoTo); }
        }

        private void GoTo(string pageName)
        {
            servicioNavegacion.Navigate(pageName);
        }

        public ICommand StartCommand
        {
            get { return new RelayCommand(Start); }
        }

        private async void Start()
        {
            servicioNavegacion.SetMainPage("PaginaMaestra");
        }

        private void LoadMenu()
        {
            Menu = new ObservableCollection<MenuItemViewModel>();

            Menu.Add(new MenuItemViewModel()
            {
                Icon = "",
                Title = "Lista Concesionarios",
                PageName = "MainPage"
            });

            Menu.Add(new MenuItemViewModel()
            {
                Icon = "",
                Title = "Lista Coches",
                PageName = "MainPage"
            });

            Menu.Add(new MenuItemViewModel()
            {
                Icon = "",
                Title = "Añadir Concesionario",
                PageName = "Añadir_Concesionario"
            });

            Menu.Add(new MenuItemViewModel()
            {
                Icon = "",
                Title = "Añadir Coche",
                PageName = "Añadir_Coches"
            });
        }
    }
}
