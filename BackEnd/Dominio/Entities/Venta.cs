namespace Dominio.Entities;

    public class Venta : BaseEntity
    {
        public DateTime FechaVenta { get; set; }
        public int PacienteId { get; set; }
        public Paciente Pacientes { get; set; }
        public int EmpleadoId { get; set; }
        public Empleado Empleados { get; set; }
        public ICollection<MedicamentoVenta> MedicamentoVentas{ get; set; }
    }