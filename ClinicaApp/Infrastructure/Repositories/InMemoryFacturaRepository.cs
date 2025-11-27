using ClinicaApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaApp.Infrastructure.Repositories
{
    public class InMemoryFacturaRepository : IFacturaRepository
    {
        private readonly List<Factura> _facturas = new List<Factura>();

        public void Add(Factura factura)
        {
            _facturas.Add(factura);
        }

        public IEnumerable<Factura> GetByPaciente(string cedulaPaciente)
        {
            return _facturas
                .Where(f => f.CedulaPaciente == cedulaPaciente)
                .ToList();

        }
    }
}
