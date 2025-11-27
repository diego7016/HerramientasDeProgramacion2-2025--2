using ClinicaApp.Application.Validators;
using ClinicaApp.Domain;
using ClinicaApp.Infrastructure.Persistence;
using ClinicaApp.Infrastructure.Repositories;
using System;

namespace ClinicaApp.Application.Services
{
    public class OrdenService
    {
        private readonly IOrdenRepository _ordenRepository;
        private readonly OrdenValidator _validator;
        private readonly ClinicaDbContext _context;

        public OrdenService(IOrdenRepository ordenRepository, ClinicaDbContext context)
        {
            _ordenRepository = ordenRepository;
            _validator = new OrdenValidator(ordenRepository);
            _context = context;
        }

        // ===================== CREATE =====================
        public void CrearOrden(OrdenMedica orden)
        {
            // 1) Asignar ítems secuenciales únicos dentro de la orden
            int item = 1;

            // Medicamentos
            foreach (var med in orden.Medicamentos)
            {
                med.NumeroOrden = orden.NumeroOrden;
                med.Item = item++;
            }

            // Procedimientos
            foreach (var proc in orden.Procedimientos)
            {
                proc.NumeroOrden = orden.NumeroOrden;
                proc.Item = item++;
            }

            // Ayudas diagnósticas
            foreach (var ay in orden.AyudasDiagnosticas)
            {
                ay.NumeroOrden = orden.NumeroOrden;
                ay.Item = item++;
            }

            // 2) Validar la orden completa
            _validator.ValidarNuevaOrden(orden);

            // 3) Guardar en repositorio (lógica en memoria que ya usabas)
            _ordenRepository.AddOrden(orden);

            // 4) Guardar en BD (SQL Server)
            _context.Ordenes.Add(orden);

            foreach (var m in orden.Medicamentos)
                _context.OrdenMedicamentos.Add(m);

            foreach (var p in orden.Procedimientos)
                _context.OrdenProcedimientos.Add(p);

            foreach (var a in orden.AyudasDiagnosticas)
                _context.OrdenAyudasDiagnosticas.Add(a);

            _context.SaveChanges();
        }

        // ===================== READ =====================
        public OrdenMedica ObtenerOrden(int numeroOrden)
        {
            // Se mantiene como estaba: usando el repositorio
            return _ordenRepository.GetOrden(numeroOrden);
        }
    }
}
