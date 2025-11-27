namespace ClinicaApp.Forms.Medico
{
    partial class FrmOrdenMedica
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
            this.lblNumeroOrdenTitulo = new System.Windows.Forms.Label();
            this.txtNumeroOrden = new System.Windows.Forms.TextBox();
            this.lblPacienteTitulo = new System.Windows.Forms.Label();
            this.lblNombrePaciente = new System.Windows.Forms.Label();
            this.lblCedulaPacienteTitulo = new System.Windows.Forms.Label();
            this.lblCedulaPaciente = new System.Windows.Forms.Label();
            this.lblCedulaMedicoTitulo = new System.Windows.Forms.Label();
            this.lblCedulaMedico = new System.Windows.Forms.Label();
            this.lblFechaCreacionTitulo = new System.Windows.Forms.Label();
            this.dtpFechaCreacion = new System.Windows.Forms.DateTimePicker();
            this.grpMedicamentos = new System.Windows.Forms.GroupBox();
            this.dgvMedicamentos = new System.Windows.Forms.DataGridView();
            this.IdMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DuracionTratamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpProcedimientos = new System.Windows.Forms.GroupBox();
            this.dgvProcedimientos = new System.Windows.Forms.DataGridView();
            this.IdProcedimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProcedimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadProc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrecuenciaProc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequiereEspecialistaProc = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IdTipoEspecialistaProc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoProc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpAyudas = new System.Windows.Forms.GroupBox();
            this.dgvAyudas = new System.Windows.Forms.DataGridView();
            this.IdAyudaDiagnostica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreAyudaDiagnostica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadAyuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequiereEspecialistaAyuda = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IdTipoEspecialistaAyuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoAyuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardarOrden = new System.Windows.Forms.Button();
            this.btnCancelarOrden = new System.Windows.Forms.Button();
            this.grpMedicamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentos)).BeginInit();
            this.grpProcedimientos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcedimientos)).BeginInit();
            this.grpAyudas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAyudas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumeroOrdenTitulo
            // 
            this.lblNumeroOrdenTitulo.AutoSize = true;
            this.lblNumeroOrdenTitulo.Location = new System.Drawing.Point(14, 16);
            this.lblNumeroOrdenTitulo.Name = "lblNumeroOrdenTitulo";
            this.lblNumeroOrdenTitulo.Size = new System.Drawing.Size(115, 16);
            this.lblNumeroOrdenTitulo.TabIndex = 0;
            this.lblNumeroOrdenTitulo.Text = "Número de orden:";
            // 
            // txtNumeroOrden
            // 
            this.txtNumeroOrden.Location = new System.Drawing.Point(141, 13);
            this.txtNumeroOrden.Name = "txtNumeroOrden";
            this.txtNumeroOrden.Size = new System.Drawing.Size(137, 22);
            this.txtNumeroOrden.TabIndex = 1;
            // 
            // lblPacienteTitulo
            // 
            this.lblPacienteTitulo.AutoSize = true;
            this.lblPacienteTitulo.Location = new System.Drawing.Point(14, 47);
            this.lblPacienteTitulo.Name = "lblPacienteTitulo";
            this.lblPacienteTitulo.Size = new System.Drawing.Size(63, 16);
            this.lblPacienteTitulo.TabIndex = 2;
            this.lblPacienteTitulo.Text = "Paciente:";
            // 
            // lblNombrePaciente
            // 
            this.lblNombrePaciente.AutoSize = true;
            this.lblNombrePaciente.Location = new System.Drawing.Point(86, 47);
            this.lblNombrePaciente.Name = "lblNombrePaciente";
            this.lblNombrePaciente.Size = new System.Drawing.Size(11, 16);
            this.lblNombrePaciente.TabIndex = 3;
            this.lblNombrePaciente.Text = "-";
            // 
            // lblCedulaPacienteTitulo
            // 
            this.lblCedulaPacienteTitulo.AutoSize = true;
            this.lblCedulaPacienteTitulo.Location = new System.Drawing.Point(14, 69);
            this.lblCedulaPacienteTitulo.Name = "lblCedulaPacienteTitulo";
            this.lblCedulaPacienteTitulo.Size = new System.Drawing.Size(53, 16);
            this.lblCedulaPacienteTitulo.TabIndex = 4;
            this.lblCedulaPacienteTitulo.Text = "Cédula:";
            // 
            // lblCedulaPaciente
            // 
            this.lblCedulaPaciente.AutoSize = true;
            this.lblCedulaPaciente.Location = new System.Drawing.Point(86, 69);
            this.lblCedulaPaciente.Name = "lblCedulaPaciente";
            this.lblCedulaPaciente.Size = new System.Drawing.Size(11, 16);
            this.lblCedulaPaciente.TabIndex = 5;
            this.lblCedulaPaciente.Text = "-";
            // 
            // lblCedulaMedicoTitulo
            // 
            this.lblCedulaMedicoTitulo.AutoSize = true;
            this.lblCedulaMedicoTitulo.Location = new System.Drawing.Point(343, 47);
            this.lblCedulaMedicoTitulo.Name = "lblCedulaMedicoTitulo";
            this.lblCedulaMedicoTitulo.Size = new System.Drawing.Size(101, 16);
            this.lblCedulaMedicoTitulo.TabIndex = 6;
            this.lblCedulaMedicoTitulo.Text = "Cédula médico:";
            // 
            // lblCedulaMedico
            // 
            this.lblCedulaMedico.AutoSize = true;
            this.lblCedulaMedico.Location = new System.Drawing.Point(449, 47);
            this.lblCedulaMedico.Name = "lblCedulaMedico";
            this.lblCedulaMedico.Size = new System.Drawing.Size(11, 16);
            this.lblCedulaMedico.TabIndex = 7;
            this.lblCedulaMedico.Text = "-";
            // 
            // lblFechaCreacionTitulo
            // 
            this.lblFechaCreacionTitulo.AutoSize = true;
            this.lblFechaCreacionTitulo.Location = new System.Drawing.Point(343, 16);
            this.lblFechaCreacionTitulo.Name = "lblFechaCreacionTitulo";
            this.lblFechaCreacionTitulo.Size = new System.Drawing.Size(103, 16);
            this.lblFechaCreacionTitulo.TabIndex = 8;
            this.lblFechaCreacionTitulo.Text = "Fecha creación:";
            // 
            // dtpFechaCreacion
            // 
            this.dtpFechaCreacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCreacion.Location = new System.Drawing.Point(455, 13);
            this.dtpFechaCreacion.Name = "dtpFechaCreacion";
            this.dtpFechaCreacion.Size = new System.Drawing.Size(171, 22);
            this.dtpFechaCreacion.TabIndex = 9;
            // 
            // grpMedicamentos
            // 
            this.grpMedicamentos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMedicamentos.Controls.Add(this.dgvMedicamentos);
            this.grpMedicamentos.Location = new System.Drawing.Point(14, 99);
            this.grpMedicamentos.Name = "grpMedicamentos";
            this.grpMedicamentos.Size = new System.Drawing.Size(1079, 128);
            this.grpMedicamentos.TabIndex = 10;
            this.grpMedicamentos.TabStop = false;
            this.grpMedicamentos.Text = "Medicamentos";
            // 
            // dgvMedicamentos
            // 
            this.dgvMedicamentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMedicamento,
            this.NombreMedicamento,
            this.Dosis,
            this.DuracionTratamiento,
            this.CostoMedicamento});
            this.dgvMedicamentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMedicamentos.Location = new System.Drawing.Point(3, 18);
            this.dgvMedicamentos.Name = "dgvMedicamentos";
            this.dgvMedicamentos.RowHeadersWidth = 51;
            this.dgvMedicamentos.Size = new System.Drawing.Size(1073, 107);
            this.dgvMedicamentos.TabIndex = 0;
            // 
            // IdMedicamento
            // 
            this.IdMedicamento.HeaderText = "IdMedicamento";
            this.IdMedicamento.MinimumWidth = 6;
            this.IdMedicamento.Name = "IdMedicamento";
            // 
            // NombreMedicamento
            // 
            this.NombreMedicamento.HeaderText = "NombreMedicamento";
            this.NombreMedicamento.MinimumWidth = 6;
            this.NombreMedicamento.Name = "NombreMedicamento";
            // 
            // Dosis
            // 
            this.Dosis.HeaderText = "Dosis";
            this.Dosis.MinimumWidth = 6;
            this.Dosis.Name = "Dosis";
            // 
            // DuracionTratamiento
            // 
            this.DuracionTratamiento.HeaderText = "DuracionTratamiento";
            this.DuracionTratamiento.MinimumWidth = 6;
            this.DuracionTratamiento.Name = "DuracionTratamiento";
            // 
            // CostoMedicamento
            // 
            this.CostoMedicamento.HeaderText = "CostoMedicamento";
            this.CostoMedicamento.MinimumWidth = 6;
            this.CostoMedicamento.Name = "CostoMedicamento";
            // 
            // grpProcedimientos
            // 
            this.grpProcedimientos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpProcedimientos.Controls.Add(this.dgvProcedimientos);
            this.grpProcedimientos.Location = new System.Drawing.Point(14, 234);
            this.grpProcedimientos.Name = "grpProcedimientos";
            this.grpProcedimientos.Size = new System.Drawing.Size(1079, 149);
            this.grpProcedimientos.TabIndex = 11;
            this.grpProcedimientos.TabStop = false;
            this.grpProcedimientos.Text = "Procedimientos";
            // 
            // dgvProcedimientos
            // 
            this.dgvProcedimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProcedimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcedimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProcedimiento,
            this.NombreProcedimiento,
            this.CantidadProc,
            this.FrecuenciaProc,
            this.RequiereEspecialistaProc,
            this.IdTipoEspecialistaProc,
            this.CostoProc});
            this.dgvProcedimientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProcedimientos.Location = new System.Drawing.Point(3, 18);
            this.dgvProcedimientos.Name = "dgvProcedimientos";
            this.dgvProcedimientos.RowHeadersWidth = 51;
            this.dgvProcedimientos.Size = new System.Drawing.Size(1073, 128);
            this.dgvProcedimientos.TabIndex = 0;
            // 
            // IdProcedimiento
            // 
            this.IdProcedimiento.HeaderText = "IdProcedimiento";
            this.IdProcedimiento.MinimumWidth = 6;
            this.IdProcedimiento.Name = "IdProcedimiento";
            // 
            // NombreProcedimiento
            // 
            this.NombreProcedimiento.HeaderText = "NombreProcedimiento";
            this.NombreProcedimiento.MinimumWidth = 6;
            this.NombreProcedimiento.Name = "NombreProcedimiento";
            // 
            // CantidadProc
            // 
            this.CantidadProc.HeaderText = "CantidadProc";
            this.CantidadProc.MinimumWidth = 6;
            this.CantidadProc.Name = "CantidadProc";
            // 
            // FrecuenciaProc
            // 
            this.FrecuenciaProc.HeaderText = "FrecuenciaProc";
            this.FrecuenciaProc.MinimumWidth = 6;
            this.FrecuenciaProc.Name = "FrecuenciaProc";
            // 
            // RequiereEspecialistaProc
            // 
            this.RequiereEspecialistaProc.HeaderText = "RequiereEspecialistaProc";
            this.RequiereEspecialistaProc.MinimumWidth = 6;
            this.RequiereEspecialistaProc.Name = "RequiereEspecialistaProc";
            // 
            // IdTipoEspecialistaProc
            // 
            this.IdTipoEspecialistaProc.HeaderText = "IdTipoEspecialistaProc";
            this.IdTipoEspecialistaProc.MinimumWidth = 6;
            this.IdTipoEspecialistaProc.Name = "IdTipoEspecialistaProc";
            // 
            // CostoProc
            // 
            this.CostoProc.HeaderText = "CostoProc";
            this.CostoProc.MinimumWidth = 6;
            this.CostoProc.Name = "CostoProc";
            // 
            // grpAyudas
            // 
            this.grpAyudas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpAyudas.Controls.Add(this.dgvAyudas);
            this.grpAyudas.Location = new System.Drawing.Point(14, 389);
            this.grpAyudas.Name = "grpAyudas";
            this.grpAyudas.Size = new System.Drawing.Size(1079, 187);
            this.grpAyudas.TabIndex = 12;
            this.grpAyudas.TabStop = false;
            this.grpAyudas.Text = "Ayudas diagnósticas";
            // 
            // dgvAyudas
            // 
            this.dgvAyudas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAyudas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAyudas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdAyudaDiagnostica,
            this.NombreAyudaDiagnostica,
            this.CantidadAyuda,
            this.RequiereEspecialistaAyuda,
            this.IdTipoEspecialistaAyuda,
            this.CostoAyuda});
            this.dgvAyudas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAyudas.Location = new System.Drawing.Point(3, 18);
            this.dgvAyudas.Name = "dgvAyudas";
            this.dgvAyudas.RowHeadersWidth = 51;
            this.dgvAyudas.Size = new System.Drawing.Size(1073, 166);
            this.dgvAyudas.TabIndex = 0;
            // 
            // IdAyudaDiagnostica
            // 
            this.IdAyudaDiagnostica.HeaderText = "IdAyudaDiagnostica";
            this.IdAyudaDiagnostica.MinimumWidth = 6;
            this.IdAyudaDiagnostica.Name = "IdAyudaDiagnostica";
            // 
            // NombreAyudaDiagnostica
            // 
            this.NombreAyudaDiagnostica.HeaderText = "NombreAyudaDiagnostica";
            this.NombreAyudaDiagnostica.MinimumWidth = 6;
            this.NombreAyudaDiagnostica.Name = "NombreAyudaDiagnostica";
            // 
            // CantidadAyuda
            // 
            this.CantidadAyuda.HeaderText = "CantidadAyuda";
            this.CantidadAyuda.MinimumWidth = 6;
            this.CantidadAyuda.Name = "CantidadAyuda";
            // 
            // RequiereEspecialistaAyuda
            // 
            this.RequiereEspecialistaAyuda.HeaderText = "RequiereEspecialistaAyuda";
            this.RequiereEspecialistaAyuda.MinimumWidth = 6;
            this.RequiereEspecialistaAyuda.Name = "RequiereEspecialistaAyuda";
            // 
            // IdTipoEspecialistaAyuda
            // 
            this.IdTipoEspecialistaAyuda.HeaderText = "IdTipoEspecialistaAyuda";
            this.IdTipoEspecialistaAyuda.MinimumWidth = 6;
            this.IdTipoEspecialistaAyuda.Name = "IdTipoEspecialistaAyuda";
            // 
            // CostoAyuda
            // 
            this.CostoAyuda.HeaderText = "CostoAyuda";
            this.CostoAyuda.MinimumWidth = 6;
            this.CostoAyuda.Name = "CostoAyuda";
            // 
            // btnGuardarOrden
            // 
            this.btnGuardarOrden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarOrden.Location = new System.Drawing.Point(805, 583);
            this.btnGuardarOrden.Name = "btnGuardarOrden";
            this.btnGuardarOrden.Size = new System.Drawing.Size(137, 32);
            this.btnGuardarOrden.TabIndex = 13;
            this.btnGuardarOrden.Text = "Guardar orden";
            this.btnGuardarOrden.UseVisualStyleBackColor = true;
            this.btnGuardarOrden.Click += new System.EventHandler(this.btnGuardarOrden_Click);
            // 
            // btnCancelarOrden
            // 
            this.btnCancelarOrden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarOrden.Location = new System.Drawing.Point(949, 583);
            this.btnCancelarOrden.Name = "btnCancelarOrden";
            this.btnCancelarOrden.Size = new System.Drawing.Size(144, 32);
            this.btnCancelarOrden.TabIndex = 14;
            this.btnCancelarOrden.Text = "Cancelar";
            this.btnCancelarOrden.UseVisualStyleBackColor = true;
            this.btnCancelarOrden.Click += new System.EventHandler(this.btnCancelarOrden_Click);
            // 
            // FrmOrdenMedica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 628);
            this.Controls.Add(this.btnCancelarOrden);
            this.Controls.Add(this.btnGuardarOrden);
            this.Controls.Add(this.grpAyudas);
            this.Controls.Add(this.grpProcedimientos);
            this.Controls.Add(this.grpMedicamentos);
            this.Controls.Add(this.dtpFechaCreacion);
            this.Controls.Add(this.lblFechaCreacionTitulo);
            this.Controls.Add(this.lblCedulaMedico);
            this.Controls.Add(this.lblCedulaMedicoTitulo);
            this.Controls.Add(this.lblCedulaPaciente);
            this.Controls.Add(this.lblCedulaPacienteTitulo);
            this.Controls.Add(this.lblNombrePaciente);
            this.Controls.Add(this.lblPacienteTitulo);
            this.Controls.Add(this.txtNumeroOrden);
            this.Controls.Add(this.lblNumeroOrdenTitulo);
            this.Name = "FrmOrdenMedica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva orden médica";
            this.Load += new System.EventHandler(this.FrmOrdenMedica_Load);
            this.grpMedicamentos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentos)).EndInit();
            this.grpProcedimientos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcedimientos)).EndInit();
            this.grpAyudas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAyudas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeroOrdenTitulo;
        private System.Windows.Forms.TextBox txtNumeroOrden;
        private System.Windows.Forms.Label lblPacienteTitulo;
        private System.Windows.Forms.Label lblNombrePaciente;
        private System.Windows.Forms.Label lblCedulaPacienteTitulo;
        private System.Windows.Forms.Label lblCedulaPaciente;
        private System.Windows.Forms.Label lblCedulaMedicoTitulo;
        private System.Windows.Forms.Label lblCedulaMedico;
        private System.Windows.Forms.Label lblFechaCreacionTitulo;
        private System.Windows.Forms.DateTimePicker dtpFechaCreacion;
        private System.Windows.Forms.GroupBox grpMedicamentos;
        private System.Windows.Forms.DataGridView dgvMedicamentos;
        private System.Windows.Forms.GroupBox grpProcedimientos;
        private System.Windows.Forms.DataGridView dgvProcedimientos;
        private System.Windows.Forms.GroupBox grpAyudas;
        private System.Windows.Forms.DataGridView dgvAyudas;
        private System.Windows.Forms.Button btnGuardarOrden;
        private System.Windows.Forms.Button btnCancelarOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDosis;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDuracionTratamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCostoMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdProcedimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreProcedimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidadProc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFrecuenciaProc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colRequiereEspecialistaProc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdTipoEspecialistaProc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCostoProc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdAyudaDiagnostica;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreAyudaDiagnostica;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidadAyuda;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colRequiereEspecialistaAyuda;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdTipoEspecialistaAyuda;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCostoAyuda;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dosis;
        private System.Windows.Forms.DataGridViewTextBoxColumn DuracionTratamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProcedimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProcedimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadProc;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrecuenciaProc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn RequiereEspecialistaProc;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipoEspecialistaProc;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoProc;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAyudaDiagnostica;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreAyudaDiagnostica;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadAyuda;
        private System.Windows.Forms.DataGridViewCheckBoxColumn RequiereEspecialistaAyuda;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipoEspecialistaAyuda;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoAyuda;
    }
}
