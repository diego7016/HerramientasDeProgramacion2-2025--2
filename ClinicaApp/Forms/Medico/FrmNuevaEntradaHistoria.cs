using ClinicaApp.Application.Services;
using ClinicaApp.Domain;
using ClinicaApp.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaApp.Infrastructure.Persistence;

namespace ClinicaApp.Forms.Medico
{
    public partial class FrmNuevaEntradaHistoria : Form
    {
        private readonly HistoriaClinicaService _historiaService;
        private readonly PacienteService _pacienteService;
        private readonly Paciente _paciente;
        private readonly ClinicaDbContext _context;

        public FrmNuevaEntradaHistoria(HistoriaClinicaService historiaService,
                                       PacienteService pacienteService,
                                       Paciente paciente)
        {
            InitializeComponent();
            _historiaService = historiaService;
            _pacienteService = pacienteService;
            _paciente = paciente;
            _context = new ClinicaDbContext();
        }

        private void FrmNuevaEntradaHistoria_Load(object sender, EventArgs e)
        {
            lblNombrePaciente.Text = _paciente.NombreCompleto;
            lblCedulaPaciente.Text = _paciente.Cedula;
            dtpFechaAtencion.Value = DateTime.Today;
        }

        private HistoriaClinicaEntrada ConstruirEntrada()
        {
            return new HistoriaClinicaEntrada
            {
                CedulaPaciente = _paciente.Cedula,
                FechaAtencion = dtpFechaAtencion.Value.Date,
                CedulaMedico = txtCedulaMedico.Text.Trim(),
                MotivoConsulta = txtMotivoConsulta.Text.Trim(),
                Sintomatologia = txtSintomatologia.Text.Trim(),
                Diagnostico = txtDiagnostico.Text.Trim()
            };
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var entrada = ConstruirEntrada();
                _historiaService.RegistrarEntrada(entrada);

                MessageBox.Show("Entrada registrada correctamente.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardarYOrden_Click(object sender, EventArgs e)
        {
            try
            {
                var entrada = ConstruirEntrada();
                _historiaService.RegistrarEntrada(entrada);

                // Abrimos el formulario de orden médica
                var repoOrden = new InMemoryOrdenRepository();
                var ordenService = new OrdenService(repoOrden, _context);

                var frmOrden = new FrmOrdenMedica(ordenService, _paciente, entrada.CedulaMedico);
                frmOrden.ShowDialog();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grpPaciente_Enter(object sender, EventArgs e)
        {

        }
    }
}

