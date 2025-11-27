using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaApp.Domain
{
    public  class OrdenMedica
    {
        public int NumeroOrden { get; set; }               // max 6 dígitos
        public string CedulaPaciente { get; set; } = string.Empty;
        public string CedulaMedico { get; set; } = string.Empty;
        public DateTime FechaCreacion { get; set; } = DateTime.Now;

        public List<OrdenMedicamentoItem> Medicamentos { get; set; } = new List<OrdenMedicamentoItem>();
        public List<OrdenProcedimientoItem> Procedimientos { get; set; } = new List<OrdenProcedimientoItem>();
        public List<OrdenAyudaDiagnosticaItem> AyudasDiagnosticas { get; set; } = new List<OrdenAyudaDiagnosticaItem>();
    }
}
