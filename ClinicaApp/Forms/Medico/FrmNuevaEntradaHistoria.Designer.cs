namespace ClinicaApp.Forms.Medico
{
    partial class FrmNuevaEntradaHistoria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.grpPaciente = new System.Windows.Forms.GroupBox();
            this.lblNombreTitulo = new System.Windows.Forms.Label();
            this.lblNombrePaciente = new System.Windows.Forms.Label();
            this.lblCedulaTitulo = new System.Windows.Forms.Label();
            this.lblCedulaPaciente = new System.Windows.Forms.Label();
            this.lblFechaAtencionTitulo = new System.Windows.Forms.Label();
            this.dtpFechaAtencion = new System.Windows.Forms.DateTimePicker();
            this.lblCedulaMedicoTitulo = new System.Windows.Forms.Label();
            this.txtCedulaMedico = new System.Windows.Forms.TextBox();
            this.lblMotivoTitulo = new System.Windows.Forms.Label();
            this.txtMotivoConsulta = new System.Windows.Forms.TextBox();
            this.lblSintomaTitulo = new System.Windows.Forms.Label();
            this.txtSintomatologia = new System.Windows.Forms.TextBox();
            this.lblDiagnosticoTitulo = new System.Windows.Forms.Label();
            this.txtDiagnostico = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnGuardarYOrden = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpPaciente.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPaciente
            // 
            this.grpPaciente.Controls.Add(this.lblNombreTitulo);
            this.grpPaciente.Controls.Add(this.lblNombrePaciente);
            this.grpPaciente.Controls.Add(this.lblCedulaTitulo);
            this.grpPaciente.Controls.Add(this.lblCedulaPaciente);
            this.grpPaciente.Controls.Add(this.lblFechaAtencionTitulo);
            this.grpPaciente.Controls.Add(this.dtpFechaAtencion);
            this.grpPaciente.Controls.Add(this.lblCedulaMedicoTitulo);
            this.grpPaciente.Controls.Add(this.txtCedulaMedico);
            this.grpPaciente.Location = new System.Drawing.Point(14, 13);
            this.grpPaciente.Name = "grpPaciente";
            this.grpPaciente.Size = new System.Drawing.Size(640, 117);
            this.grpPaciente.TabIndex = 0;
            this.grpPaciente.TabStop = false;
            this.grpPaciente.Text = "Datos de atención";
            this.grpPaciente.Enter += new System.EventHandler(this.grpPaciente_Enter);
            // 
            // lblNombreTitulo
            // 
            this.lblNombreTitulo.AutoSize = true;
            this.lblNombreTitulo.Location = new System.Drawing.Point(17, 23);
            this.lblNombreTitulo.Name = "lblNombreTitulo";
            this.lblNombreTitulo.Size = new System.Drawing.Size(63, 16);
            this.lblNombreTitulo.TabIndex = 0;
            this.lblNombreTitulo.Text = "Paciente:";
            // 
            // lblNombrePaciente
            // 
            this.lblNombrePaciente.AutoSize = true;
            this.lblNombrePaciente.Location = new System.Drawing.Point(89, 23);
            this.lblNombrePaciente.Name = "lblNombrePaciente";
            this.lblNombrePaciente.Size = new System.Drawing.Size(11, 16);
            this.lblNombrePaciente.TabIndex = 1;
            this.lblNombrePaciente.Text = "-";
            // 
            // lblCedulaTitulo
            // 
            this.lblCedulaTitulo.AutoSize = true;
            this.lblCedulaTitulo.Location = new System.Drawing.Point(17, 48);
            this.lblCedulaTitulo.Name = "lblCedulaTitulo";
            this.lblCedulaTitulo.Size = new System.Drawing.Size(53, 16);
            this.lblCedulaTitulo.TabIndex = 2;
            this.lblCedulaTitulo.Text = "Cédula:";
            // 
            // lblCedulaPaciente
            // 
            this.lblCedulaPaciente.AutoSize = true;
            this.lblCedulaPaciente.Location = new System.Drawing.Point(89, 48);
            this.lblCedulaPaciente.Name = "lblCedulaPaciente";
            this.lblCedulaPaciente.Size = new System.Drawing.Size(11, 16);
            this.lblCedulaPaciente.TabIndex = 3;
            this.lblCedulaPaciente.Text = "-";
            // 
            // lblFechaAtencionTitulo
            // 
            this.lblFechaAtencionTitulo.AutoSize = true;
            this.lblFechaAtencionTitulo.Location = new System.Drawing.Point(320, 23);
            this.lblFechaAtencionTitulo.Name = "lblFechaAtencionTitulo";
            this.lblFechaAtencionTitulo.Size = new System.Drawing.Size(102, 16);
            this.lblFechaAtencionTitulo.TabIndex = 4;
            this.lblFechaAtencionTitulo.Text = "Fecha atención:";
            // 
            // dtpFechaAtencion
            // 
            this.dtpFechaAtencion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaAtencion.Location = new System.Drawing.Point(435, 20);
            this.dtpFechaAtencion.Name = "dtpFechaAtencion";
            this.dtpFechaAtencion.Size = new System.Drawing.Size(182, 22);
            this.dtpFechaAtencion.TabIndex = 5;
            // 
            // lblCedulaMedicoTitulo
            // 
            this.lblCedulaMedicoTitulo.AutoSize = true;
            this.lblCedulaMedicoTitulo.Location = new System.Drawing.Point(320, 51);
            this.lblCedulaMedicoTitulo.Name = "lblCedulaMedicoTitulo";
            this.lblCedulaMedicoTitulo.Size = new System.Drawing.Size(126, 16);
            this.lblCedulaMedicoTitulo.TabIndex = 6;
            this.lblCedulaMedicoTitulo.Text = "Cédula médico (10):";
            // 
            // txtCedulaMedico
            // 
            this.txtCedulaMedico.Location = new System.Drawing.Point(459, 48);
            this.txtCedulaMedico.Name = "txtCedulaMedico";
            this.txtCedulaMedico.Size = new System.Drawing.Size(158, 22);
            this.txtCedulaMedico.TabIndex = 7;
            // 
            // lblMotivoTitulo
            // 
            this.lblMotivoTitulo.AutoSize = true;
            this.lblMotivoTitulo.Location = new System.Drawing.Point(14, 144);
            this.lblMotivoTitulo.Name = "lblMotivoTitulo";
            this.lblMotivoTitulo.Size = new System.Drawing.Size(136, 16);
            this.lblMotivoTitulo.TabIndex = 1;
            this.lblMotivoTitulo.Text = "Motivo de la consulta:";
            // 
            // txtMotivoConsulta
            // 
            this.txtMotivoConsulta.Location = new System.Drawing.Point(14, 163);
            this.txtMotivoConsulta.Multiline = true;
            this.txtMotivoConsulta.Name = "txtMotivoConsulta";
            this.txtMotivoConsulta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMotivoConsulta.Size = new System.Drawing.Size(639, 64);
            this.txtMotivoConsulta.TabIndex = 2;
            // 
            // lblSintomaTitulo
            // 
            this.lblSintomaTitulo.AutoSize = true;
            this.lblSintomaTitulo.Location = new System.Drawing.Point(14, 230);
            this.lblSintomaTitulo.Name = "lblSintomaTitulo";
            this.lblSintomaTitulo.Size = new System.Drawing.Size(100, 16);
            this.lblSintomaTitulo.TabIndex = 3;
            this.lblSintomaTitulo.Text = "Sintomatología:";
            // 
            // txtSintomatologia
            // 
            this.txtSintomatologia.Location = new System.Drawing.Point(14, 250);
            this.txtSintomatologia.Multiline = true;
            this.txtSintomatologia.Name = "txtSintomatologia";
            this.txtSintomatologia.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSintomatologia.Size = new System.Drawing.Size(639, 64);
            this.txtSintomatologia.TabIndex = 4;
            // 
            // lblDiagnosticoTitulo
            // 
            this.lblDiagnosticoTitulo.AutoSize = true;
            this.lblDiagnosticoTitulo.Location = new System.Drawing.Point(14, 317);
            this.lblDiagnosticoTitulo.Name = "lblDiagnosticoTitulo";
            this.lblDiagnosticoTitulo.Size = new System.Drawing.Size(82, 16);
            this.lblDiagnosticoTitulo.TabIndex = 5;
            this.lblDiagnosticoTitulo.Text = "Diagnóstico:";
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.Location = new System.Drawing.Point(14, 336);
            this.txtDiagnostico.Multiline = true;
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDiagnostico.Size = new System.Drawing.Size(639, 64);
            this.txtDiagnostico.TabIndex = 6;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(218, 415);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(126, 32);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar entrada";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnGuardarYOrden
            // 
            this.btnGuardarYOrden.Location = new System.Drawing.Point(351, 415);
            this.btnGuardarYOrden.Name = "btnGuardarYOrden";
            this.btnGuardarYOrden.Size = new System.Drawing.Size(189, 32);
            this.btnGuardarYOrden.TabIndex = 8;
            this.btnGuardarYOrden.Text = "Guardar y crear orden";
            this.btnGuardarYOrden.UseVisualStyleBackColor = true;
            this.btnGuardarYOrden.Click += new System.EventHandler(this.btnGuardarYOrden_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(546, 415);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 32);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmNuevaEntradaHistoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 460);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardarYOrden);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtDiagnostico);
            this.Controls.Add(this.lblDiagnosticoTitulo);
            this.Controls.Add(this.txtSintomatologia);
            this.Controls.Add(this.lblSintomaTitulo);
            this.Controls.Add(this.txtMotivoConsulta);
            this.Controls.Add(this.lblMotivoTitulo);
            this.Controls.Add(this.grpPaciente);
            this.Name = "FrmNuevaEntradaHistoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva entrada historia clínica";
            this.Load += new System.EventHandler(this.FrmNuevaEntradaHistoria_Load);
            this.grpPaciente.ResumeLayout(false);
            this.grpPaciente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPaciente;
        private System.Windows.Forms.Label lblNombreTitulo;
        private System.Windows.Forms.Label lblNombrePaciente;
        private System.Windows.Forms.Label lblCedulaTitulo;
        private System.Windows.Forms.Label lblCedulaPaciente;
        private System.Windows.Forms.Label lblFechaAtencionTitulo;
        private System.Windows.Forms.DateTimePicker dtpFechaAtencion;
        private System.Windows.Forms.Label lblCedulaMedicoTitulo;
        private System.Windows.Forms.TextBox txtCedulaMedico;
        private System.Windows.Forms.Label lblMotivoTitulo;
        private System.Windows.Forms.TextBox txtMotivoConsulta;
        private System.Windows.Forms.Label lblSintomaTitulo;
        private System.Windows.Forms.TextBox txtSintomatologia;
        private System.Windows.Forms.Label lblDiagnosticoTitulo;
        private System.Windows.Forms.TextBox txtDiagnostico;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnGuardarYOrden;
        private System.Windows.Forms.Button btnCancelar;
    }
}
