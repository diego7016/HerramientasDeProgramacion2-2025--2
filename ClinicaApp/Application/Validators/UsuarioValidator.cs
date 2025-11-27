using ClinicaApp.Domain;
using ClinicaApp.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClinicaApp.Application.Validators
{
    public class UsuarioValidator
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioValidator(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public void ValidarNuevoUsuario(Usuario usuario)
        {
            if (string.IsNullOrWhiteSpace(usuario.NombreCompleto))
                throw new ArgumentException("El nombre completo es obligatorio.");

            if (string.IsNullOrWhiteSpace(usuario.Cedula))
                throw new ArgumentException("La cédula es obligatoria.");

            if (_usuarioRepository.ExistsCedula(usuario.Cedula))
                throw new ArgumentException("La cédula ya existe en el sistema.");

            // Email: con @ y dominio
            if (!Regex.IsMatch(usuario.Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                throw new ArgumentException("El correo electrónico no es válido.");

            // Teléfono: 1 a 10 dígitos
            if (!Regex.IsMatch(usuario.Telefono, @"^\d{1,10}$"))
                throw new ArgumentException("El teléfono debe contener entre 1 y 10 dígitos.");

            // Edad máxima 150 años
            int edad = usuario.CalcularEdad();
            if (edad < 0 || edad > 150)
                throw new ArgumentException("La edad no es válida (0-150 años).");

            // Dirección máximo 30 caracteres
            if (usuario.Direccion.Length > 30)
                throw new ArgumentException("La dirección no puede tener más de 30 caracteres.");

            // Nombre de usuario
            if (string.IsNullOrWhiteSpace(usuario.NombreUsuario))
                throw new ArgumentException("El nombre de usuario es obligatorio.");

            if (usuario.NombreUsuario.Length > 15)
                throw new ArgumentException("El nombre de usuario no puede tener más de 15 caracteres.");

            if (!Regex.IsMatch(usuario.NombreUsuario, @"^[a-zA-Z0-9]+$"))
                throw new ArgumentException("El nombre de usuario solo puede contener letras y números.");

            if (_usuarioRepository.ExistsUsername(usuario.NombreUsuario))
                throw new ArgumentException("El nombre de usuario ya existe.");

            // Contraseña
            ValidarContrasena(usuario.Contrasena);
        }

        private void ValidarContrasena(string contrasena)
        {
            if (string.IsNullOrEmpty(contrasena) || contrasena.Length < 8)
                throw new ArgumentException("La contraseña debe tener al menos 8 caracteres.");

            if (!Regex.IsMatch(contrasena, @"[A-Z]"))
                throw new ArgumentException("La contraseña debe contener al menos una mayúscula.");

            if (!Regex.IsMatch(contrasena, @"\d"))
                throw new ArgumentException("La contraseña debe contener al menos un número.");

            if (!Regex.IsMatch(contrasena, @"[^a-zA-Z0-9]"))
                throw new ArgumentException("La contraseña debe contener al menos un carácter especial.");
        }
    }
}