using ClinicaApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaApp.Infrastructure.Repositories
{
    public interface IUsuarioRepository
    {
        
        
            Usuario GetByUsername(string username);
            Usuario GetByCedula(string cedula);
            IEnumerable<Usuario> GetAll();

            void Add(Usuario usuario);
            void Remove(string cedula);

            bool ExistsCedula(string cedula);
            bool ExistsUsername(string username);
        

    }
}
