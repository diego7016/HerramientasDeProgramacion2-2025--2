using ClinicaApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClinicaApp.Infrastructure.Repositories
{
    public class InMemoryProcedimientoRepository : IProcedimientoRepository
    {
        private readonly List<Procedimiento> _procs = new List<Procedimiento>();

        public Procedimiento GetById(string id)
        {
            return _procs.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Procedimiento> GetAll()
        {
            return _procs.ToList();
        }

        public void Add(Procedimiento proc)
        {
            _procs.Add(proc);
        }

        public void Update(Procedimiento proc)
        {
            var existing = GetById(proc.Id);
            if (existing != null)
            {
                _procs.Remove(existing);
                _procs.Add(proc);
            }
        }

        public void Remove(string id)
        {
            var existing = GetById(id);
            if (existing != null)
                _procs.Remove(existing);
        }

        public bool ExistsId(string id) => GetById(id) != null;
    }
}
