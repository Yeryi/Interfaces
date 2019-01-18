using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace ControlCustomizado.Datos
{
    public class Planeta
    {
        public string Nombre { get; set; }
        public double Diametro { get; set; }
        public double DistanciaSol { get; set; }
        public string Imagen { get; set; }
    }

    public class GestorPlanetas
    {
        public static ObservableCollection<Planeta> ObtenerPlanetas()
        {
            var Planetas = new ObservableCollection<Planeta>();

            Planetas.Add(new Planeta { Nombre = "Tierra", Diametro = 15, DistanciaSol = 200, Imagen = "ms-appx:///Assets/StoreLogo.png" });
            Planetas.Add(new Planeta { Nombre = "Marte", Diametro = 20, DistanciaSol = 300, Imagen = "ms-appx:///Assets/StoreLogo.png" });
            Planetas.Add(new Planeta { Nombre = "Venus", Diametro = 25, DistanciaSol = 400, Imagen = "ms-appx:///Assets/StoreLogo.png" });
            Planetas.Add(new Planeta { Nombre = "Luna", Diametro = 5, DistanciaSol = 220, Imagen = "ms-appx:///Assets/StoreLogo.png" });

            return Planetas;
        }
    }
}
