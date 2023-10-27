namespace Dominio.Entities;

    public class MedicamentoVenta : BaseEntity
    {
        public int VentaId { get; set; }
        public Venta Ventas { get; set; }
        public int MedicamentoId { get; set; }
        public Medicamento Medicamentos { get; set; }
    }