using ClinicaApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaApp.Infrastructure.Repositories
{
    public interface IRegistroEnfermeriaRepository
    {
        void Add(RegistroEnfermeria registro);
        IEnumerable<RegistroEnfermeria> GetPorPaciente(string cedulaPaciente);
    }
}
