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
using ClinicaApp.Domain;
using ClinicaApp.Domain.Enums;

namespace ClinicaApp.Forms.Administrativo
{
    public partial class FrmNuevoPaciente : Form
    {
        private readonly PacienteService _pacienteService;
        private readonly bool _esEdicion;
        private readonly string _cedulaOriginal;

        public FrmNuevoPaciente(PacienteService pacienteService)
        {
            InitializeComponent();
            _pacienteService = pacienteService;
            _esEdicion = false;
            _cedulaOriginal = null;
        }

        public FrmNuevoPaciente(PacienteService pacienteService, Paciente pacienteEditar)
        {
            InitializeComponent();
            _pacienteService = pacienteService;
            _esEdicion = true;
            _cedulaOriginal = pacienteEditar.Cedula;

            CargarPacienteEnFormulario(pacienteEditar);
        }

        private void FrmNuevoPaciente_Load(object sender, EventArgs e)
        {
            cboGenero.DataSource = Enum.GetValues(typeof(Genero));
        }

        private void CargarPacienteEnFormulario(Paciente p)
        {
            txtCedula.Text = p.Cedula;
            txtCedula.Enabled = false; // no dejamos cambiar cédula en edición

            txtNombreCompleto.Text = p.NombreCompleto;
            dtpFechaNacimiento.Value = p.FechaNacimiento;
            cboGenero.SelectedItem = p.Genero;
            txtDireccion.Text = p.Direccion;
            txtTelefono.Text = p.Telefono;
            txtEmail.Text = p.Email;

            if (p.ContactoEmergencia != null)
            {
                txtNombreContacto.Text = p.ContactoEmergencia.NombreCompleto;
                txtRelacionContacto.Text = p.ContactoEmergencia.Relacion;
                txtTelefonoContacto.Text = p.ContactoEmergencia.Telefono;
            }

            if (p.PolizaSeguro != null)
            {
                txtCompaniaSeguros.Text = p.PolizaSeguro.CompaniaSeguros;
                txtNumeroPoliza.Text = p.PolizaSeguro.NumeroPoliza;
                chkPolizaActiva.Checked = p.PolizaSeguro.Estado == EstadoPoliza.Activa;
                dtpVigenciaPoliza.Value = p.PolizaSeguro.FechaVigenciaFin;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var paciente = new Paciente();

            paciente.Cedula = txtCedula.Text.Trim();
            paciente.NombreCompleto = txtNombreCompleto.Text.Trim();
            paciente.FechaNacimiento = dtpFechaNacimiento.Value.Date;

            if (cboGenero.SelectedItem is Genero gen)
                paciente.Genero = gen;
            else
            {
                MessageBox.Show("Debe seleccionar un género.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            paciente.Direccion = txtDireccion.Text.Trim();
            paciente.Telefono = txtTelefono.Text.Trim();
            paciente.Email = txtEmail.Text.Trim();

            // Contacto de emergencia (si se llenó nombre, lo creamos)
            if (!string.IsNullOrWhiteSpace(txtNombreContacto.Text) ||
                !string.IsNullOrWhiteSpace(txtRelacionContacto.Text) ||
                !string.IsNullOrWhiteSpace(txtTelefonoContacto.Text))
            {
                paciente.ContactoEmergencia = new ContactoEmergencia
                {
                    NombreCompleto = txtNombreContacto.Text.Trim(),
                    Relacion = txtRelacionContacto.Text.Trim(),
                    Telefono = txtTelefonoContacto.Text.Trim()
                };
            }

            // Póliza (si se llenó al menos número o compañía)
            if (!string.IsNullOrWhiteSpace(txtCompaniaSeguros.Text) ||
                !string.IsNullOrWhiteSpace(txtNumeroPoliza.Text))
            {
                paciente.PolizaSeguro = new PolizaSeguro
                {
                    CompaniaSeguros = txtCompaniaSeguros.Text.Trim(),
                    NumeroPoliza = txtNumeroPoliza.Text.Trim(),
                    Estado = chkPolizaActiva.Checked ? EstadoPoliza.Activa : EstadoPoliza.Inactiva,
                    FechaVigenciaFin = dtpVigenciaPoliza.Value.Date
                };
            }

            try
            {
                if (_esEdicion)
                {
                    // En edición, usamos la misma cédula, ya está fijada
                    _pacienteService.ActualizarPaciente(paciente);
                }
                else
                {
                    _pacienteService.CrearPaciente(paciente);
                }

                MessageBox.Show("Paciente guardado correctamente.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

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
    }
}

