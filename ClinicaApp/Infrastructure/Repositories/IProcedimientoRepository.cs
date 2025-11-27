using ClinicaApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaApp.Infrastructure.Repositories
{
    public interface IProcedimientoRepository
    {
        Procedimiento GetById(string id);
        IEnumerable<Procedimiento> GetAll();

        void Add(Procedimiento proc);
        void Update(Procedimiento proc);
        void Remove(string id);

        bool ExistsId(string id);
    }
}
