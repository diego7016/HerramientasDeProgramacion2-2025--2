using ClinicaApp.Application.Validators;
using ClinicaApp.Domain;
using ClinicaApp.Infrastructure.Persistence;
using ClinicaApp.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClinicaApp.Application.Services
{
    public class PacienteService
    {
        private readonly IPacienteRepository _pacienteRepository;
        private readonly PacienteValidator _validator;
        private readonly ClinicaDbContext _context;

        public PacienteService(IPacienteRepository pacienteRepository, ClinicaDbContext context)
        {
            _pacienteRepository = pacienteRepository;
            _validator = new PacienteValidator(pacienteRepository);
            _context = context;
        }

        // ===================== CREATE =====================
        public void CrearPaciente(Paciente paciente)
        {
            _validator.ValidarNuevoPaciente(paciente);

            // Repo (in-memory / lógica anterior)
            _pacienteRepository.Add(paciente);

            // BD
            _context.Pacientes.Add(paciente);
            _context.SaveChanges();
        }

        // ===================== READ =====================
        public List<Paciente> ListarPacientes()
        {
            return _context.Pacientes.ToList();
        }

        public Paciente ObtenerPacientePorCedula(string cedula)
        {
            return _context.Pacientes.FirstOrDefault(p => p.Cedula == cedula);
        }

        // ===================== UPDATE =====================
        public void ActualizarPaciente(Paciente pacienteActualizado)
        {
            // si quieres más validaciones, añádelas en el validador
            var paciente = _context.Pacientes.FirstOrDefault(p => p.Cedula == pacienteActualizado.Cedula);

            if (paciente == null)
                throw new ArgumentException("No existe un paciente con esa cédula.");

            paciente.NombreCompleto = pacienteActualizado.NombreCompleto;
            paciente.FechaNacimiento = pacienteActualizado.FechaNacimiento;
            paciente.Genero = pacienteActualizado.Genero;
            paciente.Direccion = pacienteActualizado.Direccion;
            paciente.Telefono = pacienteActualizado.Telefono;
            paciente.Email = pacienteActualizado.Email;

            _context.SaveChanges();

            // mantener repo in-memory coherente si lo usas
            _pacienteRepository.Update(pacienteActualizado);
        }

        // ===================== DELETE =====================
        public void EliminarPaciente(string cedula)
        {
            var paciente = _context.Pacientes.FirstOrDefault(p => p.Cedula == cedula);
            if (paciente != null)
            {
                _context.Pacientes.Remove(paciente);
                _context.SaveChanges();
            }

            _pacienteRepository.Remove(cedula);
        }
    }
}
