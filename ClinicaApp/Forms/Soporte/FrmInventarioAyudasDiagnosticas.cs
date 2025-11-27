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

namespace ClinicaApp.Forms.Soporte
{
    public partial class FrmInventarioAyudasDiagnosticas : Form
    {
        private readonly InventarioService _inventarioService;

        public FrmInventarioAyudasDiagnosticas(InventarioService inventarioService)
        {
            InitializeComponent();
            _inventarioService = inventarioService;
        }

        private void FrmInventarioAyudasDiagnosticas_Load(object sender, EventArgs e)
        {
            CargarAyudas();
        }

        private void CargarAyudas()
        {
            var lista = _inventarioService.ListarAyudas()
                .Select(a => new
                {
                    a.Id,
                    a.Nombre,
                    a.Costo,
                    a.RequiereEspecialista,
                    a.IdTipoEspecialista
                })
                .ToList();

            dgvAyudas.DataSource = lista;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarAyudas();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var frm = new FrmNuevaAyudaDiagnostica(_inventarioService);
            frm.ShowDialog();
            CargarAyudas();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvAyudas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una ayuda diagnóstica.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string id = dgvAyudas.CurrentRow.Cells["Id"].Value?.ToString() ?? "";
            var ayuda = _inventarioService.ObtenerAyuda(id);
            if (ayuda == null)
            {
                MessageBox.Show("No se encontró la ayuda diagnóstica.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var frm = new FrmNuevaAyudaDiagnostica(_inventarioService, ayuda);
            frm.ShowDialog();
            CargarAyudas();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvAyudas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una ayuda diagnóstica.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string id = dgvAyudas.CurrentRow.Cells["Id"].Value?.ToString() ?? "";

            var r = MessageBox.Show(
                $"¿Desea eliminar la ayuda diagnóstica con Id {id}?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                _inventarioService.EliminarAyuda(id);
                CargarAyudas();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
