using ClinicaApp.Application.Validators;
using ClinicaApp.Domain;
using ClinicaApp.Infrastructure.Persistence;
using ClinicaApp.Infrastructure.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace ClinicaApp.Application.Services
{
    public class HistoriaClinicaService
    {
        private readonly IHistoriaClinicaRepository _repo;
        private readonly HistoriaClinicaValidator _validator;
        private readonly ClinicaDbContext _context;

        public HistoriaClinicaService(IHistoriaClinicaRepository repo, ClinicaDbContext context)
        {
            _repo = repo;
            _validator = new HistoriaClinicaValidator();
            _context = context;
        }

        // ===================== CREATE =====================
        public void RegistrarEntrada(HistoriaClinicaEntrada entrada)
        {
            // 1) Validar
            _validator.ValidarNuevaEntrada(entrada);

            // 2) Guardar en repositorio (in-memory)
            _repo.AddEntrada(entrada);

            // 3) Guardar en BD (SQL Server)
            _context.HistoriasClinicas.Add(entrada);
            _context.SaveChanges();
        }

        // ===================== READ =====================
        public IEnumerable<HistoriaClinicaEntrada> ObtenerHistoriaPaciente(string cedulaPaciente)
        {
            return _context.HistoriasClinicas
                           .Where(h => h.CedulaPaciente == cedulaPaciente)
                           .ToList();
        }

        public HistoriaClinicaEntrada ObtenerEntradaPorId(int id)
        {
            return _context.HistoriasClinicas.FirstOrDefault(h => h.Id == id);
        }

        // ===================== DELETE (Opcional) =====================
        public void EliminarEntrada(int id)
        {
            var entrada = _context.HistoriasClinicas.FirstOrDefault(e => e.Id == id);
            if (entrada != null)
            {
                _context.HistoriasClinicas.Remove(entrada);
                _context.SaveChanges();
            }

            // Si más adelante agregas RemoveEntrada al repositorio, aquí lo llamas.
            // _repo.RemoveEntrada(id);
        }
    }
}
