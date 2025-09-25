using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionDeClinica.Modelos
{
   public class Orden
    {
        public string NumeroOrden { get; set; }      // máx 6 dígitos
        public string CedulaPaciente { get; set; }
        public string CedulaMedico { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;

        public List<ItemOrden> Items { get; set; } = new List<ItemOrden>();

    }
}
