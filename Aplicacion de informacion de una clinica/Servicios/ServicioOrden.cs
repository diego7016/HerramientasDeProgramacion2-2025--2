using Aplicacion_de_informacion_de_una_clinica.Modelos;
using Aplicacion_de_informacion_de_una_clinica.puertos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_de_informacion_de_una_clinica.Servicios
{
    public class ServicioOrden
    {
        private readonly IRepositorioClinica _repositorio;

        public ServicioOrden(IRepositorioClinica repositorio) => _repositorio = repositorio;

        public void CrearOrden(Orden orden)
        {
            if (orden.NumeroOrden <= 0 || orden.NumeroOrden > 999999) throw new ArgumentException("Número de orden inválido (máx 6 dígitos).");
            if (_repositorio.ObtenerOrden(orden.NumeroOrden) != null) throw new InvalidOperationException("Número de orden ya existe.");

            bool tieneAyuda = orden.Items.Any(i => i.Tipo == TipoItem.AyudaDiagnostica);
            bool tieneMedProc = orden.Items.Any(i => i.Tipo == TipoItem.Medicamento || i.Tipo == TipoItem.Procedimiento);

            if (tieneAyuda && tieneMedProc)
                throw new InvalidOperationException("No puede mezclar ayuda diagnóstica con medicamentos/procedimientos en la misma orden.");

            // Verificar unicidad de número de ítem en la orden
            var duplicados = orden.Items.GroupBy(i => i.NumeroItem).Where(g => g.Count() > 1).ToList();
            if (duplicados.Any()) throw new InvalidOperationException("Números de ítem duplicados dentro de la orden.");

            // Verificar existencia en inventario y asignar costo unitario
            foreach (var item in orden.Items)
            {
                if (item.Tipo == TipoItem.Medicamento)
                {
                    var med = _repositorio.ObtenerMedicamento(item.IdInventario) ?? throw new InvalidOperationException($"Medicamento {item.IdInventario} no existe.");
                    item.CostoUnitario = med.Costo;
                }
                // Para Procedimiento/AyudaDiagnostica se pueden agregar validaciones similares en próximas entregas
            }

            _repositorio.AgregarOrden(orden);
        }
    }
}
