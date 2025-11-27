using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaApp.Domain
{
    public class HistoriaClinicaEntrada
    {
        public int Id { get; set; }
        public string CedulaPaciente { get; set; } = string.Empty;
        public DateTime FechaAtencion { get; set; } = DateTime.Now;  // clave secundaria
        public string CedulaMedico { get; set; } = string.Empty;     // max 10 dígitos

        public string MotivoConsulta { get; set; } = string.Empty;
        public string Sintomatologia { get; set; } = string.Empty;
        public string Diagnostico { get; set; } = string.Empty;

        // Podríamos enlazar órdenes médicas asociadas, opcionalmente
        // public List<int> NumerosOrdenAsociadas { get; set; } = new();
    }
}
