using ClinicaApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaApp.Infrastructure.Repositories
{
    public interface IMedicamentoRepository
    {
        Medicamento GetById(string id);
        IEnumerable<Medicamento> GetAll();

        void Add(Medicamento med);
        void Update(Medicamento med);
        void Remove(string id);

        bool ExistsId(string id);
    }
}
