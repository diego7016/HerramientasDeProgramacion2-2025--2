using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaApp.Domain
{
    public class DetalleFacturaItem
    {
        public string Tipo { get; set; } = string.Empty; // Medicamento / Procedimiento / Ayuda
        public int NumeroOrden { get; set; }
        public int ItemOrden { get; set; }
        public string Descripcion { get; set; } = string.Empty;    // con dosis, cantidad, etc.
        public decimal Costo { get; set; }                         // valor total de ese ítem
    }
}
