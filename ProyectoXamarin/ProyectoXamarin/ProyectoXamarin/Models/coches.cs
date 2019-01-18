using SQLite;

namespace ProyectoXamarin.Models
{
    public class coches
    {
        [PrimaryKey, AutoIncrement]
		public int ID { get; set; }
		public string Marca { get; set; }
		public string Modelo { get; set; }
		public string Color { get; set; }
        public string Combustible { get; set; }
        public string Matricula { get; set; }
        public string Pais { get; set; }
    }
}
