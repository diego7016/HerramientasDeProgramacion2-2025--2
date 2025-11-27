using ClinicaApp.Application.Validators;
using ClinicaApp.Domain;
using ClinicaApp.Infrastructure.Persistence;
using ClinicaApp.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClinicaApp.Application.Services
{
    public class UsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly UsuarioValidator _validator;
        private readonly ClinicaDbContext _context;

        public UsuarioService(IUsuarioRepository usuarioRepository, ClinicaDbContext context)
        {
            _usuarioRepository = usuarioRepository;
            _validator = new UsuarioValidator(usuarioRepository);
            _context = context;
        }

        // ===================== CREATE =====================
        public void CrearUsuario(Usuario usuario)
        {
            // 1) Validar
            _validator.ValidarNuevoUsuario(usuario);

            // 2) Guardar en repositorio (in-memory / lógica anterior)
            _usuarioRepository.Add(usuario);

            // 3) Guardar en BD
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        // ===================== READ =====================

        public List<Usuario> ListarUsuarios()
        {
            return _context.Usuarios.ToList();
        }

        public Usuario ObtenerPorCedula(string cedula)
        {
            return _context.Usuarios.FirstOrDefault(u => u.Cedula == cedula);
        }

        // ===================== DELETE =====================

        public void EliminarUsuario(string cedula)
        {
            // BD
            var usuario = _context.Usuarios.FirstOrDefault(u => u.Cedula == cedula);
            if (usuario != null)
            {
                _context.Usuarios.Remove(usuario);
                _context.SaveChanges();
            }

            // Repo in-memory
            if (_usuarioRepository.ExistsCedula(cedula))
            {
                _usuarioRepository.Remove(cedula);
            }
        }

        // ===================== LOGIN =====================
        public Usuario Login(string username, string password)
        {
            // 1) Buscar DIRECTO EN BD por nombre de usuario
            var usuario = _context.Usuarios
                                  .FirstOrDefault(u => u.NombreUsuario == username);

            if (usuario == null || usuario.Contrasena != password)
                throw new ArgumentException("Usuario o contraseña incorrectos.");

            // 2) (Opcional) Asegurar que el repo in-memory también lo tenga
            if (!_usuarioRepository.ExistsUsername(usuario.NombreUsuario))
            {
                _usuarioRepository.Add(usuario);
            }

            return usuario;
        }
    }
}
