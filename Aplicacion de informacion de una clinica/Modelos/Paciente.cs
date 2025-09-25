using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_de_informacion_de_una_clinica.Modelos
{
    public enum Genero { Masculino, Femenino, Otro }
      public class Paciente
    {
        public string Cedula { get; set; } = "";
        public string NombreCompleto { get; set; } = "";
        public DateTime FechaNacimiento { get; set; }
        public Genero Genero { get; set; }
        public string Direccion { get; set; } = "";
        public string Telefono { get; set; } = "";
        public string Correo { get; set; } = "";
        public ContactoEmergencia? ContactoEmergencia { get; set; }
        public Seguro? Seguro { get; set; }
    }
}
