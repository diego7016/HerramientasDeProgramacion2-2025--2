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
    public partial class FrmNuevaAyudaDiagnostica : Form
    {
        private readonly InventarioService _inventarioService;
        private readonly bool _esEdicion;
        private readonly string _idOriginal;

        // Constructor SIN parámetros – diseñador
        public FrmNuevaAyudaDiagnostica()
        {
            InitializeComponent();
            _esEdicion = false;
            _idOriginal = null;
        }

        // Nuevo
        public FrmNuevaAyudaDiagnostica(InventarioService inventarioService)
        {
            InitializeComponent();
            _inventarioService = inventarioService;
            _esEdicion = false;
            _idOriginal = null;
        }

        // Editar
        public FrmNuevaAyudaDiagnostica(InventarioService inventarioService, AyudaDiagnostica ayudaEditar)
        {
            InitializeComponent();
            _inventarioService = inventarioService;
            _esEdicion = true;
            _idOriginal = ayudaEditar.Id;

            txtId.Text = ayudaEditar.Id;
            txtId.Enabled = false;
            txtNombre.Text = ayudaEditar.Nombre;
            txtCosto.Text = ayudaEditar.Costo.ToString(CultureInfo.InvariantCulture);
            chkRequiereEspecialista.Checked = ayudaEditar.RequiereEspecialista;
            txtIdTipoEspecialista.Text = ayudaEditar.IdTipoEspecialista;
        }

        private void FrmNuevaAyudaDiagnostica_Load(object sender, EventArgs e)
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

            var ayuda = new AyudaDiagnostica
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
                    _inventarioService.ActualizarAyuda(ayuda);
                else
                    _inventarioService.CrearAyuda(ayuda);

                MessageBox.Show("Ayuda diagnóstica guardada correctamente.", "Información",
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
