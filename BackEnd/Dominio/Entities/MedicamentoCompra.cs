namespace Dominio.Entities;

    public class MedicamentoCompra : BaseEntity
    {
        public int CompraId { get; set; }
        public Compra Compras { get; set; }
        public int MedicamentoId { get; set; }
        public Medicamento Medicamentos { get; set; }

    }