using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaApp.Domain
{
    public class Medicamento
    {
        public string Id { get; set; } = string.Empty;          // clave en inventario
        public string Nombre { get; set; } = string.Empty;
        public string Presentacion { get; set; } = string.Empty; // ej: "Tabletas 500mg"
        public decimal Costo { get; set; }
    }
}
