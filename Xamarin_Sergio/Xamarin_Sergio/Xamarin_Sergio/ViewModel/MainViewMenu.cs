using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Xamarin_Sergio.ViewModel
{
    public class MainViewMenu
    {
        public ObservableCollection<MenuItemViewModel> Menu { get; set; }

        public MainViewMenu()
        {
            LoadMenu();
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
                PageName = "MainPage"
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
