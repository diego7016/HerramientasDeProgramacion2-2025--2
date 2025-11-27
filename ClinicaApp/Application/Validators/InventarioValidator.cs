using ClinicaApp.Domain;
using ClinicaApp.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaApp.Application.Validators
{
    public class InventarioValidator
    {
        private readonly IMedicamentoRepository _medRepo;
        private readonly IProcedimientoRepository _procRepo;
        private readonly IAyudaDiagnosticaRepository _ayudaRepo;

        public InventarioValidator(
            IMedicamentoRepository medRepo,
            IProcedimientoRepository procRepo,
            IAyudaDiagnosticaRepository ayudaRepo)
        {
            _medRepo = medRepo;
            _procRepo = procRepo;
            _ayudaRepo = ayudaRepo;
        }

        public void ValidarNuevoMedicamento(Medicamento m)
        {
            if (string.IsNullOrWhiteSpace(m.Id))
                throw new ArgumentException("El Id del medicamento es obligatorio.");

            if (_medRepo.ExistsId(m.Id))
                throw new ArgumentException("Ya existe un medicamento con ese Id.");

            ValidarMedicamentoComun(m);
        }

        public void ValidarMedicamentoComun(Medicamento m)
        {
            if (string.IsNullOrWhiteSpace(m.Nombre))
                throw new ArgumentException("El nombre del medicamento es obligatorio.");

            if (m.Costo < 0)
                throw new ArgumentException("El costo del medicamento no puede ser negativo.");
        }

        public void ValidarNuevoProcedimiento(Procedimiento p)
        {
            if (string.IsNullOrWhiteSpace(p.Id))
                throw new ArgumentException("El Id del procedimiento es obligatorio.");

            if (_procRepo.ExistsId(p.Id))
                throw new ArgumentException("Ya existe un procedimiento con ese Id.");

            ValidarProcedimientoComun(p);
        }

        public void ValidarProcedimientoComun(Procedimiento p)
        {
            if (string.IsNullOrWhiteSpace(p.Nombre))
                throw new ArgumentException("El nombre del procedimiento es obligatorio.");

            if (p.Costo < 0)
                throw new ArgumentException("El costo del procedimiento no puede ser negativo.");

            if (p.RequiereEspecialista && string.IsNullOrWhiteSpace(p.IdTipoEspecialista))
                throw new ArgumentException("Debe especificar el tipo de especialista requerido.");
        }

        public void ValidarNuevaAyuda(AyudaDiagnostica a)
        {
            if (string.IsNullOrWhiteSpace(a.Id))
                throw new ArgumentException("El Id de la ayuda diagnóstica es obligatorio.");

            if (_ayudaRepo.ExistsId(a.Id))
                throw new ArgumentException("Ya existe una ayuda diagnóstica con ese Id.");

            ValidarAyudaComun(a);
        }

        public void ValidarAyudaComun(AyudaDiagnostica a)
        {
            if (string.IsNullOrWhiteSpace(a.Nombre))
                throw new ArgumentException("El nombre de la ayuda diagnóstica es obligatorio.");

            if (a.Costo < 0)
                throw new ArgumentException("El costo de la ayuda diagnóstica no puede ser negativo.");

            if (a.RequiereEspecialista && string.IsNullOrWhiteSpace(a.IdTipoEspecialista))
                throw new ArgumentException("Debe especificar el tipo de especialista requerido.");
        }
    }
}
