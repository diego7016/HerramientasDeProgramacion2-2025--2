using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionDeClinica.Modelos
{
    public class RegistroClinico
    {
        public DateTime Fecha { get; set; }           // clave secundaria
        public string CedulaMedico { get; set; }      // máx 10 dígitos
        public string MotivoConsulta { get; set; }
        public string Sintomas { get; set; }
        public string Diagnostico { get; set; }

        public List<string> NumerosOrden { get; set; } = new List<string>();
    }
}
