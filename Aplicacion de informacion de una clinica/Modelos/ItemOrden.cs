using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_de_informacion_de_una_clinica.Modelos
{
    public enum TipoItem { Medicamento, Procedimiento, AyudaDiagnostica }
    public class ItemOrden
    {
        public int NumeroItem { get; set; }
        public TipoItem Tipo { get; set; }
        public string IdInventario { get; set; } = "";
        public int Cantidad { get; set; } = 1;
        public decimal CostoUnitario { get; set; } = 0m;
    }
}
