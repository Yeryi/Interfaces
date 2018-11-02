using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Modelos
{
    public class Concesionario
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string provincia { get; set; }
        public string pais { get; set; }
        public int ntrabajadores { get; set; }
        public string telefono { get; set; }
    }

    public class ManejarConcesionario
    {
        public static List<Concesionario> GetConcesionarios()
        {
            var concesionarios = new List<Concesionario>();

            concesionarios.Add(new Concesionario { id = 1, nombre = "Peugeot", provincia = "Almeria", pais = "España", ntrabajadores = 32, telefono = "951342198" });
            concesionarios.Add(new Concesionario { id = 2, nombre = "Renault", provincia = "Almeria", pais = "España", ntrabajadores = 43, telefono = "952507845" });
        }
    }
}
