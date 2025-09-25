using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionDeClinica.Modelos
{
    public  abstract  class  ItemOrden
    {
        public int NumeroItem { get; set; } // empieza en 1
        public string Nombre { get; set; }
        public decimal Costo { get; set; }
        public TipoItemOrden Tipo { get; protected set; }
    }
}
