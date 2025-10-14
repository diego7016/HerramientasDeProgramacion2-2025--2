using App_De_Gestion_De_Una_Clinica.Modelos;
using App_De_Gestion_De_Una_Clinica.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_De_Gestion_De_Una_Clinica
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== DEMO Clínica – Servicios & Reglas ===\n");

            // 1) Instanciar servicios (en memoria)
            var srvUsuarios = new ServicioUsuarios();
            var srvPacientes = new ServicioPacientes();
            var srvOrdenes = new ServicioOrdenes();
            var srvFacturacion = new ServicioFacturacion();
            var srvAtenciones = new ServicioAtenciones(srvOrdenes, srvPacientes);

            // 2) Autenticar RRHH (semilla: rrhh / Admin@123)
            var rrhh = srvUsuarios.Autenticar("rrhh", "Admin@123");
            Console.WriteLine(rrhh != null
                ? "Login RRHH OK: " + rrhh.NombreCompleto + " (" + rrhh.Rol + ")"
                : "ERROR: No se pudo autenticar RRHH");

            // 3) Crear usuario médico (por RRHH)
            var medico = new Usuario
            {
                NombreUsuario = "medico1",
                NombreCompleto = "Dra. Gómez",
                Cedula = "222000111",
                Correo = "dra.gomez@ips.com",
                Telefono = "1234567890",
                Direccion = "Calle 1 # 2-3",
                Rol = RolUsuario.Medico
            };
            var rCrearMedico = srvUsuarios.CrearUsuario(rrhh, medico, "Medico@123");
            Console.WriteLine("Crear médico: " + rCrearMedico.mensaje);

            // 4) Registrar paciente
            var paciente = new Paciente
            {
                Cedula = "999000111",
                NombreCompleto = "Juan Pérez",
                FechaNacimiento = new DateTime(1990, 5, 10),
                Genero = "Masculino",
                Telefono = "3001234567",
                Correo = "juan.perez@mail.com",
                Direccion = "Cra 10 # 20-30",
                Poliza = new Poliza { Compania = "SURA", NumeroPoliza = "POL123", Activa = true, FechaVencimiento = DateTime.Today.AddMonths(6) },
                ContactoEmergencia = new ContactoEmergencia { Nombres = "María", Apellidos = "Pérez", Relacion = "Hermana", Telefono = "3007654321" }
            };
            var rRegPaciente = srvPacientes.RegistrarPaciente(paciente);
            Console.WriteLine("Registrar paciente: " + rRegPaciente.mensaje);

            // 5) Crear Órdenes: una de Ayuda Diagnóstica (< 50k) y una de Procedimiento (> 50k)
            var ordAyuda = new Orden { NumeroOrden = "000001", CedulaPaciente = paciente.Cedula, CedulaMedico = medico.Cedula };
            ordAyuda.Items.Add(new AyudaDiagnosticaOrden { NumeroItem = 1, Nombre = "Hemograma", IdExamen = "HEX001", Cantidad = 1, Costo = 35000m });
            Console.WriteLine("Crear orden Ayuda: " + srvOrdenes.CrearOrden(ordAyuda).mensaje);

            var ordProc = new Orden { NumeroOrden = "000002", CedulaPaciente = paciente.Cedula, CedulaMedico = medico.Cedula };
            ordProc.Items.Add(new ProcedimientoOrden { NumeroItem = 1, Nombre = "Curación", IdProcedimiento = "PROC10", Veces = 1, Frecuencia = "Única", Costo = 120000m });
            Console.WriteLine("Crear orden Procedimiento: " + srvOrdenes.CrearOrden(ordProc).mensaje);

            // 6) Intentar una ATENCIÓN con ambas órdenes (debe FALLAR por exclusividad)
            var atencionFallida = new RegistroClinico
            {
                Fecha = DateTime.Now,
                CedulaMedico = medico.Cedula,
                MotivoConsulta = "Dolor general",
                Sintomas = "Cefalea, malestar",
                Diagnostico = "" // vacío a propósito porque hay ayuda diagnóstica
            };
            var rAtencionFail = srvAtenciones.RegistrarAtencion(paciente.Cedula, atencionFallida, new List<string> { "000001", "000002" });
            Console.WriteLine("\nAtención con ayuda + procedimiento (misma atención): " + rAtencionFail.mensaje);

            // 7) Registrar ATENCIÓN solo con Ayuda Diagnóstica (DEBE PASAR)
            var atencionAyuda = new RegistroClinico
            {
                Fecha = DateTime.Now,
                CedulaMedico = medico.Cedula,
                MotivoConsulta = "Análisis de laboratorio",
                Sintomas = "Cansancio",
                Diagnostico = ""
            };
            var rAtencionAyuda = srvAtenciones.RegistrarAtencion(paciente.Cedula, atencionAyuda, new List<string> { "000001" });
            Console.WriteLine("Atención solo con ayuda diagnóstica: " + rAtencionAyuda.mensaje);

            // 8) Registrar ATENCIÓN solo con Procedimiento (DEBE PASAR)
            var atencionProc = new RegistroClinico
            {
                Fecha = DateTime.Now.AddMinutes(10),
                CedulaMedico = medico.Cedula,
                MotivoConsulta = "Curación",
                Sintomas = "Herida superficial",
                Diagnostico = "Herida leve"
            };
            var rAtencionProc = srvAtenciones.RegistrarAtencion(paciente.Cedula, atencionProc, new List<string> { "000002" });
            Console.WriteLine("Atención solo con procedimiento: " + rAtencionProc.mensaje);

            // 9) Facturación:
            // 9.1) Factura con total < 50k (Ayuda) -> copago = total (si aún no superó tope anual)
            var factura1 = srvFacturacion.GenerarFactura(paciente, new List<Orden> { ordAyuda }, medico);
            Console.WriteLine("\n--- FACTURA 1 (Ayuda, total 35k) ---");
            ImprimirFactura(factura1);

            // 9.2) Factura con total > 50k (Procedimiento) -> copago = 50k (si tope disponible)
            var factura2 = srvFacturacion.GenerarFactura(paciente, new List<Orden> { ordProc }, medico);
            Console.WriteLine("\n--- FACTURA 2 (Procedimiento, total 120k) ---");
            ImprimirFactura(factura2);

            // 10) Mostrar historia clínica del paciente (en memoria)
            var historia = srvAtenciones.ObtenerAtencionesPorPaciente(paciente.Cedula);
            Console.WriteLine("\n=== Historia clínica (en memoria) ===");
            for (int i = 0; i < historia.Count; i++)
            {
                var h = historia[i];
                Console.WriteLine(
                    "[" + (i + 1) + "] " + h.Fecha.ToString("yyyy-MM-dd HH:mm") +
                    " - Med:" + h.CedulaMedico +
                    " - Motivo: " + h.MotivoConsulta +
                    " - Órdenes: " + (h.NumerosOrden != null ? string.Join(",", h.NumerosOrden.ToArray()) : "(ninguna)")
                );
            }

            Console.WriteLine("\n=== FIN DEMO ===");
            Console.WriteLine("Presiona una tecla para salir...");
            //Console.ReadKey();
        }

        static void ImprimirFactura(Factura f)
        {
            Console.WriteLine("Paciente: " + f.NombrePaciente + " (CC " + f.CedulaPaciente + "), Edad: " + f.EdadPaciente);
            Console.WriteLine("Médico: " + (f.NombreMedico ?? "(no informado)") + " - CC: " + (f.CedulaMedico ?? "(no informado)"));
            Console.WriteLine("Seguro: " + (f.CompaniaSeguro ?? "(sin póliza)") +
                              " / Póliza: " + (f.NumeroPoliza ?? "-") +
                              " / Días vigencia: " + f.DiasVigenciaPoliza +
                              " / Fecha fin: " + (f.FechaFinPoliza.HasValue ? f.FechaFinPoliza.Value.ToString("yyyy-MM-dd") : "-"));
            Console.WriteLine("Total: " + f.Total.ToString("C") +
                              " | Copago: " + f.Copago.ToString("C") +
                              " | Aseguradora: " + f.Aseguradora.ToString("C"));
            Console.WriteLine("Detalle:");
            foreach (var d in f.Detalles) Console.WriteLine("  - " + d);
        }
    }

}

