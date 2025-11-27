using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaApp.Domain
{
    public class Especialidad
    {
        public string Id { get; set; } = string.Empty;      // ej: "CARDIO"
        public string Nombre { get; set; } = string.Empty;  // ej: "Cardiología"
    }
}
