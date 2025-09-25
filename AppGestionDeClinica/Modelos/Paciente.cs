using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionDeClinica.Modelos
{
   public class Paciente
    {
        public string Cedula { get; set; }
        public string NombreCompleto { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Genero { get; set; }         // Masculino/Femenino/Otro
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }

        public ContactoEmergencia ContactoEmergencia { get; set; }
        public Poliza Poliza { get; set; }

        // Para controlar copagos por año
        public Dictionary<int, decimal> CopagosAnuales { get; set; } = new Dictionary<int, decimal>();
    }
}

