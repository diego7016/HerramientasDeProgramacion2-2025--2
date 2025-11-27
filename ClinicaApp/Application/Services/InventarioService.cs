using ClinicaApp.Application.Validators;
using ClinicaApp.Domain;
using ClinicaApp.Infrastructure.Persistence;
using ClinicaApp.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClinicaApp.Application.Services
{
    public class InventarioService
    {
        private readonly IMedicamentoRepository _medRepo;
        private readonly IProcedimientoRepository _procRepo;
        private readonly IAyudaDiagnosticaRepository _ayudaRepo;
        private readonly InventarioValidator _validator;
        private readonly ClinicaDbContext _context;

        public InventarioService(
            IMedicamentoRepository medRepo,
            IProcedimientoRepository procRepo,
            IAyudaDiagnosticaRepository ayudaRepo,
            ClinicaDbContext context)
        {
            _medRepo = medRepo;
            _procRepo = procRepo;
            _ayudaRepo = ayudaRepo;
            _validator = new InventarioValidator(medRepo, procRepo, ayudaRepo);
            _context = context;
        }

        // ===================== MEDICAMENTOS =====================

        public void CrearMedicamento(Medicamento m)
        {
            // 1) Validar
            _validator.ValidarNuevoMedicamento(m);

            // 2) Guardar en repositorio (in-memory / lógica anterior)
            _medRepo.Add(m);

            // 3) Guardar en BD (SQL Server)
            _context.Medicamentos.Add(m);
            _context.SaveChanges();
        }

        public void ActualizarMedicamento(Medicamento m)
        {
            // 1) Validar reglas comunes
            _validator.ValidarMedicamentoComun(m);

            // 2) Actualizar en repositorio
            _medRepo.Update(m);

            // 3) Actualizar en BD
            _context.Medicamentos.Update(m);
            _context.SaveChanges();
        }

        public void EliminarMedicamento(string id)
        {
            // 1) Eliminar de BD
            var med = _context.Medicamentos.FirstOrDefault(x => x.Id == id);
            if (med != null)
            {
                _context.Medicamentos.Remove(med);
                _context.SaveChanges();
            }

            // 2) Eliminar de repositorio
            _medRepo.Remove(id);
        }

        public IEnumerable<Medicamento> ListarMedicamentos()
        {
            // Leer desde la BD
            return _context.Medicamentos.ToList();
        }

        public Medicamento ObtenerMedicamento(string id)
        {
            return _context.Medicamentos.FirstOrDefault(m => m.Id == id);
        }

        // ===================== PROCEDIMIENTOS =====================

        public void CrearProcedimiento(Procedimiento p)
        {
            _validator.ValidarNuevoProcedimiento(p);

            _procRepo.Add(p);                 // repositorio
            _context.Procedimientos.Add(p);   // BD
            _context.SaveChanges();
        }

        public void ActualizarProcedimiento(Procedimiento p)
        {
            _validator.ValidarProcedimientoComun(p);

            _procRepo.Update(p);                  // repositorio
            _context.Procedimientos.Update(p);    // BD
            _context.SaveChanges();
        }

        public void EliminarProcedimiento(string id)
        {
            var proc = _context.Procedimientos.FirstOrDefault(x => x.Id == id);
            if (proc != null)
            {
                _context.Procedimientos.Remove(proc);
                _context.SaveChanges();
            }

            _procRepo.Remove(id);
        }

        public IEnumerable<Procedimiento> ListarProcedimientos()
        {
            return _context.Procedimientos.ToList();
        }

        public Procedimiento ObtenerProcedimiento(string id)
        {
            return _context.Procedimientos.FirstOrDefault(p => p.Id == id);
        }

        // ===================== AYUDAS DIAGNÓSTICAS =====================

        public void CrearAyuda(AyudaDiagnostica a)
        {
            _validator.ValidarNuevaAyuda(a);

            _ayudaRepo.Add(a);                    // repositorio
            _context.AyudasDiagnosticas.Add(a);   // BD
            _context.SaveChanges();
        }

        public void ActualizarAyuda(AyudaDiagnostica a)
        {
            _validator.ValidarAyudaComun(a);

            _ayudaRepo.Update(a);                     // repositorio
            _context.AyudasDiagnosticas.Update(a);    // BD
            _context.SaveChanges();
        }

        public void EliminarAyuda(string id)
        {
            var ayuda = _context.AyudasDiagnosticas.FirstOrDefault(x => x.Id == id);
            if (ayuda != null)
            {
                _context.AyudasDiagnosticas.Remove(ayuda);
                _context.SaveChanges();
            }

            _ayudaRepo.Remove(id);
        }

        public IEnumerable<AyudaDiagnostica> ListarAyudas()
        {
            return _context.AyudasDiagnosticas.ToList();
        }

        public AyudaDiagnostica ObtenerAyuda(string id)
        {
            return _context.AyudasDiagnosticas.FirstOrDefault(a => a.Id == id);
        }
    }
}

