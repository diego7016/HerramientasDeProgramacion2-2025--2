using ClinicaApp.Application.Services;
using ClinicaApp.Domain;
using ClinicaApp.Domain.Enums;
using ClinicaApp.Forms;
using ClinicaApp.Infrastructure.Persistence;
using ClinicaApp.Infrastructure.Repositories;
using System;
using System.Linq; // Para Any()

namespace ClinicaApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // 1) Crear el DbContext (para SQL Server)
            ClinicaDbContext context = new ClinicaDbContext();

            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

            // ================= USUARIOS =================

            // Repositorio in-memory → usado por el LOGIN y el validador
            IUsuarioRepository usuarioRepo = new InMemoryUsuarioRepository();

            // Servicio de usuarios → repo (validaciones/login) + DbContext (SQL Server)
            var usuarioService = new UsuarioService(usuarioRepo, context);

            // ================= PACIENTES =================

            IPacienteRepository pacienteRepo = new InMemoryPacienteRepository();
            var pacienteService = new PacienteService(pacienteRepo, context);

            // ================= ORDENES =================

            IOrdenRepository ordenRepo = new InMemoryOrdenRepository();
            var ordenService = new OrdenService(ordenRepo, context);

            // ================= INVENTARIO =================

            IMedicamentoRepository medRepo = new InMemoryMedicamentoRepository();
            IProcedimientoRepository procRepo = new InMemoryProcedimientoRepository();
            IAyudaDiagnosticaRepository ayudaRepo = new InMemoryAyudaDiagnosticaRepository();

            var inventarioService = new InventarioService(medRepo, procRepo, ayudaRepo, context);

            // ================= HISTORIA CLÍNICA =================

            IHistoriaClinicaRepository historiaRepo = new InMemoryHistoriaClinicaRepository();
            var historiaService = new HistoriaClinicaService(historiaRepo, context);

            // ================= FACTURACIÓN =================

            IFacturaRepository facturaRepo = new InMemoryFacturaRepository();
            var facturacionService = new FacturacionService(facturaRepo, context);

            // ================= ENFERMERÍA =================

            IRegistroEnfermeriaRepository registroRepo = new InMemoryRegistroEnfermeriaRepository();
            var enfermeriaService = new EnfermeriaService(registroRepo, context);

            // ====== USUARIOS DE PRUEBA ======
            var admin = new Usuario
            {
                NombreCompleto = "Admin RRHH",
                Cedula = "123",
                Email = "admin@clinica.com",
                Telefono = "1234567890",
                FechaNacimiento = new DateTime(1990, 1, 1),
                Direccion = "Oficina 1",
                Rol = RolUsuario.RecursosHumanos,
                NombreUsuario = "adminrrhh",
                Contrasena = "Admin@123"      // válida
            };

            var userAdmin = new Usuario
            {
                NombreCompleto = "Juan Administrativo",
                Cedula = "2001",
                Email = "juan.admin@clinica.com",
                Telefono = "3001234567",
                FechaNacimiento = new DateTime(1995, 5, 10),
                Direccion = "Ciudad",
                Rol = RolUsuario.Administrativo,
                NombreUsuario = "juanadmin",
                Contrasena = "Admin1@1"       // ✅ ahora tiene 8 caracteres
            };

            var userMedico = new Usuario
            {
                NombreCompleto = "María Medica",
                Cedula = "3001",
                Email = "maria.medica@clinica.com",
                Telefono = "3007654321",
                FechaNacimiento = new DateTime(1988, 3, 15),
                Direccion = "Ciudad",
                Rol = RolUsuario.Medico,
                NombreUsuario = "mariam",
                Contrasena = "Medico1@"       // válida
            };

            var usuarioEnfermeraForm = new Usuario
            {
                NombreCompleto = "Usuario Enfermera",
                Cedula = "7001",
                Email = "enfermera@clinica.com",
                Telefono = "3004445566",
                FechaNacimiento = new DateTime(2025, 11, 24),
                Direccion = "Área de Enfermería",
                Rol = RolUsuario.Enfermera,
                NombreUsuario = "enfermera1",
                Contrasena = "Enfer1@2025"    // válida
            };

            var usuarioSoporteForm = new Usuario
            {
                NombreCompleto = "Usuario Soporte Información",
                Cedula = "8001",
                Email = "soporte.info@clinica.com",
                Telefono = "3005556677",
                FechaNacimiento = new DateTime(2025, 11, 24),
                Direccion = "Área de Sistemas",
                Rol = RolUsuario.SoporteInformacion,
                NombreUsuario = "soporteinfo1",
                Contrasena = "Soporte1@2025"  // válida
            };

            // ====== SEED USUARIOS SOLO SI NO EXISTEN ======
            if (!context.Usuarios.Any(u => u.Cedula == admin.Cedula))
                usuarioService.CrearUsuario(admin);

            if (!context.Usuarios.Any(u => u.Cedula == userAdmin.Cedula))
                usuarioService.CrearUsuario(userAdmin);

            if (!context.Usuarios.Any(u => u.Cedula == userMedico.Cedula))
                usuarioService.CrearUsuario(userMedico);

            if (!context.Usuarios.Any(u => u.Cedula == usuarioEnfermeraForm.Cedula))
                usuarioService.CrearUsuario(usuarioEnfermeraForm);

            if (!context.Usuarios.Any(u => u.Cedula == usuarioSoporteForm.Cedula))
                usuarioService.CrearUsuario(usuarioSoporteForm);

            // ====== PACIENTES DE PRUEBA ======
            var paciente1 = new Paciente
            {
                Cedula = "1045432612",
                NombreCompleto = "Pedro Juan",
                FechaNacimiento = new DateTime(1990, 1, 1),
                Genero = Genero.Masculino,
                Direccion = "Medellín",
                Telefono = "3108949201",
                Email = "pedro@gmail.com"
            };

            var paciente2 = new Paciente
            {
                Cedula = "5555555555",
                NombreCompleto = "Ana Paciente",
                FechaNacimiento = new DateTime(1985, 6, 20),
                Genero = Genero.Femenino,
                Direccion = "Bogotá",
                Telefono = "3012345678",
                Email = "ana@paciente.com"
            };

            if (!context.Pacientes.Any(p => p.Cedula == paciente1.Cedula))
                pacienteService.CrearPaciente(paciente1);

            if (!context.Pacientes.Any(p => p.Cedula == paciente2.Cedula))
                pacienteService.CrearPaciente(paciente2);

            // ======================
            //     LOGIN ORIGINAL
            // ======================
            System.Windows.Forms.Application.Run(
                new LoginForm(usuarioService, pacienteService)
            );
        }
    }
}
