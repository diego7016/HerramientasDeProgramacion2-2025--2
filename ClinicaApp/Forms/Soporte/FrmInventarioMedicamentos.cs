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
    public partial class FrmInventarioMedicamentos : Form
    {
        private readonly InventarioService _inventarioService;

        public FrmInventarioMedicamentos(InventarioService inventarioService)
        {
            InitializeComponent();
            _inventarioService = inventarioService;
        }

        private void FrmInventarioMedicamentos_Load(object sender, EventArgs e)
        {
            CargarMedicamentos();
        }

        private void CargarMedicamentos()
        {
            var lista = _inventarioService.ListarMedicamentos()
                .Select(m => new
                {
                    m.Id,
                    m.Nombre,
                    m.Presentacion,
                    m.Costo
                })
                .ToList();

            dgvMedicamentos.DataSource = lista;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarMedicamentos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var frm = new FrmNuevoMedicamento(_inventarioService);
            frm.ShowDialog();
            CargarMedicamentos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvMedicamentos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un medicamento.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string id = dgvMedicamentos.CurrentRow.Cells["Id"].Value?.ToString() ?? "";
            var med = _inventarioService.ObtenerMedicamento(id);
            if (med == null)
            {
                MessageBox.Show("No se encontró el medicamento.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var frm = new FrmNuevoMedicamento(_inventarioService, med);
            frm.ShowDialog();
            CargarMedicamentos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvMedicamentos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un medicamento.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string id = dgvMedicamentos.CurrentRow.Cells["Id"].Value?.ToString() ?? "";

            var r = MessageBox.Show(
                $"¿Desea eliminar el medicamento con Id {id}?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                _inventarioService.EliminarMedicamento(id);
                CargarMedicamentos();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
