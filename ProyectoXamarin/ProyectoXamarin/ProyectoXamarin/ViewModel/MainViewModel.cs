using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ProyectoXamarin.ViewModel
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            LoadMenu();
        }
        public ObservableCollection<MenuItemViewModel> Menu { get; set; }

        private void LoadMenu()
        {
            Menu = new ObservableCollection<MenuItemViewModel>();

            Menu.Add(new MenuItemViewModel()
            {
                Icon= "ic_action_drive_eta",
                Title= "Lista Coches",
                PageName="ListaCoches"
            });

            Menu.Add(new MenuItemViewModel()
            {
                Icon = "ic_action_store",
                Title = "Lista Concesionarios",
                PageName = "ListaConcesionarios"
            });

            Menu.Add(new MenuItemViewModel()
            {
                Icon = "ic_action_drive_eta",
                Title = "Añadir Coche",
                PageName = "AñadirCoche"
            });

            Menu.Add(new MenuItemViewModel()
            {
                Icon = "ic_action_store",
                Title = "Añadir Concesionario",
                PageName = "AñadirConcesionario"
            });
        }

        
    }
}
