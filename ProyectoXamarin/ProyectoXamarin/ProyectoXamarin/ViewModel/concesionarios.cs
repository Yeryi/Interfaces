using SQLite;

namespace ProyectoXamarin.ViewModel
{
    public class concesionarios
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Provincia { get; set; }
        public string Pais { get; set; }
        public string Trabajadores { get; set; }
        public string Telefono { get; set; }
    }
}
