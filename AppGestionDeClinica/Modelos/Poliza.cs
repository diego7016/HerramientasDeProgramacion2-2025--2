using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionDeClinica.Modelos
{
    public class Poliza
    {
        public string Compania { get; set; }
        public string NumeroPoliza { get; set; }
        public bool Activa { get; set; }
        public DateTime FechaVencimiento { get; set; }
    }
}
