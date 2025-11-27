using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaApp.Domain
{
    public class ContactoEmergencia
    {
        public int Id { get; set; }
        public string NombreCompleto { get; set; } = string.Empty;  // nombres y apellidos
        public string Relacion { get; set; } = string.Empty;        // madre, padre, etc.
        public string Telefono { get; set; } = string.Empty;        // 10 dígitos
    }
}
