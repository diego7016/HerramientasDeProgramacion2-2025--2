using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaApp.Domain
{
    public class AyudaDiagnostica
    {
        public string Id { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public decimal Costo { get; set; }

        public bool RequiereEspecialista { get; set; }
        public string IdTipoEspecialista { get; set; } = string.Empty;
    }
}
