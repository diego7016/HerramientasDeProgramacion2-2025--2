using Aplicacion_de_informacion_de_una_clinica.Modelos;
using Aplicacion_de_informacion_de_una_clinica.puertos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_de_informacion_de_una_clinica.Infraestructura
{
    public class InMemoryRepositorioClinica : IRepositorioClinica
    {
        private readonly List<Usuario> _usuarios = new();
        private readonly List<Paciente> _pacientes = new();
        private readonly List<Medicamento> _medicamentos = new();
        private readonly List<Orden> _ordenes = new();
        private readonly List<HistoriaClinica> _historias = new();
        private readonly List<Factura> _facturas = new();

        // Usuarios
        public void AgregarUsuario(Usuario usuario) => _usuarios.Add(usuario);
        public Usuario? ObtenerUsuario(string nombreUsuario) => _usuarios.FirstOrDefault(u => u.NombreUsuario == nombreUsuario);
        public void EliminarUsuario(string nombreUsuario) => _usuarios.RemoveAll(u => u.NombreUsuario == nombreUsuario);

        // Pacientes
        public void AgregarPaciente(Paciente paciente) => _pacientes.Add(paciente);
        public Paciente? ObtenerPaciente(string cedula) => _pacientes.FirstOrDefault(p => p.Cedula == cedula);
        public IEnumerable<Paciente> ListarPacientes() => _pacientes;

        // Medicamentos
        public void AgregarMedicamento(Medicamento med) => _medicamentos.Add(med);
        public Medicamento? ObtenerMedicamento(string id) => _medicamentos.FirstOrDefault(m => m.Id == id);

        // Ordenes
        public void AgregarOrden(Orden orden) => _ordenes.Add(orden);
        public Orden? ObtenerOrden(int numeroOrden) => _ordenes.FirstOrDefault(o => o.NumeroOrden == numeroOrden);
        public IEnumerable<Orden> ListarOrdenesPorPaciente(string cedulaPaciente) => _ordenes.Where(o => o.CedulaPaciente == cedulaPaciente);

        // Historias
        public void AgregarHistoria(HistoriaClinica historia) => _historias.Add(historia);
        public IEnumerable<HistoriaClinica> ListarHistoriasPaciente(string cedulaPaciente) => _historias.Where(h => h.CedulaPaciente == cedulaPaciente);

        // Facturas
        public void AgregarFactura(Factura factura) => _facturas.Add(factura);
        public IEnumerable<Factura> ObtenerFacturasPorPaciente(string cedulaPaciente) => _facturas.Where(f => f.CedulaPaciente == cedulaPaciente);
    }
}
