using Aplicacion_de_informacion_de_una_clinica.Modelos;
using Aplicacion_de_informacion_de_una_clinica.puertos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_de_informacion_de_una_clinica.Servicios
{
    public class ServicioHistoria
    {
        private readonly IRepositorioClinica _repositorio;

        public ServicioHistoria(IRepositorioClinica repositorio) => _repositorio = repositorio;

        public void AgregarHistoria(HistoriaClinica historia)
        {
            if (string.IsNullOrWhiteSpace(historia.CedulaPaciente)) throw new ArgumentException("Cédula del paciente requerida.");
            if (string.IsNullOrWhiteSpace(historia.CedulaMedico)) throw new ArgumentException("Cédula del médico requerida.");
            if (historia.Fecha == DateTime.MinValue) historia.Fecha = DateTime.Now;

            // Reglas adicionales (validaciones de ordenes asociadas, etc.) se añaden en próximas entregas
            _repositorio.AgregarHistoria(historia);
        }
    }
}
