using Aplicacion_de_informacion_de_una_clinica.Modelos;
using Aplicacion_de_informacion_de_una_clinica.puertos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_de_informacion_de_una_clinica.Servicios
{
    public class ServicioFactura
    {
        private readonly IRepositorioClinica _repositorio;
        private const decimal CopagoFijo = 50000m;
        private const decimal TopeAnualCopago = 1000000m;

        public  ServicioFactura(IRepositorioClinica repositorio) => _repositorio = repositorio;

        public Factura GenerarFacturaPorOrden(int numeroOrden)
        {
            var orden = _repositorio.ObtenerOrden(numeroOrden) ?? throw new InvalidOperationException("Orden no existe.");
            var paciente = _repositorio.ObtenerPaciente(orden.CedulaPaciente) ?? throw new InvalidOperationException("Paciente no existe.");

            decimal totalOrden = orden.Total;
            var factura = new Factura
            {
                NumeroFactura = new Random().Next(100000, 999999),
                CedulaPaciente = paciente.Cedula,
                FechaEmision = DateTime.Now
            };

            // Detallar cargos por items
            foreach (var it in orden.Items)
            {
                factura.Items.Add(new ItemFactura { Descripcion = $"{it.Tipo} - {it.IdInventario} x{it.Cantidad}", Monto = it.CostoUnitario * it.Cantidad });
            }

            // Lógica: si tiene póliza activa -> copago 50k y resto a aseguradora (mostrar detalle).
            if (paciente.Seguro != null && paciente.Seguro.Activo && paciente.Seguro.FechaVencimiento >= DateTime.Now)
            {
                // Sumar copagos ya pagados en el año actual
                var facturasAnio = _repositorio.ObtenerFacturasPorPaciente(paciente.Cedula).Where(f => f.FechaEmision.Year == DateTime.Now.Year);
                decimal copagosPagados = facturasAnio.Sum(f => f.Items.Where(i => i.Descripcion.Contains("COPAGO")).Sum(i => i.Monto));

                if (copagosPagados >= TopeAnualCopago)
                {
                    factura.Items.Add(new ItemFactura { Descripcion = "COPAGO exento (tope anual superado)", Monto = 0m });
                }
                else
                {
                    decimal copagoACobrar = Math.Min(CopagoFijo, TopeAnualCopago - copagosPagados);
                    factura.Items.Add(new ItemFactura { Descripcion = "COPAGO", Monto = copagoACobrar });
                    factura.Items.Add(new ItemFactura { Descripcion = "Aseguradora - cobertura", Monto = Math.Max(0, totalOrden - copagoACobrar) });
                }
            }
            else
            {
                // Sin póliza: paciente paga todo
                factura.Items.Add(new ItemFactura { Descripcion = "PAGO TOTAL (sin aseguradora)", Monto = totalOrden });
            }

            _repositorio.AgregarFactura(factura);
            return factura;
        }

        public IEnumerable<Factura> ObtenerFacturasPaciente(string cedula) => _repositorio.ObtenerFacturasPorPaciente(cedula);
    }
}
