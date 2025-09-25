using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aplicacion_de_informacion_de_una_clinica.Modelos;

namespace Aplicacion_de_informacion_de_una_clinica.puertos
{

    public interface IRepositorioClinica
    {
        // Usuarios
        void AgregarUsuario(Usuario usuario);
        Usuario? ObtenerUsuario(string nombreUsuario);
        void EliminarUsuario(string nombreUsuario);

        // Pacientes
        void AgregarPaciente(Paciente paciente);
        Paciente? ObtenerPaciente(string cedula);
        IEnumerable<Paciente> ListarPacientes();

        // Inventario (ejemplo: medicamentos)
        void AgregarMedicamento(Medicamento med);
        Medicamento? ObtenerMedicamento(string id);

        // Ordenes
        void AgregarOrden(Orden orden);
        Orden? ObtenerOrden(int numeroOrden);
        IEnumerable<Orden> ListarOrdenesPorPaciente(string cedulaPaciente);

        // Historia clínica (NoSQL-simulado)
        void AgregarHistoria(HistoriaClinica historia);
        IEnumerable<HistoriaClinica> ListarHistoriasPaciente(string cedulaPaciente);


        // Facturas (añadir estas firmas)
        void AgregarFactura(Factura factura);
        IEnumerable<Factura> ObtenerFacturasPorPaciente(string cedulaPaciente);

    }

}
