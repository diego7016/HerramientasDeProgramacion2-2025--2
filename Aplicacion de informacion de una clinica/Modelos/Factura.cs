using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_de_informacion_de_una_clinica.Modelos
{
    public class ItemFactura
    {
        public string Descripcion { get; set; } = "";
        public decimal Monto { get; set; } = 0m;
    }

    public class Factura
    {
        public int NumeroFactura { get; set; }
        public string CedulaPaciente { get; set; } = "";
        public DateTime FechaEmision { get; set; } = DateTime.Now;
        public List<ItemFactura> Items { get; set; } = new();

        public decimal Total => Items?.Sum(i => i.Monto) ?? 0m;

        public override string ToString() => $"Factura {NumeroFactura} - Paciente {CedulaPaciente} - Total {Total:C2}";
    }
}
