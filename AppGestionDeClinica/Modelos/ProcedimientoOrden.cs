using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionDeClinica.Modelos
{
    public class ProcedimientoOrden : ItemOrden
    {
        public string IdProcedimiento { get; set; }
        public int Veces { get; set; }
        public string Frecuencia { get; set; }
        public bool RequiereEspecialista { get; set; }
        public int? IdEspecialidad { get; set; }

        public ProcedimientoOrden()
        {
            Tipo = TipoItemOrden.Procedimiento;
        }
    }
}
