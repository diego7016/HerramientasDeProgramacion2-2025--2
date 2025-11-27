using ClinicaApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaApp.Infrastructure.Repositories
{
    public interface IHistoriaClinicaRepository
    {
        void AddEntrada(HistoriaClinicaEntrada entrada);
        IEnumerable<HistoriaClinicaEntrada> GetPorPaciente(string cedulaPaciente);
        HistoriaClinicaEntrada GetEntrada(string cedulaPaciente, DateTime fechaAtencion);
    }
}

