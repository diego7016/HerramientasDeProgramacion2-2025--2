using ClinicaApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClinicaApp.Infrastructure.Repositories
{
    public class InMemoryUsuarioRepository : IUsuarioRepository
    {
        private readonly List<Usuario> _usuarios = new List<Usuario>();

        public Usuario GetByUsername(string username)
        {
            return _usuarios.FirstOrDefault(u =>
                u.NombreUsuario.Equals(username, StringComparison.OrdinalIgnoreCase));
        }

        public Usuario GetByCedula(string cedula)
        {
            return _usuarios.FirstOrDefault(u => u.Cedula == cedula);
        }

        public IEnumerable<Usuario> GetAll()
        {
            return _usuarios.ToList();
        }

        public void Add(Usuario usuario)
        {
            _usuarios.Add(usuario);
        }

        public void Remove(string cedula)
        {
            var u = GetByCedula(cedula);
            if (u != null)
            {
                _usuarios.Remove(u);
            }
        }

        public bool ExistsCedula(string cedula) => GetByCedula(cedula) != null;

        public bool ExistsUsername(string username) => GetByUsername(username) != null;
    }
}
