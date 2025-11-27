using ClinicaApp.Application.Services;
using ClinicaApp.Domain;
using ClinicaApp.Domain.Enums;
using ClinicaApp.Forms.RRHH;
using System;
using System.Windows.Forms;
using ClinicaApp.Forms.Administrativo;
using ClinicaApp.Infrastructure.Repositories;
using ClinicaApp.Forms.Medico;
using ClinicaApp.Forms.Enfermeria;
using ClinicaApp.Forms.Soporte;
using ClinicaApp.Forms.Facturacion;
using ClinicaApp.Infrastructure.Persistence;   // 👈 IMPORTANTE

namespace ClinicaApp.Forms
{
    public partial class MainForm : Form
    {
        private readonly Usuario _usuarioLogueado;
        private readonly UsuarioService _usuarioService;
        private readonly PacienteService _pacienteService;

        // 👇 Contexto para los servicios que creamos aquí
        private readonly ClinicaDbContext _context;

        public MainForm(Usuario usuarioLogueado, UsuarioService usuarioService, PacienteService pacienteService)
        {
            InitializeComponent();
            _usuarioLogueado = usuarioLogueado;
            _usuarioService = usuarioService;
            _pacienteService = pacienteService;

            // Puedes usar un solo contexto por MainForm
            _context = new ClinicaDbContext();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblBienvenida.Text = $"Bienvenido, {_usuarioLogueado.NombreCompleto} (Rol: {_usuarioLogueado.Rol})";

            btnRRHH.Enabled = false;
            btnAdministrativo.Enabled = false;
            btnSoporteInfo.Enabled = false;
            btnEnfermeria.Enabled = false;
            btnMedico.Enabled = false;
            btnFacturacion.Enabled = false;

            switch (_usuarioLogueado.Rol)
            {
                case RolUsuario.RecursosHumanos:
                    btnRRHH.Enabled = true;
                    break;

                case RolUsuario.Administrativo:
                    btnAdministrativo.Enabled = true;
                    btnFacturacion.Enabled = true;
                    break;

                case RolUsuario.SoporteInformacion:
                    btnSoporteInfo.Enabled = true;
                    break;

                case RolUsuario.Enfermera:
                    btnEnfermeria.Enabled = true;
                    break;

                case RolUsuario.Medico:
                    btnMedico.Enabled = true;
                    break;
            }
        }

        private void btnRRHH_Click(object sender, EventArgs e)
        {
            new FrmUsuariosRRHH(_usuarioService).ShowDialog();
        }

        private void btnAdministrativo_Click(object sender, EventArgs e)
        {
            new FrmPacientes(_pacienteService).ShowDialog();
        }

        private void btnMedico_Click(object sender, EventArgs e)
        {
            // Historia clínica tiene su propio repo
            IHistoriaClinicaRepository repoHistoria = new InMemoryHistoriaClinicaRepository();

            // 👇 Ahora le pasamos también el DbContext
            var historiaService = new HistoriaClinicaService(repoHistoria, _context);

            new FrmHistoriaClinica(_pacienteService, historiaService).ShowDialog();
        }

        private void btnEnfermeria_Click(object sender, EventArgs e)
        {
            // Creamos repositorio y servicio de enfermería en memoria
            IRegistroEnfermeriaRepository repoEnf = new InMemoryRegistroEnfermeriaRepository();

            // 👇 Pasamos el DbContext
            var enfService = new EnfermeriaService(repoEnf, _context);

            var frm = new FrmEnfermeria(enfService);
            frm.ShowDialog();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSoporteInfo_Click(object sender, EventArgs e)
        {
            // Crear repositorios en memoria
            IMedicamentoRepository medRepo = new InMemoryMedicamentoRepository();
            IProcedimientoRepository procRepo = new InMemoryProcedimientoRepository();
            IAyudaDiagnosticaRepository ayudaRepo = new InMemoryAyudaDiagnosticaRepository();

            // 👇 InventarioService ahora recibe también el DbContext
            var invService = new InventarioService(medRepo, procRepo, ayudaRepo, _context);

            var frm = new FrmInventarioMedicamentos(invService);
            frm.ShowDialog();
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            // Repositorios en memoria para esta pantalla
            // REUTILIZAMOS el servicio de pacientes que ya tenemos
            var pacService = _pacienteService;

            IOrdenRepository ordenRepo = new InMemoryOrdenRepository();

            IFacturaRepository facRepo = new InMemoryFacturaRepository();
            // 👇 FacturacionService también necesita DbContext
            var factService = new FacturacionService(facRepo, _context);

            var frm = new FrmFacturacion(pacService, ordenRepo, factService);
            frm.ShowDialog();
        }
    }
}
