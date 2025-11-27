using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaApp.Domain
{
    public class OrdenMedicamentoItem
    {
        public int NumeroOrden { get; set; }        // máximo 6 dígitos
        public int Item { get; set; }               // se asigna secuencialmente
        public string IdMedicamento { get; set; } = string.Empty;   // desde inventario
        public string NombreMedicamento { get; set; } = string.Empty;
        public string Dosis { get; set; } = string.Empty;
        public string DuracionTratamiento { get; set; } = string.Empty;
        public decimal Costo { get; set; }
    }
}
