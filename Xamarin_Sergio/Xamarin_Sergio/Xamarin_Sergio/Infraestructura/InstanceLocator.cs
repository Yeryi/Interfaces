using System;
using System.Collections.Generic;
using System.Text;
using Xamarin_Sergio.ViewModel;

namespace Xamarin_Sergio.Infraestructura
{
    public class InstanceLocator
    {
        public InstanceLocator()
        {
            Main = new MainViewMenu();
        }
        public MainViewMenu Main { get; set; }
    }
}
