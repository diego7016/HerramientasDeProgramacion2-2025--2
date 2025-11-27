using ClinicaApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClinicaApp.Infrastructure.Repositories
{
    public class InMemoryAyudaDiagnosticaRepository : IAyudaDiagnosticaRepository
    {
        private readonly List<AyudaDiagnostica> _ayudas = new List<AyudaDiagnostica>();

        public AyudaDiagnostica GetById(string id)
        {
            return _ayudas.FirstOrDefault(a => a.Id == id);
        }

        public IEnumerable<AyudaDiagnostica> GetAll()
        {
            return _ayudas.ToList();
        }

        public void Add(AyudaDiagnostica ayuda)
        {
            _ayudas.Add(ayuda);
        }

        public void Update(AyudaDiagnostica ayuda)
        {
            var existing = GetById(ayuda.Id);
            if (existing != null)
            {
                _ayudas.Remove(existing);
                _ayudas.Add(ayuda);
            }
        }

        public void Remove(string id)
        {
            var existing = GetById(id);
            if (existing != null)
                _ayudas.Remove(existing);
        }

        public bool ExistsId(string id) => GetById(id) != null;
    }
}
