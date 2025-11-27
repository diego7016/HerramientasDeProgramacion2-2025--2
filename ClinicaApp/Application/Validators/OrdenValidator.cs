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
    public class OrdenValidator
    {
        private readonly IOrdenRepository _ordenRepository;

        public OrdenValidator(IOrdenRepository ordenRepository)
        {
            _ordenRepository = ordenRepository;
        }

        public void ValidarNuevaOrden(OrdenMedica orden)
        {
            // Número de orden: máximo 6 dígitos
            if (!Regex.IsMatch(orden.NumeroOrden.ToString(), @"^\d{1,6}$"))
                throw new ArgumentException("El número de orden debe tener máximo 6 dígitos.");

            if (string.IsNullOrWhiteSpace(orden.CedulaPaciente))
                throw new ArgumentException("La cédula del paciente es obligatoria.");

            if (string.IsNullOrWhiteSpace(orden.CedulaMedico))
                throw new ArgumentException("La cédula del médico es obligatoria.");

            if (_ordenRepository.ExisteNumeroOrden(orden.NumeroOrden))
                throw new ArgumentException("Ya existe una orden con ese número.");

            // Regla: cuando hay ayudas diagnósticas, no se pueden recetar medicamentos ni procedimientos
            bool hayAyudas = orden.AyudasDiagnosticas.Any();
            bool hayMedsOProc = orden.Medicamentos.Any() || orden.Procedimientos.Any();

            if (hayAyudas && hayMedsOProc)
                throw new ArgumentException("Si la orden tiene ayudas diagnósticas, no puede contener medicamentos ni procedimientos.");

            // Regla: ítems únicos dentro de la orden
            // Nosotros asignaremos los Item de 1..N en el servicio para garantizarlo
        }
    }
}
