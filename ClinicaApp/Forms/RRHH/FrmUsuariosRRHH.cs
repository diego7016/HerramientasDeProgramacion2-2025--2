using ClinicaApp.Application.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ClinicaApp.Forms.RRHH
{
    public partial class FrmUsuariosRRHH : Form
    {
        private readonly UsuarioService _usuarioService;

        public FrmUsuariosRRHH(UsuarioService usuarioService)
        {
            InitializeComponent();
            _usuarioService = usuarioService;
        }

        private void FrmUsuariosRRHH_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            var lista = _usuarioService.ListarUsuarios()
                .Select(u => new
                {
                    u.NombreCompleto,
                    u.Cedula,
                    u.Email,
                    u.Telefono,
                    Rol = u.Rol.ToString(),
                    u.NombreUsuario
                })
                .ToList();

            dgvUsuarios.DataSource = lista;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            var frm = new FrmNuevoUsuario(_usuarioService);
            frm.ShowDialog();
            CargarUsuarios();
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un usuario.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string cedula = dgvUsuarios.CurrentRow.Cells["Cedula"].Value?.ToString() ?? "";

            var result = MessageBox.Show(
                $"¿Desea eliminar al usuario con cédula {cedula}?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    _usuarioService.EliminarUsuario(cedula);
                    CargarUsuarios();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // vacío por ahora
        }
    }
}


