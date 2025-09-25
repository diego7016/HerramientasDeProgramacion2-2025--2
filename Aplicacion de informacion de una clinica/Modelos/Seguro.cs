using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_de_informacion_de_una_clinica.Modelos
{
    public class Seguro
    {
        public string Compania { get; set; } = "";
        public string NumeroPoliza { get; set; } = "";
        public bool Activo { get; set; } = false;
        public DateTime FechaVencimiento { get; set; }
    }
}
