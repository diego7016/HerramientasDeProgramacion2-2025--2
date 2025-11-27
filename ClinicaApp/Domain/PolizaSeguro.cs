using ClinicaApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaApp.Domain
{
    public class PolizaSeguro
    {
        public int Id { get; set; }
        public string CompaniaSeguros { get; set; } = string.Empty;
        public string NumeroPoliza { get; set; } = string.Empty;
        public EstadoPoliza Estado { get; set; } = EstadoPoliza.Inactiva;
        public DateTime FechaVigenciaFin { get; set; }  // dd/mm/yyyy
    }
}
