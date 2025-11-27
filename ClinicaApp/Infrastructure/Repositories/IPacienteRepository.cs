using ClinicaApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaApp.Infrastructure.Repositories
{
    public interface IPacienteRepository
    {
        Paciente GetByCedula(string cedula);
        IEnumerable<Paciente> GetAll();

        void Add(Paciente paciente);
        void Update(Paciente paciente);
        void Remove(string cedula);

        bool ExistsCedula(string cedula);
    }
}
