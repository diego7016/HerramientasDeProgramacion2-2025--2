using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaApp.Domain
{
    public class OrdenAyudaDiagnosticaItem
    {
        public int NumeroOrden { get; set; }
        public int Item { get; set; }

        public string IdAyudaDiagnostica { get; set; } = string.Empty;  // inventario
        public string NombreAyudaDiagnostica { get; set; } = string.Empty;
        public int Cantidad { get; set; }

        public bool RequiereEspecialista { get; set; }
        public string IdTipoEspecialista { get; set; } = string.Empty;
        public decimal Costo { get; set; }
    }
}
