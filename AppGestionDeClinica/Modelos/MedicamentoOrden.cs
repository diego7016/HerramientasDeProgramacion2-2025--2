using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionDeClinica.Modelos
{
    public class MedicamentoOrden : ItemOrden
    
    {
        public string IdMedicamento { get; set; }
        public string Dosis { get; set; }
        public string Duracion { get; set; } // ejemplo: "5 días"

        public  MedicamentoOrden()
        {
            Tipo = TipoItemOrden.Medicamento;
        }

    }
}
