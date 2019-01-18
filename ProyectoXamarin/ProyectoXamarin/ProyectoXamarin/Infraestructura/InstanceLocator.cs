using ProyectoXamarin.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoXamarin.Infraestructura
{
    public class InstanceLocator
    {
        public InstanceLocator()
        {
            Main = new MainViewModel();
        }
        public MainViewModel Main { get; set; }
    }
}
