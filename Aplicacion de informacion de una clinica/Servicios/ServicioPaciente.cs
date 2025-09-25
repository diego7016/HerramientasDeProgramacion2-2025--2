using Aplicacion_de_informacion_de_una_clinica.Modelos;
using Aplicacion_de_informacion_de_una_clinica.puertos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_de_informacion_de_una_clinica.Servicios
{
    public class ServicioPaciente
    {
        private readonly IRepositorioClinica _repositorio;

        public ServicioPaciente(IRepositorioClinica repositorio) => _repositorio = repositorio;

        public void RegistrarPaciente(Paciente paciente)
        {
            if (string.IsNullOrWhiteSpace(paciente.Cedula)) throw new ArgumentException("Cédula requerida.");
            if (_repositorio.ObtenerPaciente(paciente.Cedula) != null) throw new InvalidOperationException("Paciente ya registrado.");

            if (!string.IsNullOrWhiteSpace(paciente.Telefono) && paciente.Telefono.Length != 10)
                throw new ArgumentException("Teléfono debe tener 10 dígitos.");

            if (paciente.FechaNacimiento != DateTime.MinValue)
            {
                var edad = DateTime.Now.Year - paciente.FechaNacimiento.Year;
                if (paciente.FechaNacimiento > DateTime.Now.AddYears(-edad)) edad--;
                if (edad > 150) throw new ArgumentException("Edad mayor a 150 años no permitida.");
            }

            _repositorio.AgregarPaciente(paciente);
        }

        public Paciente? BuscarPaciente(string cedula) => _repositorio.ObtenerPaciente(cedula);
    }
}
