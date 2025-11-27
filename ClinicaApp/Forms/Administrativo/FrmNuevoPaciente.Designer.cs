namespace ClinicaApp.Forms.Administrativo
{
    partial class FrmNuevoPaciente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpDatosPersonales = new System.Windows.Forms.GroupBox();
            this.lblCedula = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.lblNombreCompleto = new System.Windows.Forms.Label();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblGenero = new System.Windows.Forms.Label();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.grpContactoEmergencia = new System.Windows.Forms.GroupBox();
            this.lblNombreContacto = new System.Windows.Forms.Label();
            this.txtNombreContacto = new System.Windows.Forms.TextBox();
            this.lblRelacionContacto = new System.Windows.Forms.Label();
            this.txtRelacionContacto = new System.Windows.Forms.TextBox();
            this.lblTelefonoContacto = new System.Windows.Forms.Label();
            this.txtTelefonoContacto = new System.Windows.Forms.TextBox();
            this.grpSeguroMedico = new System.Windows.Forms.GroupBox();
            this.lblCompaniaSeguros = new System.Windows.Forms.Label();
            this.txtCompaniaSeguros = new System.Windows.Forms.TextBox();
            this.lblNumeroPoliza = new System.Windows.Forms.Label();
            this.txtNumeroPoliza = new System.Windows.Forms.TextBox();
            this.chkPolizaActiva = new System.Windows.Forms.CheckBox();
            this.lblVigenciaPoliza = new System.Windows.Forms.Label();
            this.dtpVigenciaPoliza = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpDatosPersonales.SuspendLayout();
            this.grpContactoEmergencia.SuspendLayout();
            this.grpSeguroMedico.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDatosPersonales
            // 
            this.grpDatosPersonales.Controls.Add(this.lblCedula);
            this.grpDatosPersonales.Controls.Add(this.txtCedula);
            this.grpDatosPersonales.Controls.Add(this.lblNombreCompleto);
            this.grpDatosPersonales.Controls.Add(this.txtNombreCompleto);
            this.grpDatosPersonales.Controls.Add(this.lblFechaNacimiento);
            this.grpDatosPersonales.Controls.Add(this.dtpFechaNacimiento);
            this.grpDatosPersonales.Controls.Add(this.lblGenero);
            this.grpDatosPersonales.Controls.Add(this.cboGenero);
            this.grpDatosPersonales.Controls.Add(this.lblDireccion);
            this.grpDatosPersonales.Controls.Add(this.txtDireccion);
            this.grpDatosPersonales.Controls.Add(this.lblTelefono);
            this.grpDatosPersonales.Controls.Add(this.txtTelefono);
            this.grpDatosPersonales.Controls.Add(this.lblEmail);
            this.grpDatosPersonales.Controls.Add(this.txtEmail);
            this.grpDatosPersonales.Location = new System.Drawing.Point(14, 13);
            this.grpDatosPersonales.Name = "grpDatosPersonales";
            this.grpDatosPersonales.Size = new System.Drawing.Size(640, 203);
            this.grpDatosPersonales.TabIndex = 0;
            this.grpDatosPersonales.TabStop = false;
            this.grpDatosPersonales.Text = "Datos personales";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(18, 30);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(155, 16);
            this.lblCedula.TabIndex = 0;
            this.lblCedula.Text = "Número de identificación";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(206, 27);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(171, 22);
            this.txtCedula.TabIndex = 1;
            // 
            // lblNombreCompleto
            // 
            this.lblNombreCompleto.AutoSize = true;
            this.lblNombreCompleto.Location = new System.Drawing.Point(18, 61);
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            this.lblNombreCompleto.Size = new System.Drawing.Size(115, 16);
            this.lblNombreCompleto.TabIndex = 2;
            this.lblNombreCompleto.Text = "Nombre completo";
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Location = new System.Drawing.Point(206, 58);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(399, 22);
            this.txtNombreCompleto.TabIndex = 3;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(18, 92);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(132, 16);
            this.lblFechaNacimiento.TabIndex = 4;
            this.lblFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(206, 89);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(171, 22);
            this.dtpFechaNacimiento.TabIndex = 5;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(18, 123);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(52, 16);
            this.lblGenero.TabIndex = 6;
            this.lblGenero.Text = "Género";
            // 
            // cboGenero
            // 
            this.cboGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Location = new System.Drawing.Point(206, 119);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(171, 24);
            this.cboGenero.TabIndex = 7;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(18, 154);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(64, 16);
            this.lblDireccion.TabIndex = 8;
            this.lblDireccion.Text = "Dirección";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(206, 150);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(399, 22);
            this.txtDireccion.TabIndex = 9;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(400, 30);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(129, 16);
            this.lblTelefono.TabIndex = 10;
            this.lblTelefono.Text = "Teléfono (10 dígitos)";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(535, 27);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(70, 22);
            this.txtTelefono.TabIndex = 11;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(400, 92);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(117, 16);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Correo electrónico";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(400, 119);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(205, 22);
            this.txtEmail.TabIndex = 13;
            // 
            // grpContactoEmergencia
            // 
            this.grpContactoEmergencia.Controls.Add(this.lblNombreContacto);
            this.grpContactoEmergencia.Controls.Add(this.txtNombreContacto);
            this.grpContactoEmergencia.Controls.Add(this.lblRelacionContacto);
            this.grpContactoEmergencia.Controls.Add(this.txtRelacionContacto);
            this.grpContactoEmergencia.Controls.Add(this.lblTelefonoContacto);
            this.grpContactoEmergencia.Controls.Add(this.txtTelefonoContacto);
            this.grpContactoEmergencia.Location = new System.Drawing.Point(14, 222);
            this.grpContactoEmergencia.Name = "grpContactoEmergencia";
            this.grpContactoEmergencia.Size = new System.Drawing.Size(640, 128);
            this.grpContactoEmergencia.TabIndex = 1;
            this.grpContactoEmergencia.TabStop = false;
            this.grpContactoEmergencia.Text = "Contacto de emergencia (solo 1)";
            // 
            // lblNombreContacto
            // 
            this.lblNombreContacto.AutoSize = true;
            this.lblNombreContacto.Location = new System.Drawing.Point(18, 30);
            this.lblNombreContacto.Name = "lblNombreContacto";
            this.lblNombreContacto.Size = new System.Drawing.Size(110, 16);
            this.lblNombreContacto.TabIndex = 0;
            this.lblNombreContacto.Text = "Nombre contacto";
            // 
            // txtNombreContacto
            // 
            this.txtNombreContacto.Location = new System.Drawing.Point(206, 30);
            this.txtNombreContacto.Name = "txtNombreContacto";
            this.txtNombreContacto.Size = new System.Drawing.Size(399, 22);
            this.txtNombreContacto.TabIndex = 1;
            // 
            // lblRelacionContacto
            // 
            this.lblRelacionContacto.AutoSize = true;
            this.lblRelacionContacto.Location = new System.Drawing.Point(18, 61);
            this.lblRelacionContacto.Name = "lblRelacionContacto";
            this.lblRelacionContacto.Size = new System.Drawing.Size(155, 16);
            this.lblRelacionContacto.TabIndex = 2;
            this.lblRelacionContacto.Text = "Relación con el paciente";
            // 
            // txtRelacionContacto
            // 
            this.txtRelacionContacto.Location = new System.Drawing.Point(206, 58);
            this.txtRelacionContacto.Name = "txtRelacionContacto";
            this.txtRelacionContacto.Size = new System.Drawing.Size(228, 22);
            this.txtRelacionContacto.TabIndex = 3;
            // 
            // lblTelefonoContacto
            // 
            this.lblTelefonoContacto.AutoSize = true;
            this.lblTelefonoContacto.Location = new System.Drawing.Point(18, 92);
            this.lblTelefonoContacto.Name = "lblTelefonoContacto";
            this.lblTelefonoContacto.Size = new System.Drawing.Size(155, 16);
            this.lblTelefonoContacto.TabIndex = 4;
            this.lblTelefonoContacto.Text = "Teléfono de emergencia";
            // 
            // txtTelefonoContacto
            // 
            this.txtTelefonoContacto.Location = new System.Drawing.Point(206, 89);
            this.txtTelefonoContacto.Name = "txtTelefonoContacto";
            this.txtTelefonoContacto.Size = new System.Drawing.Size(171, 22);
            this.txtTelefonoContacto.TabIndex = 5;
            // 
            // grpSeguroMedico
            // 
            this.grpSeguroMedico.Controls.Add(this.lblCompaniaSeguros);
            this.grpSeguroMedico.Controls.Add(this.txtCompaniaSeguros);
            this.grpSeguroMedico.Controls.Add(this.lblNumeroPoliza);
            this.grpSeguroMedico.Controls.Add(this.txtNumeroPoliza);
            this.grpSeguroMedico.Controls.Add(this.chkPolizaActiva);
            this.grpSeguroMedico.Controls.Add(this.lblVigenciaPoliza);
            this.grpSeguroMedico.Controls.Add(this.dtpVigenciaPoliza);
            this.grpSeguroMedico.Location = new System.Drawing.Point(14, 356);
            this.grpSeguroMedico.Name = "grpSeguroMedico";
            this.grpSeguroMedico.Size = new System.Drawing.Size(640, 139);
            this.grpSeguroMedico.TabIndex = 2;
            this.grpSeguroMedico.TabStop = false;
            this.grpSeguroMedico.Text = "Seguro médico (solo 1 póliza)";
            // 
            // lblCompaniaSeguros
            // 
            this.lblCompaniaSeguros.AutoSize = true;
            this.lblCompaniaSeguros.Location = new System.Drawing.Point(18, 30);
            this.lblCompaniaSeguros.Name = "lblCompaniaSeguros";
            this.lblCompaniaSeguros.Size = new System.Drawing.Size(140, 16);
            this.lblCompaniaSeguros.TabIndex = 0;
            this.lblCompaniaSeguros.Text = "Compañía de seguros";
            // 
            // txtCompaniaSeguros
            // 
            this.txtCompaniaSeguros.Location = new System.Drawing.Point(206, 27);
            this.txtCompaniaSeguros.Name = "txtCompaniaSeguros";
            this.txtCompaniaSeguros.Size = new System.Drawing.Size(399, 22);
            this.txtCompaniaSeguros.TabIndex = 1;
            // 
            // lblNumeroPoliza
            // 
            this.lblNumeroPoliza.AutoSize = true;
            this.lblNumeroPoliza.Location = new System.Drawing.Point(18, 61);
            this.lblNumeroPoliza.Name = "lblNumeroPoliza";
            this.lblNumeroPoliza.Size = new System.Drawing.Size(113, 16);
            this.lblNumeroPoliza.TabIndex = 2;
            this.lblNumeroPoliza.Text = "Número de póliza";
            // 
            // txtNumeroPoliza
            // 
            this.txtNumeroPoliza.Location = new System.Drawing.Point(206, 58);
            this.txtNumeroPoliza.Name = "txtNumeroPoliza";
            this.txtNumeroPoliza.Size = new System.Drawing.Size(228, 22);
            this.txtNumeroPoliza.TabIndex = 3;
            // 
            // chkPolizaActiva
            // 
            this.chkPolizaActiva.AutoSize = true;
            this.chkPolizaActiva.Location = new System.Drawing.Point(457, 60);
            this.chkPolizaActiva.Name = "chkPolizaActiva";
            this.chkPolizaActiva.Size = new System.Drawing.Size(105, 20);
            this.chkPolizaActiva.TabIndex = 4;
            this.chkPolizaActiva.Text = "Póliza activa";
            this.chkPolizaActiva.UseVisualStyleBackColor = true;
            // 
            // lblVigenciaPoliza
            // 
            this.lblVigenciaPoliza.AutoSize = true;
            this.lblVigenciaPoliza.Location = new System.Drawing.Point(18, 94);
            this.lblVigenciaPoliza.Name = "lblVigenciaPoliza";
            this.lblVigenciaPoliza.Size = new System.Drawing.Size(123, 16);
            this.lblVigenciaPoliza.TabIndex = 5;
            this.lblVigenciaPoliza.Text = "Vigencia (fin póliza)";
            // 
            // dtpVigenciaPoliza
            // 
            this.dtpVigenciaPoliza.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVigenciaPoliza.Location = new System.Drawing.Point(206, 89);
            this.dtpVigenciaPoliza.Name = "dtpVigenciaPoliza";
            this.dtpVigenciaPoliza.Size = new System.Drawing.Size(171, 22);
            this.dtpVigenciaPoliza.TabIndex = 6;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(361, 501);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(137, 32);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(517, 501);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(137, 32);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmNuevoPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 545);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.grpSeguroMedico);
            this.Controls.Add(this.grpContactoEmergencia);
            this.Controls.Add(this.grpDatosPersonales);
            this.Name = "FrmNuevoPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal Administrativo - Nuevo paciente";
            this.Load += new System.EventHandler(this.FrmNuevoPaciente_Load);
            this.grpDatosPersonales.ResumeLayout(false);
            this.grpDatosPersonales.PerformLayout();
            this.grpContactoEmergencia.ResumeLayout(false);
            this.grpContactoEmergencia.PerformLayout();
            this.grpSeguroMedico.ResumeLayout(false);
            this.grpSeguroMedico.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatosPersonales;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label lblNombreCompleto;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.ComboBox cboGenero;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox grpContactoEmergencia;
        private System.Windows.Forms.Label lblNombreContacto;
        private System.Windows.Forms.TextBox txtNombreContacto;
        private System.Windows.Forms.Label lblRelacionContacto;
        private System.Windows.Forms.TextBox txtRelacionContacto;
        private System.Windows.Forms.Label lblTelefonoContacto;
        private System.Windows.Forms.TextBox txtTelefonoContacto;
        private System.Windows.Forms.GroupBox grpSeguroMedico;
        private System.Windows.Forms.Label lblCompaniaSeguros;
        private System.Windows.Forms.TextBox txtCompaniaSeguros;
        private System.Windows.Forms.Label lblNumeroPoliza;
        private System.Windows.Forms.TextBox txtNumeroPoliza;
        private System.Windows.Forms.CheckBox chkPolizaActiva;
        private System.Windows.Forms.Label lblVigenciaPoliza;
        private System.Windows.Forms.DateTimePicker dtpVigenciaPoliza;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
