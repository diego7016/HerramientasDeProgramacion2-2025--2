using ClinicaApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaApp.Domain
{
    public class Paciente
    {
        // Datos personales
        public string Cedula { get; set; } = string.Empty;          // identificador único
        public string NombreCompleto { get; set; } = string.Empty;
        public DateTime FechaNacimiento { get; set; }
        public Genero Genero { get; set; }
        public string Direccion { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;        // 10 dígitos
        public string Email { get; set; } = string.Empty;           // opcional pero si viene, válido

        // Contacto de emergencia (solo 1)
        public ContactoEmergencia ContactoEmergencia { get; set; }

        // Seguro médico (solo 1 póliza)
        public PolizaSeguro PolizaSeguro { get; set; }

        public int CalcularEdad()
        {
            var hoy = DateTime.Today;
            int edad = hoy.Year - FechaNacimiento.Year;
            if (FechaNacimiento.Date > hoy.AddYears(-edad))
                edad--;
            return edad;
        }
    }
}

