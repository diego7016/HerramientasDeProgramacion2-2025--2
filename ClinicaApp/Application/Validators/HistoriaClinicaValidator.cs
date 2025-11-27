using ClinicaApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClinicaApp.Application.Validators
{
    public class HistoriaClinicaValidator
    {
        public void ValidarNuevaEntrada(HistoriaClinicaEntrada entrada)
        {
            if (string.IsNullOrWhiteSpace(entrada.CedulaPaciente))
                throw new ArgumentException("La cédula del paciente es obligatoria.");

            if (string.IsNullOrWhiteSpace(entrada.CedulaMedico))
                throw new ArgumentException("La cédula del médico es obligatoria.");

            if (!Regex.IsMatch(entrada.CedulaMedico, @"^\d{1,10}$"))
                throw new ArgumentException("La cédula del médico debe tener máximo 10 dígitos y solo números.");

            if (string.IsNullOrWhiteSpace(entrada.MotivoConsulta))
                throw new ArgumentException("El motivo de la consulta es obligatorio.");

            if (string.IsNullOrWhiteSpace(entrada.Sintomatologia))
                throw new ArgumentException("La sintomatología es obligatoria.");

            if (string.IsNullOrWhiteSpace(entrada.Diagnostico))
                throw new ArgumentException("El diagnóstico es obligatorio.");
        }
    }
}

