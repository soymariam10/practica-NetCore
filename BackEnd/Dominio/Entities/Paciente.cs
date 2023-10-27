namespace Dominio.Entities;

    public class Paciente : BaseEntity
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public ICollection<Venta> Ventas{ get; set; }

    }