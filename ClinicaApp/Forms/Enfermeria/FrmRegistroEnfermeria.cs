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

namespace ClinicaApp.Forms.Enfermeria
{
    public partial class FrmRegistroEnfermeria : Form
    {
        private readonly EnfermeriaService _enfermeriaService;
        private readonly string _cedulaPredefinida;

        public FrmRegistroEnfermeria(EnfermeriaService enfermeriaService, string cedulaPaciente = null)
        {
            InitializeComponent();
            _enfermeriaService = enfermeriaService;
            _cedulaPredefinida = cedulaPaciente;
        }

        private void FrmRegistroEnfermeria_Load(object sender, EventArgs e)
        {
            // Llenar combo de tipo de ítem
            cboTipoItem.Items.Clear();
            cboTipoItem.Items.Add("Medicamento");
            cboTipoItem.Items.Add("Procedimiento");
            cboTipoItem.SelectedIndex = 0;

            if (!string.IsNullOrWhiteSpace(_cedulaPredefinida))
            {
                txtCedulaPaciente.Text = _cedulaPredefinida;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string cedulaPaciente = txtCedulaPaciente.Text.Trim();
            string numeroOrdenText = txtNumeroOrden.Text.Trim();
            string itemText = txtItemOrden.Text.Trim();
            string tipoItem = cboTipoItem.SelectedItem?.ToString() ?? "";

            if (string.IsNullOrWhiteSpace(cedulaPaciente))
            {
                MessageBox.Show("La cédula del paciente es obligatoria.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(numeroOrdenText, out int numeroOrden))
            {
                MessageBox.Show("El número de orden debe ser un número entero.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(itemText, out int itemOrden))
            {
                MessageBox.Show("El ítem de la orden debe ser un número entero.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Signos vitales
            var signos = new SignosVitales();
            signos.PresionArterial = txtPresion.Text.Trim();

            if (!float.TryParse(txtTemperatura.Text.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out float temp))
            {
                MessageBox.Show("La temperatura debe ser un número válido (ej: 36.5).", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            signos.Temperatura = temp;

            if (!int.TryParse(txtPulso.Text.Trim(), out int pulso))
            {
                MessageBox.Show("El pulso debe ser un número entero.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            signos.Pulso = pulso;

            if (!int.TryParse(txtSpO2.Text.Trim(), out int spo2))
            {
                MessageBox.Show("El SpO2 debe ser un número entero.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            signos.SpO2 = spo2;

            var registro = new RegistroEnfermeria
            {
                CedulaPaciente = cedulaPaciente,
                FechaHora = DateTime.Now,
                NumeroOrden = numeroOrden,
                ItemOrden = itemOrden,
                TipoItem = tipoItem,
                Signos = signos,
                Observaciones = txtObservaciones.Text.Trim()
            };

            try
            {
                _enfermeriaService.Registrar(registro);
                MessageBox.Show("Registro de enfermería guardado correctamente.", "Información",
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
