using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaApp.Domain
{
    public class Factura
    {
        public string NumeroFactura { get; set; } = string.Empty;

        public string CedulaPaciente { get; set; } = string.Empty;
        public string NombrePaciente { get; set; } = string.Empty;
        public int EdadPaciente { get; set; }

        public string NombreMedicoTratante { get; set; } = string.Empty;

        // Datos póliza
        public string NombreCompaniaSeguro { get; set; } = string.Empty;
        public string NumeroPoliza { get; set; } = string.Empty;
        public DateTime? FechaFinPoliza { get; set; }
        public bool PolizaActiva { get; set; }
        public int DiasVigenciaPoliza { get; set; }

        // Valores
        public decimal TotalServicios { get; set; }
        public decimal CopagoPaciente { get; set; }
        public decimal TotalCubreAseguradora { get; set; }

        public DateTime FechaFactura { get; set; }

        public List<DetalleFacturaItem> Detalles { get; set; } = new List<DetalleFacturaItem>();
    }
}
