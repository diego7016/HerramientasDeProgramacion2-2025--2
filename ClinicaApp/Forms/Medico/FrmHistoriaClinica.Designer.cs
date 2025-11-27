namespace ClinicaApp.Forms.Medico
{
    partial class FrmHistoriaClinica
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
            this.lblCedulaTitulo = new System.Windows.Forms.Label();
            this.txtCedulaPaciente = new System.Windows.Forms.TextBox();
            this.btnBuscarPaciente = new System.Windows.Forms.Button();
            this.lblNombreTitulo = new System.Windows.Forms.Label();
            this.lblNombrePaciente = new System.Windows.Forms.Label();
            this.lblEdadTitulo = new System.Windows.Forms.Label();
            this.lblEdadPaciente = new System.Windows.Forms.Label();
            this.dgvHistoria = new System.Windows.Forms.DataGridView();
            this.btnNuevaEntrada = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoria)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCedulaTitulo
            // 
            this.lblCedulaTitulo.AutoSize = true;
            this.lblCedulaTitulo.Location = new System.Drawing.Point(12, 15);
            this.lblCedulaTitulo.Name = "lblCedulaTitulo";
            this.lblCedulaTitulo.Size = new System.Drawing.Size(98, 15);
            this.lblCedulaTitulo.TabIndex = 0;
            this.lblCedulaTitulo.Text = "Cédula paciente:";
            // 
            // txtCedulaPaciente
            // 
            this.txtCedulaPaciente.Location = new System.Drawing.Point(116, 12);
            this.txtCedulaPaciente.Name = "txtCedulaPaciente";
            this.txtCedulaPaciente.Size = new System.Drawing.Size(150, 23);
            this.txtCedulaPaciente.TabIndex = 1;
            // 
            // btnBuscarPaciente
            // 
            this.btnBuscarPaciente.Location = new System.Drawing.Point(272, 11);
            this.btnBuscarPaciente.Name = "btnBuscarPaciente";
            this.btnBuscarPaciente.Size = new System.Drawing.Size(90, 25);
            this.btnBuscarPaciente.TabIndex = 2;
            this.btnBuscarPaciente.Text = "Buscar";
            this.btnBuscarPaciente.UseVisualStyleBackColor = true;
            this.btnBuscarPaciente.Click += new System.EventHandler(this.btnBuscarPaciente_Click);
            // 
            // lblNombreTitulo
            // 
            this.lblNombreTitulo.AutoSize = true;
            this.lblNombreTitulo.Location = new System.Drawing.Point(12, 48);
            this.lblNombreTitulo.Name = "lblNombreTitulo";
            this.lblNombreTitulo.Size = new System.Drawing.Size(57, 15);
            this.lblNombreTitulo.TabIndex = 3;
            this.lblNombreTitulo.Text = "Nombre:";
            // 
            // lblNombrePaciente
            // 
            this.lblNombrePaciente.AutoSize = true;
            this.lblNombrePaciente.Location = new System.Drawing.Point(75, 48);
            this.lblNombrePaciente.Name = "lblNombrePaciente";
            this.lblNombrePaciente.Size = new System.Drawing.Size(12, 15);
            this.lblNombrePaciente.TabIndex = 4;
            this.lblNombrePaciente.Text = "-";
            // 
            // lblEdadTitulo
            // 
            this.lblEdadTitulo.AutoSize = true;
            this.lblEdadTitulo.Location = new System.Drawing.Point(350, 48);
            this.lblEdadTitulo.Name = "lblEdadTitulo";
            this.lblEdadTitulo.Size = new System.Drawing.Size(36, 15);
            this.lblEdadTitulo.TabIndex = 5;
            this.lblEdadTitulo.Text = "Edad:";
            // 
            // lblEdadPaciente
            // 
            this.lblEdadPaciente.AutoSize = true;
            this.lblEdadPaciente.Location = new System.Drawing.Point(392, 48);
            this.lblEdadPaciente.Name = "lblEdadPaciente";
            this.lblEdadPaciente.Size = new System.Drawing.Size(12, 15);
            this.lblEdadPaciente.TabIndex = 6;
            this.lblEdadPaciente.Text = "-";
            // 
            // dgvHistoria
            // 
            this.dgvHistoria.AllowUserToAddRows = false;
            this.dgvHistoria.AllowUserToDeleteRows = false;
            this.dgvHistoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHistoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistoria.Location = new System.Drawing.Point(12, 76);
            this.dgvHistoria.MultiSelect = false;
            this.dgvHistoria.Name = "dgvHistoria";
            this.dgvHistoria.ReadOnly = true;
            this.dgvHistoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistoria.Size = new System.Drawing.Size(660, 300);
            this.dgvHistoria.TabIndex = 7;
            // 
            // btnNuevaEntrada
            // 
            this.btnNuevaEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevaEntrada.Location = new System.Drawing.Point(552, 382);
            this.btnNuevaEntrada.Name = "btnNuevaEntrada";
            this.btnNuevaEntrada.Size = new System.Drawing.Size(120, 30);
            this.btnNuevaEntrada.TabIndex = 8;
            this.btnNuevaEntrada.Text = "Nueva entrada";
            this.btnNuevaEntrada.UseVisualStyleBackColor = true;
            this.btnNuevaEntrada.Click += new System.EventHandler(this.btnNuevaEntrada_Click);
            // 
            // FrmHistoriaClinica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 421);
            this.Controls.Add(this.btnNuevaEntrada);
            this.Controls.Add(this.dgvHistoria);
            this.Controls.Add(this.lblEdadPaciente);
            this.Controls.Add(this.lblEdadTitulo);
            this.Controls.Add(this.lblNombrePaciente);
            this.Controls.Add(this.lblNombreTitulo);
            this.Controls.Add(this.btnBuscarPaciente);
            this.Controls.Add(this.txtCedulaPaciente);
            this.Controls.Add(this.lblCedulaTitulo);
            this.Name = "FrmHistoriaClinica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historia Clínica - Búsqueda";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCedulaTitulo;
        private System.Windows.Forms.TextBox txtCedulaPaciente;
        private System.Windows.Forms.Button btnBuscarPaciente;
        private System.Windows.Forms.Label lblNombreTitulo;
        private System.Windows.Forms.Label lblNombrePaciente;
        private System.Windows.Forms.Label lblEdadTitulo;
        private System.Windows.Forms.Label lblEdadPaciente;
        private System.Windows.Forms.DataGridView dgvHistoria;
        private System.Windows.Forms.Button btnNuevaEntrada;
    }
}
