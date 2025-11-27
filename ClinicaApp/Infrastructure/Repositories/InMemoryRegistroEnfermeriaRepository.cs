using ClinicaApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaApp.Infrastructure.Repositories
{
    public class InMemoryRegistroEnfermeriaRepository : IRegistroEnfermeriaRepository
    {
        private readonly List<RegistroEnfermeria> _registros = new List<RegistroEnfermeria>();

        public void Add(RegistroEnfermeria registro)
        {
            _registros.Add(registro);
        }

        public IEnumerable<RegistroEnfermeria> GetPorPaciente(string cedulaPaciente)
        {
            return _registros
                .Where(r => r.CedulaPaciente == cedulaPaciente)
                .OrderBy(r => r.FechaHora)
                .ToList();
        }
    }
}
