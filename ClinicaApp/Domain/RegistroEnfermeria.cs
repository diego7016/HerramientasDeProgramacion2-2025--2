using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaApp.Domain
{
    public class RegistroEnfermeria
    {
        public string Id { get; set; }
        public string CedulaPaciente { get; set; } = string.Empty;
        public DateTime FechaHora { get; set; } = DateTime.Now;
        public int NumeroOrden { get; set; }
        public int ItemOrden { get; set; }            // medicamento o procedimiento
        public string TipoItem { get; set; } = "";    // Medicamento / Procedimiento
        public SignosVitales Signos { get; set; } = new SignosVitales ();
        public string Observaciones { get; set; } = string.Empty;

    }
}
