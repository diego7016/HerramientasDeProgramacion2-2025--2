using ClinicaApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaApp.Infrastructure.Repositories
{
    public interface IFacturaRepository
    {
        void Add(Factura factura);
        IEnumerable<Factura> GetByPaciente(string cedulaPaciente);
    }
}
