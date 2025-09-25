using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_de_informacion_de_una_clinica.Modelos
{
    public class Orden
    {
        public int NumeroOrden { get; set; }
        public string CedulaPaciente { get; set; } = "";
        public string CedulaMedico { get; set; } = "";
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public List<ItemOrden> Items { get; set; } = new();

        // Propiedad Total (necesaria en ServicioFactura)
        public decimal Total => Items?.Sum(i => i.CostoUnitario * i.Cantidad) ?? 0m;

        public override string ToString() => $"Orden {NumeroOrden} - Paciente: {CedulaPaciente} - Items: {Items.Count} - Total {Total:C2}";
    }
}
