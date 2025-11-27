namespace ClinicaApp.Forms.Enfermeria
{
    partial class FrmRegistroEnfermeria
    {
        private System.ComponentModel.IContainer components = null;

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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.txtCedulaPaciente = new System.Windows.Forms.TextBox();
            this.lblNumeroOrden = new System.Windows.Forms.Label();
            this.txtNumeroOrden = new System.Windows.Forms.TextBox();
            this.lblItemOrden = new System.Windows.Forms.Label();
            this.txtItemOrden = new System.Windows.Forms.TextBox();
            this.lblTipoItem = new System.Windows.Forms.Label();
            this.cboTipoItem = new System.Windows.Forms.ComboBox();
            this.grpSignos = new System.Windows.Forms.GroupBox();
            this.lblSpO2 = new System.Windows.Forms.Label();
            this.txtSpO2 = new System.Windows.Forms.TextBox();
            this.lblPulso = new System.Windows.Forms.Label();
            this.txtPulso = new System.Windows.Forms.TextBox();
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.txtTemperatura = new System.Windows.Forms.TextBox();
            this.lblPresion = new System.Windows.Forms.Label();
            this.txtPresion = new System.Windows.Forms.TextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpSignos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(20, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(211, 20);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "REGISTRO DE ENFERMERÍA";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(20, 55);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(88, 15);
            this.lblCedula.TabIndex = 1;
            this.lblCedula.Text = "Cédula paciente:";
            // 
            // txtCedulaPaciente
            // 
            this.txtCedulaPaciente.Location = new System.Drawing.Point(140, 52);
            this.txtCedulaPaciente.Name = "txtCedulaPaciente";
            this.txtCedulaPaciente.Size = new System.Drawing.Size(200, 23);
            this.txtCedulaPaciente.TabIndex = 0;
            // 
            // lblNumeroOrden
            // 
            this.lblNumeroOrden.AutoSize = true;
            this.lblNumeroOrden.Location = new System.Drawing.Point(20, 85);
            this.lblNumeroOrden.Name = "lblNumeroOrden";
            this.lblNumeroOrden.Size = new System.Drawing.Size(92, 15);
            this.lblNumeroOrden.TabIndex = 3;
            this.lblNumeroOrden.Text = "Número orden:";
            // 
            // txtNumeroOrden
            // 
            this.txtNumeroOrden.Location = new System.Drawing.Point(140, 82);
            this.txtNumeroOrden.Name = "txtNumeroOrden";
            this.txtNumeroOrden.Size = new System.Drawing.Size(120, 23);
            this.txtNumeroOrden.TabIndex = 1;
            // 
            // lblItemOrden
            // 
            this.lblItemOrden.AutoSize = true;
            this.lblItemOrden.Location = new System.Drawing.Point(20, 115);
            this.lblItemOrden.Name = "lblItemOrden";
            this.lblItemOrden.Size = new System.Drawing.Size(71, 15);
            this.lblItemOrden.TabIndex = 5;
            this.lblItemOrden.Text = "Ítem orden:";
            // 
            // txtItemOrden
            // 
            this.txtItemOrden.Location = new System.Drawing.Point(140, 112);
            this.txtItemOrden.Name = "txtItemOrden";
            this.txtItemOrden.Size = new System.Drawing.Size(120, 23);
            this.txtItemOrden.TabIndex = 2;
            // 
            // lblTipoItem
            // 
            this.lblTipoItem.AutoSize = true;
            this.lblTipoItem.Location = new System.Drawing.Point(20, 145);
            this.lblTipoItem.Name = "lblTipoItem";
            this.lblTipoItem.Size = new System.Drawing.Size(57, 15);
            this.lblTipoItem.TabIndex = 7;
            this.lblTipoItem.Text = "Tipo ítem:";
            // 
            // cboTipoItem
            // 
            this.cboTipoItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoItem.FormattingEnabled = true;
            this.cboTipoItem.Location = new System.Drawing.Point(140, 142);
            this.cboTipoItem.Name = "cboTipoItem";
            this.cboTipoItem.Size = new System.Drawing.Size(200, 23);
            this.cboTipoItem.TabIndex = 3;
            // 
            // grpSignos
            // 
            this.grpSignos.Controls.Add(this.lblSpO2);
            this.grpSignos.Controls.Add(this.txtSpO2);
            this.grpSignos.Controls.Add(this.lblPulso);
            this.grpSignos.Controls.Add(this.txtPulso);
            this.grpSignos.Controls.Add(this.lblTemperatura);
            this.grpSignos.Controls.Add(this.txtTemperatura);
            this.grpSignos.Controls.Add(this.lblPresion);
            this.grpSignos.Controls.Add(this.txtPresion);
            this.grpSignos.Location = new System.Drawing.Point(20, 180);
            this.grpSignos.Name = "grpSignos";
            this.grpSignos.Size = new System.Drawing.Size(460, 110);
            this.grpSignos.TabIndex = 4;
            this.grpSignos.TabStop = false;
            this.grpSignos.Text = "Signos vitales";
            // 
            // lblSpO2
            // 
            this.lblSpO2.AutoSize = true;
            this.lblSpO2.Location = new System.Drawing.Point(240, 70);
            this.lblSpO2.Name = "lblSpO2";
            this.lblSpO2.Size = new System.Drawing.Size(39, 15);
            this.lblSpO2.TabIndex = 7;
            this.lblSpO2.Text = "SpO2:";
            // 
            // txtSpO2
            // 
            this.txtSpO2.Location = new System.Drawing.Point(310, 67);
            this.txtSpO2.Name = "txtSpO2";
            this.txtSpO2.Size = new System.Drawing.Size(120, 23);
            this.txtSpO2.TabIndex = 7;
            // 
            // lblPulso
            // 
            this.lblPulso.AutoSize = true;
            this.lblPulso.Location = new System.Drawing.Point(20, 70);
            this.lblPulso.Name = "lblPulso";
            this.lblPulso.Size = new System.Drawing.Size(38, 15);
            this.lblPulso.TabIndex = 5;
            this.lblPulso.Text = "Pulso:";
            // 
            // txtPulso
            // 
            this.txtPulso.Location = new System.Drawing.Point(120, 67);
            this.txtPulso.Name = "txtPulso";
            this.txtPulso.Size = new System.Drawing.Size(100, 23);
            this.txtPulso.TabIndex = 6;
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.Location = new System.Drawing.Point(240, 35);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(80, 15);
            this.lblTemperatura.TabIndex = 3;
            this.lblTemperatura.Text = "Temperatura:";
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.Location = new System.Drawing.Point(310, 32);
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(120, 23);
            this.txtTemperatura.TabIndex = 5;
            // 
            // lblPresion
            // 
            this.lblPresion.AutoSize = true;
            this.lblPresion.Location = new System.Drawing.Point(20, 35);
            this.lblPresion.Name = "lblPresion";
            this.lblPresion.Size = new System.Drawing.Size(94, 15);
            this.lblPresion.TabIndex = 0;
            this.lblPresion.Text = "Presión arterial:";
            // 
            // txtPresion
            // 
            this.txtPresion.Location = new System.Drawing.Point(120, 32);
            this.txtPresion.Name = "txtPresion";
            this.txtPresion.Size = new System.Drawing.Size(100, 23);
            this.txtPresion.TabIndex = 4;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(20, 305);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(86, 15);
            this.lblObservaciones.TabIndex = 9;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(20, 325);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservaciones.Size = new System.Drawing.Size(460, 90);
            this.txtObservaciones.TabIndex = 8;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(284, 430);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(90, 27);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(390, 430);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 27);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmRegistroEnfermeria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 471);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.grpSignos);
            this.Controls.Add(this.cboTipoItem);
            this.Controls.Add(this.lblTipoItem);
            this.Controls.Add(this.txtItemOrden);
            this.Controls.Add(this.lblItemOrden);
            this.Controls.Add(this.txtNumeroOrden);
            this.Controls.Add(this.lblNumeroOrden);
            this.Controls.Add(this.txtCedulaPaciente);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmRegistroEnfermeria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de enfermería";
            this.Load += new System.EventHandler(this.FrmRegistroEnfermeria_Load);
            this.grpSignos.ResumeLayout(false);
            this.grpSignos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.TextBox txtCedulaPaciente;
        private System.Windows.Forms.Label lblNumeroOrden;
        private System.Windows.Forms.TextBox txtNumeroOrden;
        private System.Windows.Forms.Label lblItemOrden;
        private System.Windows.Forms.TextBox txtItemOrden;
        private System.Windows.Forms.Label lblTipoItem;
        private System.Windows.Forms.ComboBox cboTipoItem;
        private System.Windows.Forms.GroupBox grpSignos;
        private System.Windows.Forms.Label lblSpO2;
        private System.Windows.Forms.TextBox txtSpO2;
        private System.Windows.Forms.Label lblPulso;
        private System.Windows.Forms.TextBox txtPulso;
        private System.Windows.Forms.Label lblTemperatura;
        private System.Windows.Forms.TextBox txtTemperatura;
        private System.Windows.Forms.Label lblPresion;
        private System.Windows.Forms.TextBox txtPresion;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}