using ClinicaApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaApp.Application.Validators
{
    public class EnfermeriaValidator
    {
        public void ValidarRegistro(RegistroEnfermeria reg)
        {
            if (string.IsNullOrWhiteSpace(reg.CedulaPaciente))
                throw new ArgumentException("La cédula del paciente es obligatoria.");

            if (reg.NumeroOrden <= 0)
                throw new ArgumentException("El número de orden es obligatorio.");

            if (reg.ItemOrden <= 0)
                throw new ArgumentException("El Ítem de la orden es obligatorio.");

            if (reg.Signos.Temperatura < 30 || reg.Signos.Temperatura > 45)
                throw new ArgumentException("Temperatura fuera de rango.");

            if (reg.Signos.Pulso < 30 || reg.Signos.Pulso > 200)
                throw new ArgumentException("Pulso fuera de rango.");

            if (reg.Signos.SpO2 < 50 || reg.Signos.SpO2 > 100)
                throw new ArgumentException("SpO2 fuera de rango.");
        }
    }
}
