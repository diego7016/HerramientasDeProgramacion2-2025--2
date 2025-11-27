using ClinicaApp.Application.Validators;
using ClinicaApp.Domain;
using ClinicaApp.Infrastructure.Persistence;
using ClinicaApp.Infrastructure.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace ClinicaApp.Application.Services
{
    public class EnfermeriaService
    {
        private readonly IRegistroEnfermeriaRepository _repo;
        private readonly EnfermeriaValidator _validator;
        private readonly ClinicaDbContext _context;

        public EnfermeriaService(IRegistroEnfermeriaRepository repo, ClinicaDbContext context)
        {
            _repo = repo;
            _validator = new EnfermeriaValidator();
            _context = context;
        }

        // ===================== CREATE =====================
        public void Registrar(RegistroEnfermeria registro)
        {
            // 1) Validar
            _validator.ValidarRegistro(registro);

            // 2) Guardar en repositorio (in-memory / lógica anterior)
            _repo.Add(registro);

            // 3) Guardar en BD (SQL Server)
            _context.RegistrosEnfermeria.Add(registro);
            _context.SaveChanges();
        }

        // ===================== READ =====================
        public IEnumerable<RegistroEnfermeria> ObtenerPorPaciente(string cedula)
        {
            // Leer desde la BD
            return _context.RegistrosEnfermeria
                           .Where(r => r.CedulaPaciente == cedula)
                           .ToList();
        }
    }
}
