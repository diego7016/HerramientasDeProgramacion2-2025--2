using ClinicaApp.Domain;
using ClinicaApp.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClinicaApp.Application.Validators
{
    public class PacienteValidator
    {
        private readonly IPacienteRepository _pacienteRepository;

        public PacienteValidator(IPacienteRepository pacienteRepository)
        {
            _pacienteRepository = pacienteRepository;
        }

        public void ValidarNuevoPaciente(Paciente paciente)
        {
            if (string.IsNullOrWhiteSpace(paciente.Cedula))
                throw new ArgumentException("La cédula del paciente es obligatoria.");

            if (_pacienteRepository.ExistsCedula(paciente.Cedula))
                throw new ArgumentException("Ya existe un paciente con esa cédula.");

            ValidarDatosComunes(paciente);
        }

        public void ValidarPacienteExistente(Paciente paciente)
        {
            if (string.IsNullOrWhiteSpace(paciente.Cedula))
                throw new ArgumentException("La cédula del paciente es obligatoria.");

            ValidarDatosComunes(paciente);
        }

        private void ValidarDatosComunes(Paciente paciente)
        {
            if (string.IsNullOrWhiteSpace(paciente.NombreCompleto))
                throw new ArgumentException("El nombre completo del paciente es obligatorio.");

            int edad = paciente.CalcularEdad();
            if (edad < 0 || edad > 150)
                throw new ArgumentException("La edad del paciente no es válida (0-150 años).");

            if (string.IsNullOrWhiteSpace(paciente.Direccion))
                throw new ArgumentException("La dirección es obligatoria.");

            // Teléfono: exactamente 10 dígitos
            if (!Regex.IsMatch(paciente.Telefono, @"^\d{10}$"))
                throw new ArgumentException("El teléfono del paciente debe tener exactamente 10 dígitos.");

            // Email: si no está vacío, validar formato
            if (!string.IsNullOrWhiteSpace(paciente.Email) &&
                !Regex.IsMatch(paciente.Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                throw new ArgumentException("El correo electrónico del paciente no es válido.");
            }

            // Contacto de emergencia (si se especifica)
            if (paciente.ContactoEmergencia != null)
            {
                if (string.IsNullOrWhiteSpace(paciente.ContactoEmergencia.NombreCompleto))
                    throw new ArgumentException("El nombre del contacto de emergencia es obligatorio.");

                if (string.IsNullOrWhiteSpace(paciente.ContactoEmergencia.Relacion))
                    throw new ArgumentException("La relación del contacto de emergencia es obligatoria.");

                if (!Regex.IsMatch(paciente.ContactoEmergencia.Telefono, @"^\d{10}$"))
                    throw new ArgumentException("El teléfono de emergencia debe tener exactamente 10 dígitos.");
            }

            // Póliza de seguro (si se especifica)
            if (paciente.PolizaSeguro != null)
            {
                if (string.IsNullOrWhiteSpace(paciente.PolizaSeguro.CompaniaSeguros))
                    throw new ArgumentException("El nombre de la compañía de seguros es obligatorio.");

                if (string.IsNullOrWhiteSpace(paciente.PolizaSeguro.NumeroPoliza))
                    throw new ArgumentException("El número de póliza es obligatorio.");

                // Vigencia fin no puede ser fecha muy vieja (opcional, aquí solo verificamos que sea >= hoy - 50 años)
                if (paciente.PolizaSeguro.FechaVigenciaFin < new DateTime(1900, 1, 1))
                    throw new ArgumentException("La fecha de vigencia de la póliza no es válida.");
            }
        }
    }
}

