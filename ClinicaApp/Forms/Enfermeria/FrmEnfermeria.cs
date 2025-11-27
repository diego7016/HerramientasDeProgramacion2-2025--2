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

namespace ClinicaApp.Forms.Enfermeria
{
    public partial class FrmEnfermeria : Form
    {
        private readonly EnfermeriaService _enfermeriaService;

        public FrmEnfermeria(EnfermeriaService enfermeriaService)
        {
            InitializeComponent();
            _enfermeriaService = enfermeriaService;
        }

        private void FrmEnfermeria_Load(object sender, EventArgs e)
        {
            // Nada especial al cargar
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string cedula = txtCedulaPaciente.Text.Trim();
            if (string.IsNullOrWhiteSpace(cedula))
            {
                MessageBox.Show("Ingrese la cédula del paciente.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var registros = _enfermeriaService.ObtenerPorPaciente(cedula)
                .Select(r => new
                {
                    Fecha = r.FechaHora,
                    r.NumeroOrden,
                    r.ItemOrden,
                    r.TipoItem,
                    Presion = r.Signos.PresionArterial,
                    Temperatura = r.Signos.Temperatura,
                    Pulso = r.Signos.Pulso,
                    SpO2 = r.Signos.SpO2,
                    r.Observaciones
                })
                .ToList();

            dgvRegistros.DataSource = registros;
        }

        private void btnNuevoRegistro_Click(object sender, EventArgs e)
        {
            // Pasamos la cédula escrita para no volver a digitarla
            string cedula = txtCedulaPaciente.Text.Trim();

            var frm = new FrmRegistroEnfermeria(_enfermeriaService, cedula);
            frm.ShowDialog();

            // Después de crear, recargamos la lista
            if (!string.IsNullOrWhiteSpace(cedula))
            {
                btnBuscar_Click(sender, e);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

