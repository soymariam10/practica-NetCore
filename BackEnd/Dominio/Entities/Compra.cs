namespace Dominio.Entities;

    public class Compra : BaseEntity
    {
        public DateTime FechaCompra { get; set; }
        public ICollection<MedicamentoCompra> MedicamentosCompra{ get; set; }

    }