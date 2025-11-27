using ClinicaApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaApp.Infrastructure.Repositories
{
    public interface IAyudaDiagnosticaRepository
    {
        AyudaDiagnostica GetById(string id);
        IEnumerable<AyudaDiagnostica> GetAll();

        void Add(AyudaDiagnostica ayuda);
        void Update(AyudaDiagnostica ayuda);
        void Remove(string id);

        bool ExistsId(string id);
    }
}
