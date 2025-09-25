using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_de_informacion_de_una_clinica.Modelos
{
    public class Medicamento
    {
        public string Id { get; set; } = "";
        public string Nombre { get; set; } = "";
        public decimal Costo { get; set; } = 0m;
        public string Presentacion { get; set; } = "";
    }
}
