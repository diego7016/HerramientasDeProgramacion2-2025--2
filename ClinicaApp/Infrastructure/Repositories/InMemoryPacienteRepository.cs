using ClinicaApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaApp.Infrastructure.Repositories
{
    public class InMemoryPacienteRepository : IPacienteRepository
    {
        private readonly List<Paciente> _pacientes = new List<Paciente>();

        public Paciente GetByCedula(string cedula)
        {
            return _pacientes.FirstOrDefault(p => p.Cedula == cedula);
        }

        public IEnumerable<Paciente> GetAll()
        {
            return _pacientes.ToList();
        }

        public void Add(Paciente paciente)
        {
            _pacientes.Add(paciente);
        }

        public void Update(Paciente paciente)
        {
            var existing = GetByCedula(paciente.Cedula);
            if (existing != null)
            {
                _pacientes.Remove(existing);
                _pacientes.Add(paciente);
            }
        }

        public void Remove(string cedula)
        {
            var p = GetByCedula(cedula);
            if (p != null)
            {
                _pacientes.Remove(p);
            }
        }

        public bool ExistsCedula(string cedula) => GetByCedula(cedula) != null;
    }
}

