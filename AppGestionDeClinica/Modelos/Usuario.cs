using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionDeClinica.Modelos
{
    public class Usuario
    {
        public string NombreUsuario { get; set; }    // único, máx 15 caracteres
        public string ClaveHash { get; set; }        // contraseña encriptada
        public string NombreCompleto { get; set; }
        public string Cedula { get; set; }           // único
        public string Correo { get; set; }
        public string Telefono { get; set; }         // 10 dígitos
        public DateTime FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public RolUsuario Rol { get; set; }

    }
}
