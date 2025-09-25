using Aplicacion_de_informacion_de_una_clinica.Modelos;
using Aplicacion_de_informacion_de_una_clinica.puertos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Aplicacion_de_informacion_de_una_clinica.Servicios
{
    public class ServicioUsuario
    {
        private readonly IRepositorioClinica _repositorio;

        public ServicioUsuario(IRepositorioClinica repositorio) => _repositorio = repositorio;

        public void CrearUsuario(Usuario usuario)
        {
            if (string.IsNullOrWhiteSpace(usuario.NombreUsuario) || usuario.NombreUsuario.Length > 15)
                throw new ArgumentException("Nombre de usuario inválido (vacío o >15 caracteres).");

            if (!Regex.IsMatch(usuario.NombreUsuario, @"^[a-zA-Z0-9]+$"))
                throw new ArgumentException("Nombre de usuario solo debe contener letras y números.");

            if (_repositorio.ObtenerUsuario(usuario.NombreUsuario) != null)
                throw new InvalidOperationException("Ya existe un usuario con ese nombre.");

            // Validar contraseña (mín 8, 1 mayúscula, 1 número, 1 caracter especial)
            if (!Regex.IsMatch(usuario.Contrasena, @"^(?=.*[A-Z])(?=.*\d)(?=.*\W).{8,}$"))
                throw new ArgumentException("Contraseña no cumple requisitos de seguridad.");

            _repositorio.AgregarUsuario(usuario);
        }

        public void EliminarUsuario(string nombreUsuario)
        {
            var u = _repositorio.ObtenerUsuario(nombreUsuario);
            if (u == null) throw new InvalidOperationException("Usuario no existe.");
            _repositorio.EliminarUsuario(nombreUsuario);
        }
    }
}
