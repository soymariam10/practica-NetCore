namespace Dominio.Entities;

    public class Medicamento : BaseEntity
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }
        public DateTime FechaExp { get; set; }
        public int ProveedorId { get; set; }
        public Proveedor Proveedores { get; set; }
        public int CompraId { get; set; }
        public Compra Compras { get; set; }
        public ICollection<MedicamentoVenta> MedicamentoVentas{ get; set; }
        public ICollection<MedicamentoCompra> MedicamentoCompras{ get; set; }
    }