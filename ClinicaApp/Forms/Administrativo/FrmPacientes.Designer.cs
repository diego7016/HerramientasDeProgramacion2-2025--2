namespace ClinicaApp.Forms.Administrativo
{
    partial class FrmPacientes
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
            this.btnNuevoPaciente = new System.Windows.Forms.Button();
            this.btnEditarPaciente = new System.Windows.Forms.Button();
            this.btnEliminarPaciente = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.panelBotones = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            this.panelBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNuevoPaciente
            // 
            this.btnNuevoPaciente.Location = new System.Drawing.Point(12, 12);
            this.btnNuevoPaciente.Name = "btnNuevoPaciente";
            this.btnNuevoPaciente.Size = new System.Drawing.Size(120, 30);
            this.btnNuevoPaciente.TabIndex = 0;
            this.btnNuevoPaciente.Text = "Nuevo paciente";
            this.btnNuevoPaciente.UseVisualStyleBackColor = true;
            this.btnNuevoPaciente.Click += new System.EventHandler(this.btnNuevoPaciente_Click);
            // 
            // btnEditarPaciente
            // 
            this.btnEditarPaciente.Location = new System.Drawing.Point(138, 12);
            this.btnEditarPaciente.Name = "btnEditarPaciente";
            this.btnEditarPaciente.Size = new System.Drawing.Size(120, 30);
            this.btnEditarPaciente.TabIndex = 1;
            this.btnEditarPaciente.Text = "Editar paciente";
            this.btnEditarPaciente.UseVisualStyleBackColor = true;
            this.btnEditarPaciente.Click += new System.EventHandler(this.btnEditarPaciente_Click);
            // 
            // btnEliminarPaciente
            // 
            this.btnEliminarPaciente.Location = new System.Drawing.Point(264, 12);
            this.btnEliminarPaciente.Name = "btnEliminarPaciente";
            this.btnEliminarPaciente.Size = new System.Drawing.Size(120, 30);
            this.btnEliminarPaciente.TabIndex = 2;
            this.btnEliminarPaciente.Text = "Eliminar paciente";
            this.btnEliminarPaciente.UseVisualStyleBackColor = true;
            this.btnEliminarPaciente.Click += new System.EventHandler(this.btnEliminarPaciente_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(390, 12);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(120, 30);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar lista";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.AllowUserToAddRows = false;
            this.dgvPacientes.AllowUserToDeleteRows = false;
            this.dgvPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPacientes.Location = new System.Drawing.Point(0, 54);
            this.dgvPacientes.MultiSelect = false;
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.ReadOnly = true;
            this.dgvPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPacientes.Size = new System.Drawing.Size(800, 396);
            this.dgvPacientes.TabIndex = 1;
            // 
            // panelBotones
            // 
            this.panelBotones.Controls.Add(this.btnNuevoPaciente);
            this.panelBotones.Controls.Add(this.btnEditarPaciente);
            this.panelBotones.Controls.Add(this.btnEliminarPaciente);
            this.panelBotones.Controls.Add(this.btnActualizar);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBotones.Location = new System.Drawing.Point(0, 0);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(800, 54);
            this.panelBotones.TabIndex = 0;
            // 
            // FrmPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvPacientes);
            this.Controls.Add(this.panelBotones);
            this.Name = "FrmPacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal Administrativo - Pacientes";
            this.Load += new System.EventHandler(this.FrmPacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            this.panelBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNuevoPaciente;
        private System.Windows.Forms.Button btnEditarPaciente;
        private System.Windows.Forms.Button btnEliminarPaciente;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.Panel panelBotones;
    }


}
