namespace ClinicaApp.Forms.Soporte
{
    partial class FrmNuevaAyudaDiagnostica
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador

        private void InitializeComponent()
        {
            this.lblId = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.lblIdTipoEspecialista = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtIdTipoEspecialista = new System.Windows.Forms.TextBox();
            this.chkRequiereEspecialista = new System.Windows.Forms.CheckBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(26, 24);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 15);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(26, 60);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 15);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(26, 96);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(40, 15);
            this.lblCosto.TabIndex = 2;
            this.lblCosto.Text = "Costo:";
            // 
            // lblIdTipoEspecialista
            // 
            this.lblIdTipoEspecialista.AutoSize = true;
            this.lblIdTipoEspecialista.Location = new System.Drawing.Point(26, 163);
            this.lblIdTipoEspecialista.Name = "lblIdTipoEspecialista";
            this.lblIdTipoEspecialista.Size = new System.Drawing.Size(107, 15);
            this.lblIdTipoEspecialista.TabIndex = 3;
            this.lblIdTipoEspecialista.Text = "Id tipo especialista:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(151, 21);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(204, 23);
            this.txtId.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(151, 57);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(204, 23);
            this.txtNombre.TabIndex = 1;
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(151, 93);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(204, 23);
            this.txtCosto.TabIndex = 2;
            // 
            // txtIdTipoEspecialista
            // 
            this.txtIdTipoEspecialista.Location = new System.Drawing.Point(151, 160);
            this.txtIdTipoEspecialista.Name = "txtIdTipoEspecialista";
            this.txtIdTipoEspecialista.Size = new System.Drawing.Size(204, 23);
            this.txtIdTipoEspecialista.TabIndex = 4;
            // 
            // chkRequiereEspecialista
            // 
            this.chkRequiereEspecialista.AutoSize = true;
            this.chkRequiereEspecialista.Location = new System.Drawing.Point(151, 130);
            this.chkRequiereEspecialista.Name = "chkRequiereEspecialista";
            this.chkRequiereEspecialista.Size = new System.Drawing.Size(137, 19);
            this.chkRequiereEspecialista.TabIndex = 3;
            this.chkRequiereEspecialista.Text = "Requiere especialista";
            this.chkRequiereEspecialista.UseVisualStyleBackColor = true;
            this.chkRequiereEspecialista.CheckedChanged += new System.EventHandler(this.chkRequiereEspecialista_CheckedChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(151, 206);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(90, 30);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(265, 206);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 30);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmNuevaAyudaDiagnostica
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 255);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.chkRequiereEspecialista);
            this.Controls.Add(this.txtIdTipoEspecialista);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblIdTipoEspecialista);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNuevaAyudaDiagnostica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nueva / Editar ayuda diagnóstica";
            this.Load += new System.EventHandler(this.FrmNuevaAyudaDiagnostica_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Label lblIdTipoEspecialista;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.TextBox txtIdTipoEspecialista;
        private System.Windows.Forms.CheckBox chkRequiereEspecialista;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}