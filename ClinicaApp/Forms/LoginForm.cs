using ClinicaApp.Application.Services;
using ClinicaApp.Domain;
using System;
using System.Windows.Forms;

namespace ClinicaApp.Forms
{
    public partial class LoginForm : Form
    {
        private readonly UsuarioService _usuarioService;
        private readonly PacienteService _pacienteService;

        public LoginForm(UsuarioService usuarioService, PacienteService pacienteService)
        {
            InitializeComponent();
            _usuarioService = usuarioService;
            _pacienteService = pacienteService;
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Opcional: lógica al cargar el formulario
            txtUsuario.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsuario.Text.Trim();
            string password = txtPassword.Text;

            try
            {
                Usuario usuario = _usuarioService.Login(username, password);

                this.Hide();

                using (var mainForm = new MainForm(usuario, _usuarioService, _pacienteService))
                {
                    mainForm.ShowDialog();
                }

                txtPassword.Clear();
                txtUsuario.Clear();
                this.Show();
                txtUsuario.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de autenticación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
