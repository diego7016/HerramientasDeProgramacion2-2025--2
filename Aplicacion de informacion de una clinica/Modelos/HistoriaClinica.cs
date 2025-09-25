using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_de_informacion_de_una_clinica.Modelos
{
    public class HistoriaClinica
    {
        public string CedulaPaciente { get; set; } = "";
        public DateTime Fecha { get; set; } = DateTime.Now;
        public string CedulaMedico { get; set; } = "";
        public string MotivoConsulta { get; set; } = "";
        public string Diagnostico { get; set; } = "";
        public List<int> OrdenesAsociadas { get; set; } = new();
        public decimal? Temperatura { get; set; }  
        public string? PresionArterial { get; set; }
        public int? Pulso { get; set; }
        public int? SpO2 { get; set; }

        public override string ToString() => $"{Fecha:yyyy-MM-dd} - Paciente {CedulaPaciente} - Médico {CedulaMedico}";
    }
}
