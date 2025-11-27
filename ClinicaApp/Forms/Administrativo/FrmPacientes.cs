using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaApp.Application.Services;
using ClinicaApp.Infrastructure.Repositories;

namespace ClinicaApp.Forms.Administrativo
{
    public partial class FrmPacientes : Form
    {
        private readonly PacienteService _pacienteService;

        public FrmPacientes(PacienteService pacienteService)
        {
            InitializeComponent();
            _pacienteService = pacienteService;
        }

        private void FrmPacientes_Load(object sender, EventArgs e)
        {
            CargarPacientes();
        }

        private void CargarPacientes()
        {
            var lista = _pacienteService.ListarPacientes()
                .Select(p => new
                {
                    p.Cedula,
                    p.NombreCompleto,
                    Edad = p.CalcularEdad(),
                    Genero = p.Genero.ToString(),
                    p.Telefono,
                    p.Email
                })
                .ToList();

            dgvPacientes.DataSource = lista;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarPacientes();
        }

        private void btnNuevoPaciente_Click(object sender, EventArgs e)
        {
            var frm = new FrmNuevoPaciente(_pacienteService);
            frm.ShowDialog();
            CargarPacientes();
        }

        private void btnEditarPaciente_Click(object sender, EventArgs e)
        {
            if (dgvPacientes.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un paciente.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string cedula = dgvPacientes.CurrentRow.Cells["Cedula"].Value?.ToString() ?? "";
            var paciente = _pacienteService.ObtenerPacientePorCedula(cedula);
            if (paciente == null)
            {
                MessageBox.Show("No se encontró el paciente.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var frm = new FrmNuevoPaciente(_pacienteService, paciente);
            frm.ShowDialog();
            CargarPacientes();
        }

        private void btnEliminarPaciente_Click(object sender, EventArgs e)
        {
            if (dgvPacientes.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un paciente.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string cedula = dgvPacientes.CurrentRow.Cells["Cedula"].Value?.ToString() ?? "";

            var confirm = MessageBox.Show(
                $"¿Desea eliminar al paciente con cédula {cedula}?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    _pacienteService.EliminarPaciente(cedula);
                    CargarPacientes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
