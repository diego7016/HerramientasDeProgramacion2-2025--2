using ClinicaApp.Application.Services;
using ClinicaApp.Domain;
using ClinicaApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaApp.Forms.RRHH
{
    public partial class FrmNuevoUsuario : Form
    {
        private readonly UsuarioService _usuarioService;

        public FrmNuevoUsuario(UsuarioService usuarioService)
        {
            InitializeComponent();
            _usuarioService = usuarioService;
        }

        private void FrmNuevoUsuario_Load(object sender, EventArgs e)
        {
            cboRol.DataSource = Enum.GetValues(typeof(RolUsuario));
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario();

            usuario.NombreCompleto = txtNombreCompleto.Text.Trim();
            usuario.Cedula = txtCedula.Text.Trim();
            usuario.Email = txtEmail.Text.Trim();
            usuario.Telefono = txtTelefono.Text.Trim();
            usuario.FechaNacimiento = dtpFechaNacimiento.Value.Date;
            usuario.Direccion = txtDireccion.Text.Trim();



            if (cboRol.SelectedItem is RolUsuario rol)
                usuario.Rol = rol;
            else
            {
                MessageBox.Show("Debe seleccionar un rol.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            usuario.NombreUsuario = txtNombreUsuario.Text.Trim();
            usuario.Contrasena = txtContrasena.Text;

            try
            {
                _usuarioService.CrearUsuario(usuario);
                MessageBox.Show("Usuario creado correctamente.", "Información",
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

