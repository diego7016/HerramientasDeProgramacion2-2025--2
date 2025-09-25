using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionDeClinica.Modelos
{
    public class AyudaDiagnosticaOrden : ItemOrden
    {
        public string IdExamen { get; set; }
        public int Cantidad { get; set; }

        public AyudaDiagnosticaOrden()
        {
            Tipo = TipoItemOrden.AyudaDiagnostica;
        }
    }
}
