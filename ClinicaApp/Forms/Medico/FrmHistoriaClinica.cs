using ClinicaApp.Application.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaApp.Forms.Medico
{
    public partial class FrmHistoriaClinica : Form
    {
        private readonly PacienteService _pacienteService;
        private readonly HistoriaClinicaService _historiaService;

        public FrmHistoriaClinica(PacienteService pacienteService,
                                  HistoriaClinicaService historiaService)
        {
            InitializeComponent();
            _pacienteService = pacienteService;
            _historiaService = historiaService;
        }

        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            string cedula = txtCedulaPaciente.Text.Trim();
            var paciente = _pacienteService.ObtenerPacientePorCedula(cedula);

            if (paciente == null)
            {
                MessageBox.Show("No se encontró el paciente.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            lblNombrePaciente.Text = paciente.NombreCompleto;
            lblEdadPaciente.Text = paciente.CalcularEdad().ToString();

            var historia = _historiaService.ObtenerHistoriaPaciente(cedula)
                .Select(h => new
                {
                    Fecha = h.FechaAtencion.ToString("dd/MM/yyyy"),
                    h.CedulaMedico,
                    h.MotivoConsulta,
                    h.Diagnostico
                })
                .ToList();

            dgvHistoria.DataSource = historia;
        }

        private void btnNuevaEntrada_Click(object sender, EventArgs e)
        {
            string cedula = txtCedulaPaciente.Text.Trim();
            var paciente = _pacienteService.ObtenerPacientePorCedula(cedula);
            if (paciente == null)
            {
                MessageBox.Show("Primero busque un paciente válido.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var frm = new FrmNuevaEntradaHistoria(_historiaService, _pacienteService, paciente);
            frm.ShowDialog();

            // recargar historia
            btnBuscarPaciente_Click(sender, e);
        }
    }
}

