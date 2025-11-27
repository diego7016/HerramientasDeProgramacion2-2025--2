using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaApp.Domain
{
    public class SignosVitales
    {
        public string Id { get; set; }
        public string PresionArterial { get; set; } = string.Empty; // Ej: 120/80
        public float Temperatura { get; set; }                      // Ej: 36.5
        public int Pulso { get; set; }                              // Ej: 70
        public int SpO2 { get; set; }                               // Ej: 98
    }
}
