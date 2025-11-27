using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaApp.Domain
{
    public class OrdenProcedimientoItem
    {
        public int NumeroOrden { get; set; }
        public int Item { get; set; }

        public string IdProcedimiento { get; set; } = string.Empty;   // del inventario
        public string NombreProcedimiento { get; set; } = string.Empty;
        public int Cantidad { get; set; }
        public string Frecuencia { get; set; } = string.Empty;

        public bool RequiereEspecialista { get; set; }
        public string IdTipoEspecialista { get; set; } = string.Empty; // del inventario
        public decimal Costo { get; set; }
    }
}
