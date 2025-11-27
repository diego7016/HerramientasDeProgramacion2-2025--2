using ClinicaApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClinicaApp.Infrastructure.Repositories
{
    public class InMemoryMedicamentoRepository : IMedicamentoRepository
    {
        private readonly List<Medicamento> _meds = new List<Medicamento>();

        public Medicamento GetById(string id)
        {
            return _meds.FirstOrDefault(m => m.Id == id);
        }

        public IEnumerable<Medicamento> GetAll()
        {
            return _meds.ToList();
        }

        public void Add(Medicamento med)
        {
            _meds.Add(med);
        }

        public void Update(Medicamento med)
        {
            var existing = GetById(med.Id);
            if (existing != null)
            {
                _meds.Remove(existing);
                _meds.Add(med);
            }
        }

        public void Remove(string id)
        {
            var existing = GetById(id);
            if (existing != null)
                _meds.Remove(existing);
        }

        public bool ExistsId(string id) => GetById(id) != null;
    }
}

