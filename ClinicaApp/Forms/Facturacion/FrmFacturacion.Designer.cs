namespace ClinicaApp.Forms.Facturacion
{
    partial class FrmFacturacion
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.txtCedulaPaciente = new System.Windows.Forms.TextBox();
            this.btnBuscarPaciente = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNombrePaciente = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblEdadPaciente = new System.Windows.Forms.Label();
            this.lblMedicoTratante = new System.Windows.Forms.Label();
            this.txtNombreMedicoTratante = new System.Windows.Forms.TextBox();
            this.grpPoliza = new System.Windows.Forms.GroupBox();
            this.lblDiasVigenciaTitulo = new System.Windows.Forms.Label();
            this.lblDiasVigencia = new System.Windows.Forms.Label();
            this.lblFechaFinTitulo = new System.Windows.Forms.Label();
            this.lblFechaFinPoliza = new System.Windows.Forms.Label();
            this.lblEstadoTitulo = new System.Windows.Forms.Label();
            this.lblEstadoPoliza = new System.Windows.Forms.Label();
            this.lblNumeroPolizaTitulo = new System.Windows.Forms.Label();
            this.lblNumeroPoliza = new System.Windows.Forms.Label();
            this.lblCompaniaTitulo = new System.Windows.Forms.Label();
            this.lblCompania = new System.Windows.Forms.Label();
            this.lblOrdenesTitulo = new System.Windows.Forms.Label();
            this.dgvOrdenes = new System.Windows.Forms.DataGridView();
            this.lblNumeroFacturaTitulo = new System.Windows.Forms.Label();
            this.txtNumeroFactura = new System.Windows.Forms.TextBox();
            this.lblFechaFacturaTitulo = new System.Windows.Forms.Label();
            this.dtpFechaFactura = new System.Windows.Forms.DateTimePicker();
            this.lblDetalleTitulo = new System.Windows.Forms.Label();
            this.dgvDetalleFactura = new System.Windows.Forms.DataGridView();
            this.lblTotalServiciosTitulo = new System.Windows.Forms.Label();
            this.lblTotalServicios = new System.Windows.Forms.Label();
            this.lblCopagoTitulo = new System.Windows.Forms.Label();
            this.lblCopagoPaciente = new System.Windows.Forms.Label();
            this.lblTotalAseguradoraTitulo = new System.Windows.Forms.Label();
            this.lblTotalAseguradora = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.grpPoliza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(20, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(210, 20);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "FACTURACIÓN DE PACIENTE";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(20, 50);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(88, 15);
            this.lblCedula.TabIndex = 1;
            this.lblCedula.Text = "Cédula paciente:";
            // 
            // txtCedulaPaciente
            // 
            this.txtCedulaPaciente.Location = new System.Drawing.Point(120, 47);
            this.txtCedulaPaciente.Name = "txtCedulaPaciente";
            this.txtCedulaPaciente.Size = new System.Drawing.Size(180, 23);
            this.txtCedulaPaciente.TabIndex = 2;
            // 
            // btnBuscarPaciente
            // 
            this.btnBuscarPaciente.Location = new System.Drawing.Point(320, 46);
            this.btnBuscarPaciente.Name = "btnBuscarPaciente";
            this.btnBuscarPaciente.Size = new System.Drawing.Size(90, 25);
            this.btnBuscarPaciente.TabIndex = 3;
            this.btnBuscarPaciente.Text = "Buscar";
            this.btnBuscarPaciente.UseVisualStyleBackColor = true;
            this.btnBuscarPaciente.Click += new System.EventHandler(this.btnBuscarPaciente_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 80);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblNombrePaciente
            // 
            this.lblNombrePaciente.AutoSize = true;
            this.lblNombrePaciente.Location = new System.Drawing.Point(80, 80);
            this.lblNombrePaciente.Name = "lblNombrePaciente";
            this.lblNombrePaciente.Size = new System.Drawing.Size(11, 15);
            this.lblNombrePaciente.TabIndex = 5;
            this.lblNombrePaciente.Text = "-";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(350, 80);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(36, 15);
            this.lblEdad.TabIndex = 6;
            this.lblEdad.Text = "Edad:";
            // 
            // lblEdadPaciente
            // 
            this.lblEdadPaciente.AutoSize = true;
            this.lblEdadPaciente.Location = new System.Drawing.Point(392, 80);
            this.lblEdadPaciente.Name = "lblEdadPaciente";
            this.lblEdadPaciente.Size = new System.Drawing.Size(11, 15);
            this.lblEdadPaciente.TabIndex = 7;
            this.lblEdadPaciente.Text = "-";
            // 
            // lblMedicoTratante
            // 
            this.lblMedicoTratante.AutoSize = true;
            this.lblMedicoTratante.Location = new System.Drawing.Point(20, 110);
            this.lblMedicoTratante.Name = "lblMedicoTratante";
            this.lblMedicoTratante.Size = new System.Drawing.Size(97, 15);
            this.lblMedicoTratante.TabIndex = 8;
            this.lblMedicoTratante.Text = "Médico tratante:";
            // 
            // txtNombreMedicoTratante
            // 
            this.txtNombreMedicoTratante.Location = new System.Drawing.Point(120, 107);
            this.txtNombreMedicoTratante.Name = "txtNombreMedicoTratante";
            this.txtNombreMedicoTratante.Size = new System.Drawing.Size(290, 23);
            this.txtNombreMedicoTratante.TabIndex = 9;
            // 
            // grpPoliza
            // 
            this.grpPoliza.Controls.Add(this.lblDiasVigenciaTitulo);
            this.grpPoliza.Controls.Add(this.lblDiasVigencia);
            this.grpPoliza.Controls.Add(this.lblFechaFinTitulo);
            this.grpPoliza.Controls.Add(this.lblFechaFinPoliza);
            this.grpPoliza.Controls.Add(this.lblEstadoTitulo);
            this.grpPoliza.Controls.Add(this.lblEstadoPoliza);
            this.grpPoliza.Controls.Add(this.lblNumeroPolizaTitulo);
            this.grpPoliza.Controls.Add(this.lblNumeroPoliza);
            this.grpPoliza.Controls.Add(this.lblCompaniaTitulo);
            this.grpPoliza.Controls.Add(this.lblCompania);
            this.grpPoliza.Location = new System.Drawing.Point(20, 140);
            this.grpPoliza.Name = "grpPoliza";
            this.grpPoliza.Size = new System.Drawing.Size(520, 100);
            this.grpPoliza.TabIndex = 10;
            this.grpPoliza.TabStop = false;
            this.grpPoliza.Text = "Información póliza";
            // 
            // lblDiasVigenciaTitulo
            // 
            this.lblDiasVigenciaTitulo.AutoSize = true;
            this.lblDiasVigenciaTitulo.Location = new System.Drawing.Point(270, 65);
            this.lblDiasVigenciaTitulo.Name = "lblDiasVigenciaTitulo";
            this.lblDiasVigenciaTitulo.Size = new System.Drawing.Size(82, 15);
            this.lblDiasVigenciaTitulo.TabIndex = 9;
            this.lblDiasVigenciaTitulo.Text = "Días vigencia:";
            // 
            // lblDiasVigencia
            // 
            this.lblDiasVigencia.AutoSize = true;
            this.lblDiasVigencia.Location = new System.Drawing.Point(360, 65);
            this.lblDiasVigencia.Name = "lblDiasVigencia";
            this.lblDiasVigencia.Size = new System.Drawing.Size(11, 15);
            this.lblDiasVigencia.TabIndex = 8;
            this.lblDiasVigencia.Text = "-";
            // 
            // lblFechaFinTitulo
            // 
            this.lblFechaFinTitulo.AutoSize = true;
            this.lblFechaFinTitulo.Location = new System.Drawing.Point(270, 40);
            this.lblFechaFinTitulo.Name = "lblFechaFinTitulo";
            this.lblFechaFinTitulo.Size = new System.Drawing.Size(60, 15);
            this.lblFechaFinTitulo.TabIndex = 7;
            this.lblFechaFinTitulo.Text = "Fecha fin:";
            // 
            // lblFechaFinPoliza
            // 
            this.lblFechaFinPoliza.AutoSize = true;
            this.lblFechaFinPoliza.Location = new System.Drawing.Point(360, 40);
            this.lblFechaFinPoliza.Name = "lblFechaFinPoliza";
            this.lblFechaFinPoliza.Size = new System.Drawing.Size(11, 15);
            this.lblFechaFinPoliza.TabIndex = 6;
            this.lblFechaFinPoliza.Text = "-";
            // 
            // lblEstadoTitulo
            // 
            this.lblEstadoTitulo.AutoSize = true;
            this.lblEstadoTitulo.Location = new System.Drawing.Point(270, 20);
            this.lblEstadoTitulo.Name = "lblEstadoTitulo";
            this.lblEstadoTitulo.Size = new System.Drawing.Size(45, 15);
            this.lblEstadoTitulo.TabIndex = 5;
            this.lblEstadoTitulo.Text = "Estado:";
            // 
            // lblEstadoPoliza
            // 
            this.lblEstadoPoliza.AutoSize = true;
            this.lblEstadoPoliza.Location = new System.Drawing.Point(360, 20);
            this.lblEstadoPoliza.Name = "lblEstadoPoliza";
            this.lblEstadoPoliza.Size = new System.Drawing.Size(11, 15);
            this.lblEstadoPoliza.TabIndex = 4;
            this.lblEstadoPoliza.Text = "-";
            // 
            // lblNumeroPolizaTitulo
            // 
            this.lblNumeroPolizaTitulo.AutoSize = true;
            this.lblNumeroPolizaTitulo.Location = new System.Drawing.Point(10, 65);
            this.lblNumeroPolizaTitulo.Name = "lblNumeroPolizaTitulo";
            this.lblNumeroPolizaTitulo.Size = new System.Drawing.Size(60, 15);
            this.lblNumeroPolizaTitulo.TabIndex = 3;
            this.lblNumeroPolizaTitulo.Text = "N° póliza:";
            // 
            // lblNumeroPoliza
            // 
            this.lblNumeroPoliza.AutoSize = true;
            this.lblNumeroPoliza.Location = new System.Drawing.Point(90, 65);
            this.lblNumeroPoliza.Name = "lblNumeroPoliza";
            this.lblNumeroPoliza.Size = new System.Drawing.Size(11, 15);
            this.lblNumeroPoliza.TabIndex = 2;
            this.lblNumeroPoliza.Text = "-";
            // 
            // lblCompaniaTitulo
            // 
            this.lblCompaniaTitulo.AutoSize = true;
            this.lblCompaniaTitulo.Location = new System.Drawing.Point(10, 35);
            this.lblCompaniaTitulo.Name = "lblCompaniaTitulo";
            this.lblCompaniaTitulo.Size = new System.Drawing.Size(64, 15);
            this.lblCompaniaTitulo.TabIndex = 1;
            this.lblCompaniaTitulo.Text = "Compañía:";
            // 
            // lblCompania
            // 
            this.lblCompania.AutoSize = true;
            this.lblCompania.Location = new System.Drawing.Point(90, 35);
            this.lblCompania.Name = "lblCompania";
            this.lblCompania.Size = new System.Drawing.Size(11, 15);
            this.lblCompania.TabIndex = 0;
            this.lblCompania.Text = "-";
            // 
            // lblOrdenesTitulo
            // 
            this.lblOrdenesTitulo.AutoSize = true;
            this.lblOrdenesTitulo.Location = new System.Drawing.Point(20, 250);
            this.lblOrdenesTitulo.Name = "lblOrdenesTitulo";
            this.lblOrdenesTitulo.Size = new System.Drawing.Size(138, 15);
            this.lblOrdenesTitulo.TabIndex = 11;
            this.lblOrdenesTitulo.Text = "Órdenes para facturar:";
            // 
            // dgvOrdenes
            // 
            this.dgvOrdenes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdenes.Location = new System.Drawing.Point(20, 270);
            this.dgvOrdenes.Name = "dgvOrdenes";
            this.dgvOrdenes.RowTemplate.Height = 25;
            this.dgvOrdenes.Size = new System.Drawing.Size(840, 120);
            this.dgvOrdenes.TabIndex = 12;
            // 
            // lblNumeroFacturaTitulo
            // 
            this.lblNumeroFacturaTitulo.AutoSize = true;
            this.lblNumeroFacturaTitulo.Location = new System.Drawing.Point(20, 400);
            this.lblNumeroFacturaTitulo.Name = "lblNumeroFacturaTitulo";
            this.lblNumeroFacturaTitulo.Size = new System.Drawing.Size(73, 15);
            this.lblNumeroFacturaTitulo.TabIndex = 13;
            this.lblNumeroFacturaTitulo.Text = "N° Factura:";
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.Location = new System.Drawing.Point(100, 397);
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.Size = new System.Drawing.Size(150, 23);
            this.txtNumeroFactura.TabIndex = 14;
            // 
            // lblFechaFacturaTitulo
            // 
            this.lblFechaFacturaTitulo.AutoSize = true;
            this.lblFechaFacturaTitulo.Location = new System.Drawing.Point(270, 400);
            this.lblFechaFacturaTitulo.Name = "lblFechaFacturaTitulo";
            this.lblFechaFacturaTitulo.Size = new System.Drawing.Size(42, 15);
            this.lblFechaFacturaTitulo.TabIndex = 15;
            this.lblFechaFacturaTitulo.Text = "Fecha:";
            // 
            // dtpFechaFactura
            // 
            this.dtpFechaFactura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFactura.Location = new System.Drawing.Point(320, 397);
            this.dtpFechaFactura.Name = "dtpFechaFactura";
            this.dtpFechaFactura.Size = new System.Drawing.Size(120, 23);
            this.dtpFechaFactura.TabIndex = 16;
            // 
            // lblDetalleTitulo
            // 
            this.lblDetalleTitulo.AutoSize = true;
            this.lblDetalleTitulo.Location = new System.Drawing.Point(20, 430);
            this.lblDetalleTitulo.Name = "lblDetalleTitulo";
            this.lblDetalleTitulo.Size = new System.Drawing.Size(91, 15);
            this.lblDetalleTitulo.TabIndex = 17;
            this.lblDetalleTitulo.Text = "Detalle factura:";
            // 
            // dgvDetalleFactura
            // 
            this.dgvDetalleFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleFactura.Location = new System.Drawing.Point(20, 450);
            this.dgvDetalleFactura.Name = "dgvDetalleFactura";
            this.dgvDetalleFactura.RowTemplate.Height = 25;
            this.dgvDetalleFactura.Size = new System.Drawing.Size(840, 130);
            this.dgvDetalleFactura.TabIndex = 18;
            // 
            // lblTotalServiciosTitulo
            // 
            this.lblTotalServiciosTitulo.AutoSize = true;
            this.lblTotalServiciosTitulo.Location = new System.Drawing.Point(20, 590);
            this.lblTotalServiciosTitulo.Name = "lblTotalServiciosTitulo";
            this.lblTotalServiciosTitulo.Size = new System.Drawing.Size(88, 15);
            this.lblTotalServiciosTitulo.TabIndex = 19;
            this.lblTotalServiciosTitulo.Text = "Total servicios:";
            // 
            // lblTotalServicios
            // 
            this.lblTotalServicios.AutoSize = true;
            this.lblTotalServicios.Location = new System.Drawing.Point(120, 590);
            this.lblTotalServicios.Name = "lblTotalServicios";
            this.lblTotalServicios.Size = new System.Drawing.Size(11, 15);
            this.lblTotalServicios.TabIndex = 20;
            this.lblTotalServicios.Text = "-";
            // 
            // lblCopagoTitulo
            // 
            this.lblCopagoTitulo.AutoSize = true;
            this.lblCopagoTitulo.Location = new System.Drawing.Point(260, 590);
            this.lblCopagoTitulo.Name = "lblCopagoTitulo";
            this.lblCopagoTitulo.Size = new System.Drawing.Size(99, 15);
            this.lblCopagoTitulo.TabIndex = 21;
            this.lblCopagoTitulo.Text = "Copago paciente:";
            // 
            // lblCopagoPaciente
            // 
            this.lblCopagoPaciente.AutoSize = true;
            this.lblCopagoPaciente.Location = new System.Drawing.Point(370, 590);
            this.lblCopagoPaciente.Name = "lblCopagoPaciente";
            this.lblCopagoPaciente.Size = new System.Drawing.Size(11, 15);
            this.lblCopagoPaciente.TabIndex = 22;
            this.lblCopagoPaciente.Text = "-";
            // 
            // lblTotalAseguradoraTitulo
            // 
            this.lblTotalAseguradoraTitulo.AutoSize = true;
            this.lblTotalAseguradoraTitulo.Location = new System.Drawing.Point(500, 590);
            this.lblTotalAseguradoraTitulo.Name = "lblTotalAseguradoraTitulo";
            this.lblTotalAseguradoraTitulo.Size = new System.Drawing.Size(103, 15);
            this.lblTotalAseguradoraTitulo.TabIndex = 23;
            this.lblTotalAseguradoraTitulo.Text = "Total aseguradora:";
            // 
            // lblTotalAseguradora
            // 
            this.lblTotalAseguradora.AutoSize = true;
            this.lblTotalAseguradora.Location = new System.Drawing.Point(610, 590);
            this.lblTotalAseguradora.Name = "lblTotalAseguradora";
            this.lblTotalAseguradora.Size = new System.Drawing.Size(11, 15);
            this.lblTotalAseguradora.TabIndex = 24;
            this.lblTotalAseguradora.Text = "-";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalcular.Location = new System.Drawing.Point(480, 620);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 30);
            this.btnCalcular.TabIndex = 25;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Location = new System.Drawing.Point(590, 620);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 30);
            this.btnGuardar.TabIndex = 26;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Location = new System.Drawing.Point(700, 620);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 30);
            this.btnCerrar.TabIndex = 27;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FrmFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblTotalAseguradora);
            this.Controls.Add(this.lblTotalAseguradoraTitulo);
            this.Controls.Add(this.lblCopagoPaciente);
            this.Controls.Add(this.lblCopagoTitulo);
            this.Controls.Add(this.lblTotalServicios);
            this.Controls.Add(this.lblTotalServiciosTitulo);
            this.Controls.Add(this.dgvDetalleFactura);
            this.Controls.Add(this.lblDetalleTitulo);
            this.Controls.Add(this.dtpFechaFactura);
            this.Controls.Add(this.lblFechaFacturaTitulo);
            this.Controls.Add(this.txtNumeroFactura);
            this.Controls.Add(this.lblNumeroFacturaTitulo);
            this.Controls.Add(this.dgvOrdenes);
            this.Controls.Add(this.lblOrdenesTitulo);
            this.Controls.Add(this.grpPoliza);
            this.Controls.Add(this.txtNombreMedicoTratante);
            this.Controls.Add(this.lblMedicoTratante);
            this.Controls.Add(this.lblEdadPaciente);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblNombrePaciente);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnBuscarPaciente);
            this.Controls.Add(this.txtCedulaPaciente);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmFacturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturación";
            this.Load += new System.EventHandler(this.FrmFacturacion_Load);
            this.grpPoliza.ResumeLayout(false);
            this.grpPoliza.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.TextBox txtCedulaPaciente;
        private System.Windows.Forms.Button btnBuscarPaciente;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNombrePaciente;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblEdadPaciente;
        private System.Windows.Forms.Label lblMedicoTratante;
        private System.Windows.Forms.TextBox txtNombreMedicoTratante;
        private System.Windows.Forms.GroupBox grpPoliza;
        private System.Windows.Forms.Label lblDiasVigenciaTitulo;
        private System.Windows.Forms.Label lblDiasVigencia;
        private System.Windows.Forms.Label lblFechaFinTitulo;
        private System.Windows.Forms.Label lblFechaFinPoliza;
        private System.Windows.Forms.Label lblEstadoTitulo;
        private System.Windows.Forms.Label lblEstadoPoliza;
        private System.Windows.Forms.Label lblNumeroPolizaTitulo;
        private System.Windows.Forms.Label lblNumeroPoliza;
        private System.Windows.Forms.Label lblCompaniaTitulo;
        private System.Windows.Forms.Label lblCompania;
        private System.Windows.Forms.Label lblOrdenesTitulo;
        private System.Windows.Forms.DataGridView dgvOrdenes;
        private System.Windows.Forms.Label lblNumeroFacturaTitulo;
        private System.Windows.Forms.TextBox txtNumeroFactura;
        private System.Windows.Forms.Label lblFechaFacturaTitulo;
        private System.Windows.Forms.DateTimePicker dtpFechaFactura;
        private System.Windows.Forms.Label lblDetalleTitulo;
        private System.Windows.Forms.DataGridView dgvDetalleFactura;
        private System.Windows.Forms.Label lblTotalServiciosTitulo;
        private System.Windows.Forms.Label lblTotalServicios;
        private System.Windows.Forms.Label lblCopagoTitulo;
        private System.Windows.Forms.Label lblCopagoPaciente;
        private System.Windows.Forms.Label lblTotalAseguradoraTitulo;
        private System.Windows.Forms.Label lblTotalAseguradora;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCerrar;
    }
}
