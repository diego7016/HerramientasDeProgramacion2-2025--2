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
    public partial class FrmNuevoMedicamento : Form
    {

        private readonly InventarioService _inventarioService;
        private readonly bool _esEdicion;
        private readonly string _idOriginal;

        public FrmNuevoMedicamento(InventarioService inventarioService)
        {
            InitializeComponent();
            _inventarioService = inventarioService;
            _esEdicion = false;
            _idOriginal = null;
        }

        public FrmNuevoMedicamento(InventarioService inventarioService, Medicamento medEditar)
        {
            InitializeComponent();
            _inventarioService = inventarioService;
            _esEdicion = true;
            _idOriginal = medEditar.Id;

            txtId.Text = medEditar.Id;
            txtId.Enabled = false;
            txtNombre.Text = medEditar.Nombre;
            txtPresentacion.Text = medEditar.Presentacion;
            txtCosto.Text = medEditar.Costo.ToString(CultureInfo.InvariantCulture);
        }

        private void FrmNuevoMedicamento_Load(object sender, EventArgs e)
        {
            // No es obligatorio hacer nada aquí.
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text.Trim();
            string nombre = txtNombre.Text.Trim();
            string presentacion = txtPresentacion.Text.Trim();
            string costoText = txtCosto.Text.Trim();

            if (!decimal.TryParse(costoText, NumberStyles.Float, CultureInfo.InvariantCulture, out decimal costo))
            {
                MessageBox.Show("El costo debe ser un número válido.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var med = new Medicamento
            {
                Id = id,
                Nombre = nombre,
                Presentacion = presentacion,
                Costo = costo
            };

            try
            {
                if (_esEdicion)
                {
                    _inventarioService.ActualizarMedicamento(med);
                }
                else
                {
                    _inventarioService.CrearMedicamento(med);
                }

                MessageBox.Show("Medicamento guardado correctamente.", "Información",
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
