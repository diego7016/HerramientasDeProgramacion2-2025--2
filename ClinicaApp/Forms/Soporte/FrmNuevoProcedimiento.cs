using ClinicaApp.Application.Services;
using ClinicaApp.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaApp.Forms.Soporte
{
    public partial class FrmNuevoProcedimiento : Form
    {
        private readonly InventarioService _inventarioService;
        private readonly bool _esEdicion;
        private readonly string _idOriginal;

        // ✔ Constructor SIN parámetros – solo para el diseñador
        public FrmNuevoProcedimiento()
        {
            InitializeComponent();
            // No asignamos _inventarioService aquí porque este ctor es solo para diseño.
            _esEdicion = false;
            _idOriginal = null;
        }

        // ✔ Constructor para "Nuevo"
        public FrmNuevoProcedimiento(InventarioService inventarioService)
        {
            InitializeComponent();
            _inventarioService = inventarioService;
            _esEdicion = false;
            _idOriginal = null;
        }

        // ✔ Constructor para "Editar"
        public FrmNuevoProcedimiento(InventarioService inventarioService, Procedimiento procedimientoEditar)
        {
            InitializeComponent();
            _inventarioService = inventarioService;
            _esEdicion = true;
            _idOriginal = procedimientoEditar.Id;

            txtId.Text = procedimientoEditar.Id;
            txtId.Enabled = false;
            txtNombre.Text = procedimientoEditar.Nombre;
            txtCosto.Text = procedimientoEditar.Costo.ToString(CultureInfo.InvariantCulture);
            chkRequiereEspecialista.Checked = procedimientoEditar.RequiereEspecialista;
            txtIdTipoEspecialista.Text = procedimientoEditar.IdTipoEspecialista;
        }

        private void FrmNuevoProcedimiento_Load(object sender, EventArgs e)
        {
            ActualizarEstadoEspecialista();
        }

        private void chkRequiereEspecialista_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarEstadoEspecialista();
        }

        private void ActualizarEstadoEspecialista()
        {
            txtIdTipoEspecialista.Enabled = chkRequiereEspecialista.Checked;
            if (!chkRequiereEspecialista.Checked)
            {
                txtIdTipoEspecialista.Text = string.Empty;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (_inventarioService == null)
            {
                MessageBox.Show("InventarioService no ha sido inicializado (solo diseñador).",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string id = txtId.Text.Trim();
            string nombre = txtNombre.Text.Trim();
            string costoText = txtCosto.Text.Trim();
            bool requiereEspecialista = chkRequiereEspecialista.Checked;
            string idTipoEspecialista = txtIdTipoEspecialista.Text.Trim();

            if (!decimal.TryParse(costoText, NumberStyles.Float, CultureInfo.InvariantCulture, out decimal costo))
            {
                MessageBox.Show("El costo debe ser un número válido.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var proc = new Procedimiento
            {
                Id = id,
                Nombre = nombre,
                Costo = costo,
                RequiereEspecialista = requiereEspecialista,
                IdTipoEspecialista = idTipoEspecialista
            };

            try
            {
                if (_esEdicion)
                    _inventarioService.ActualizarProcedimiento(proc);
                else
                    _inventarioService.CrearProcedimiento(proc);

                MessageBox.Show("Procedimiento guardado correctamente.", "Información",
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
