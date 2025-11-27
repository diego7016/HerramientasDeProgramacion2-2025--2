using ClinicaApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaApp.Infrastructure.Repositories
{
    public interface IOrdenRepository
    {
        bool ExisteNumeroOrden(int numeroOrden);

        void AddOrden(OrdenMedica orden);

        OrdenMedica GetOrden(int numeroOrden);
        IEnumerable<OrdenMedica> GetOrdenesPorPaciente(string cedulaPaciente);
    }
}
