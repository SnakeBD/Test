namespace CrudVehiculo.Models
{
    public class VehiculoModel
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public string Patente { get; set; }
        public int Anio { get; set; }
        public int Cilindrada { get; set;}
    }
}
