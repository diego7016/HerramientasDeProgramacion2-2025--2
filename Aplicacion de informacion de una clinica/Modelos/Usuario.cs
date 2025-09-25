using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_de_informacion_de_una_clinica.Modelos
{

    public enum Rol { RecursosHumanos, Administrativo, Soporte, Enfermera, Medico }
    public class Usuario
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string NombreUsuario { get; set; } = "";   // único, máximo 15
        public string Contrasena { get; set; } = "";      // validación fuerte
        public Rol Rol { get; set; }
    }
}
