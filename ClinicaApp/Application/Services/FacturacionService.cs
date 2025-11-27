using ClinicaApp.Domain;
using ClinicaApp.Domain.Enums;
using ClinicaApp.Infrastructure.Persistence;
using ClinicaApp.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClinicaApp.Application.Services
{
    public class FacturacionService
    {
        private readonly IFacturaRepository _facturaRepository;
        private readonly ClinicaDbContext _context;

        public FacturacionService(IFacturaRepository facturaRepository, ClinicaDbContext context)
        {
            _facturaRepository = facturaRepository;
            _context = context;
        }

        // ===================== COPAGOS ANUALES =====================
        public decimal ObtenerTotalCopagosAnio(string cedulaPaciente, int anio)
        {
            // Ahora lo calculamos sobre la BD para que sea persistente.
            return _context.Facturas
                           .Where(f => f.CedulaPaciente == cedulaPaciente
                                    && f.FechaFactura.Year == anio)
                           .Sum(f => f.CopagoPaciente);
        }

        // ===================== CÁLCULO DE FACTURA (SOLO LÓGICA) =====================
        public Factura CalcularFactura(
            string numeroFactura,
            Paciente paciente,
            string nombreMedicoTratante,
            PolizaSeguro poliza,
            IList<DetalleFacturaItem> detalles,
            DateTime fechaFactura)
        {
            if (string.IsNullOrWhiteSpace(numeroFactura))
                throw new ArgumentException("El número de factura es obligatorio.");

            if (paciente == null)
                throw new ArgumentException("Debe seleccionar un paciente.");

            if (detalles == null || detalles.Count == 0)
                throw new ArgumentException("Debe seleccionar al menos un ítem para facturar.");

            decimal totalServicios = detalles.Sum(d => d.Costo);

            var factura = new Factura
            {
                NumeroFactura = numeroFactura,
                CedulaPaciente = paciente.Cedula,
                NombrePaciente = paciente.NombreCompleto,
                EdadPaciente = paciente.CalcularEdad(),
                NombreMedicoTratante = nombreMedicoTratante,
                TotalServicios = totalServicios,
                FechaFactura = fechaFactura,
                Detalles = detalles.ToList()
            };

            // Información póliza
            if (poliza != null)
            {
                factura.NombreCompaniaSeguro = poliza.CompaniaSeguros;
                factura.NumeroPoliza = poliza.NumeroPoliza;
                factura.FechaFinPoliza = poliza.FechaVigenciaFin;

                bool activa = poliza.Estado == EstadoPoliza.Activa &&
                              poliza.FechaVigenciaFin >= fechaFactura;

                factura.PolizaActiva = activa;
                factura.DiasVigenciaPoliza = (poliza.FechaVigenciaFin - fechaFactura).Days;
            }

            // Cálculo de copago
            if (totalServicios <= 0)
            {
                factura.CopagoPaciente = 0;
                factura.TotalCubreAseguradora = 0;
                return factura;
            }

            bool tienePolizaActiva = factura.PolizaActiva;

            decimal copago;
            decimal cubreAseg;

            if (!tienePolizaActiva)
            {
                // Sin póliza o inactiva → paciente paga todo
                copago = totalServicios;
                cubreAseg = 0;
            }
            else
            {
                const decimal TOPE_ANUAL = 1_000_000m;
                const decimal COPAGO_POR_FACTURA = 50_000m;

                int anio = fechaFactura.Year;
                decimal copagosPrevios = ObtenerTotalCopagosAnio(paciente.Cedula, anio);

                if (copagosPrevios >= TOPE_ANUAL)
                {
                    // Ya alcanzó el tope → no paga más copago
                    copago = 0;
                    cubreAseg = totalServicios;
                }
                else
                {
                    decimal copagoDisponible = TOPE_ANUAL - copagosPrevios;
                    decimal copagoTeorico = Math.Min(COPAGO_POR_FACTURA, totalServicios);
                    copago = Math.Min(copagoTeorico, copagoDisponible);
                    cubreAseg = totalServicios - copago;
                }
            }

            factura.CopagoPaciente = copago;
            factura.TotalCubreAseguradora = cubreAseg;

            return factura;
        }

        // ===================== GUARDAR FACTURA =====================
        public void GuardarFactura(Factura factura)
        {
            // 1) Guardar en repositorio (si tu lógica anterior lo usa)
            _facturaRepository.Add(factura);

            // 2) Guardar en BD (SQL Server)
            _context.Facturas.Add(factura);

            // También persistimos los detalles en la tabla DetalleFactura
            if (factura.Detalles != null)
            {
                foreach (var det in factura.Detalles)
                {
                    _context.DetalleFacturaItems.Add(det);
                }
            }

            _context.SaveChanges();
        }
    }
}
