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
    public partial class FrmInventarioProcedimientos : Form
    {
        private readonly InventarioService _inventarioService;

        public FrmInventarioProcedimientos(InventarioService inventarioService)
        {
            InitializeComponent();
            _inventarioService = inventarioService;
        }

        private void FrmInventarioProcedimientos_Load(object sender, EventArgs e)
        {
            CargarProcedimientos();
        }

        private void CargarProcedimientos()
        {
            var lista = _inventarioService.ListarProcedimientos()
                .Select(p => new
                {
                    p.Id,
                    p.Nombre,
                    p.Costo,
                    p.RequiereEspecialista,
                    p.IdTipoEspecialista
                })
                .ToList();

            dgvProcedimientos.DataSource = lista;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarProcedimientos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var frm = new FrmNuevoProcedimiento(_inventarioService);
            frm.ShowDialog();
            CargarProcedimientos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProcedimientos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un procedimiento.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string id = dgvProcedimientos.CurrentRow.Cells["Id"].Value?.ToString() ?? "";
            var proc = _inventarioService.ObtenerProcedimiento(id);
            if (proc == null)
            {
                MessageBox.Show("No se encontró el procedimiento.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var frm = new FrmNuevoProcedimiento(_inventarioService, proc);
            frm.ShowDialog();
            CargarProcedimientos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProcedimientos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un procedimiento.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string id = dgvProcedimientos.CurrentRow.Cells["Id"].Value?.ToString() ?? "";

            var r = MessageBox.Show(
                $"¿Desea eliminar el procedimiento con Id {id}?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                _inventarioService.EliminarProcedimiento(id);
                CargarProcedimientos();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }


}   
