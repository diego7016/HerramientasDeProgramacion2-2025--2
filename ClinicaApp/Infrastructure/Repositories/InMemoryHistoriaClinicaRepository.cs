using ClinicaApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaApp.Infrastructure.Repositories
{
    public class InMemoryHistoriaClinicaRepository : IHistoriaClinicaRepository
    {
        // Diccionario: clave = cédula paciente, valor = lista de entradas
        private readonly Dictionary<string, List<HistoriaClinicaEntrada>> _historias =
            new Dictionary<string, List<HistoriaClinicaEntrada>>();

        public void AddEntrada(HistoriaClinicaEntrada entrada)
        {
            if (!_historias.ContainsKey(entrada.CedulaPaciente))
            {
                _historias[entrada.CedulaPaciente] = new List<HistoriaClinicaEntrada>();
            }

            _historias[entrada.CedulaPaciente].Add(entrada);
        }

        public IEnumerable<HistoriaClinicaEntrada> GetPorPaciente(string cedulaPaciente)
        {
            if (_historias.TryGetValue(cedulaPaciente, out var lista))
            {
                return lista.OrderBy(h => h.FechaAtencion).ToList();
            }

            return Enumerable.Empty<HistoriaClinicaEntrada>();
        }

        public HistoriaClinicaEntrada GetEntrada(string cedulaPaciente, DateTime fechaAtencion)
        {
            if (_historias.TryGetValue(cedulaPaciente, out var lista))
            {
                return lista.FirstOrDefault(h => h.FechaAtencion.Date == fechaAtencion.Date);
            }

            return null;
        }
    }

}
