using ClinicaApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaApp.Infrastructure.Repositories
{
    public class InMemoryOrdenRepository : IOrdenRepository
    {
        private readonly List<OrdenMedica> _ordenes = new List<OrdenMedica>();

        public bool ExisteNumeroOrden(int numeroOrden)
        {
            return _ordenes.Any(o => o.NumeroOrden == numeroOrden);
        }

        public void AddOrden(OrdenMedica orden)
        {
            _ordenes.Add(orden);
        }

        public OrdenMedica GetOrden(int numeroOrden)
        {
            return _ordenes.FirstOrDefault(o => o.NumeroOrden == numeroOrden);
        }

        public IEnumerable<OrdenMedica> GetOrdenesPorPaciente(string cedulaPaciente)
        {
            return _ordenes
                .Where(o => o.CedulaPaciente == cedulaPaciente)
                .OrderBy(o => o.FechaCreacion)
                .ToList();
        }
    }
}

