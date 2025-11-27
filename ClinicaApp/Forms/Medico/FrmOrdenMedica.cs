using ClinicaApp.Application.Services;
using ClinicaApp.Domain;
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
    public partial class FrmOrdenMedica : Form
    {
        private readonly OrdenService _ordenService;
        private readonly Paciente _paciente;
        private readonly string _cedulaMedico;

        public FrmOrdenMedica(OrdenService ordenService, Paciente paciente, string cedulaMedico)
        {
            InitializeComponent();
            _ordenService = ordenService;
            _paciente = paciente;
            _cedulaMedico = cedulaMedico;
        }

        private void FrmOrdenMedica_Load(object sender, EventArgs e)
        {
            lblNombrePaciente.Text = _paciente.NombreCompleto;
            lblCedulaPaciente.Text = _paciente.Cedula;
            lblCedulaMedico.Text = _cedulaMedico;
            dtpFechaCreacion.Value = DateTime.Today;
        }

        private void btnGuardarOrden_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNumeroOrden.Text.Trim(), out int numeroOrden))
            {
                MessageBox.Show("El número de orden debe ser numérico.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var orden = new OrdenMedica
            {
                NumeroOrden = numeroOrden,
                CedulaPaciente = _paciente.Cedula,
                CedulaMedico = _cedulaMedico,
                FechaCreacion = dtpFechaCreacion.Value.Date
            };

            // Leer medicamentos de la grilla
            foreach (DataGridViewRow row in dgvMedicamentos.Rows)
            {
                if (row.IsNewRow) continue;

                string id = row.Cells["IdMedicamento"].Value?.ToString() ?? "";
                string nombre = row.Cells["NombreMedicamento"].Value?.ToString() ?? "";
                string dosis = row.Cells["Dosis"].Value?.ToString() ?? "";
                string duracion = row.Cells["DuracionTratamiento"].Value?.ToString() ?? "";
                decimal costo = 0;
                decimal.TryParse(row.Cells["CostoMedicamento"].Value?.ToString(), out costo);

                if (!string.IsNullOrWhiteSpace(id) || !string.IsNullOrWhiteSpace(nombre))
                {
                    orden.Medicamentos.Add(new OrdenMedicamentoItem
                    {
                        IdMedicamento = id,
                        NombreMedicamento = nombre,
                        Dosis = dosis,
                        DuracionTratamiento = duracion,
                        Costo = costo
                    });
                }
            }

            // Leer procedimientos
            foreach (DataGridViewRow row in dgvProcedimientos.Rows)
            {
                if (row.IsNewRow) continue;

                string id = row.Cells["IdProcedimiento"].Value?.ToString() ?? "";
                string nombre = row.Cells["NombreProcedimiento"].Value?.ToString() ?? "";
                int cantidad = 0;
                int.TryParse(row.Cells["CantidadProc"].Value?.ToString(), out cantidad);
                string frecuencia = row.Cells["FrecuenciaProc"].Value?.ToString() ?? "";
                bool requiereEsp = Convert.ToBoolean(row.Cells["RequiereEspecialistaProc"].Value ?? false);
                string idEsp = row.Cells["IdTipoEspecialistaProc"].Value?.ToString() ?? "";
                decimal costo = 0;
                decimal.TryParse(row.Cells["CostoProc"].Value?.ToString(), out costo);

                if (!string.IsNullOrWhiteSpace(id) || !string.IsNullOrWhiteSpace(nombre))
                {
                    orden.Procedimientos.Add(new OrdenProcedimientoItem
                    {
                        IdProcedimiento = id,
                        NombreProcedimiento = nombre,
                        Cantidad = cantidad,
                        Frecuencia = frecuencia,
                        RequiereEspecialista = requiereEsp,
                        IdTipoEspecialista = idEsp,
                        Costo = costo
                    });
                }
            }

            // Leer ayudas diagnósticas
            foreach (DataGridViewRow row in dgvAyudas.Rows)
            {
                if (row.IsNewRow) continue;

                string id = row.Cells["IdAyudaDiagnostica"].Value?.ToString() ?? "";
                string nombre = row.Cells["NombreAyudaDiagnostica"].Value?.ToString() ?? "";
                int cantidad = 0;
                int.TryParse(row.Cells["CantidadAyuda"].Value?.ToString(), out cantidad);
                bool requiereEsp = Convert.ToBoolean(row.Cells["RequiereEspecialistaAyuda"].Value ?? false);
                string idEsp = row.Cells["IdTipoEspecialistaAyuda"].Value?.ToString() ?? "";
                decimal costo = 0;
                decimal.TryParse(row.Cells["CostoAyuda"].Value?.ToString(), out costo);

                if (!string.IsNullOrWhiteSpace(id) || !string.IsNullOrWhiteSpace(nombre))
                {
                    orden.AyudasDiagnosticas.Add(new OrdenAyudaDiagnosticaItem
                    {
                        IdAyudaDiagnostica = id,
                        NombreAyudaDiagnostica = nombre,
                        Cantidad = cantidad,
                        RequiereEspecialista = requiereEsp,
                        IdTipoEspecialista = idEsp,
                        Costo = costo
                    });
                }
            }

            try
            {
                _ordenService.CrearOrden(orden);
                MessageBox.Show("Orden médica creada correctamente.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al crear orden",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarOrden_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
