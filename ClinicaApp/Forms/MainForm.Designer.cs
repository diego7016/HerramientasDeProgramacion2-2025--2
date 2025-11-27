using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaApp.Forms
{
    public partial class MainForm
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

        #region Código generado por el Diseñador

        private void InitializeComponent()
        {
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.btnRRHH = new System.Windows.Forms.Button();
            this.btnAdministrativo = new System.Windows.Forms.Button();
            this.btnSoporteInfo = new System.Windows.Forms.Button();
            this.btnEnfermeria = new System.Windows.Forms.Button();
            this.btnMedico = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnFacturacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBienvenida.Location = new System.Drawing.Point(23, 21);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(99, 23);
            this.lblBienvenida.TabIndex = 0;
            this.lblBienvenida.Text = "Bienvenido";
            // 
            // btnRRHH
            // 
            this.btnRRHH.Location = new System.Drawing.Point(46, 56);
            this.btnRRHH.Name = "btnRRHH";
            this.btnRRHH.Size = new System.Drawing.Size(171, 43);
            this.btnRRHH.TabIndex = 1;
            this.btnRRHH.Text = "Recursos Humanos";
            this.btnRRHH.UseVisualStyleBackColor = true;
            this.btnRRHH.Click += new System.EventHandler(this.btnRRHH_Click);
            // 
            // btnAdministrativo
            // 
            this.btnAdministrativo.Location = new System.Drawing.Point(46, 105);
            this.btnAdministrativo.Name = "btnAdministrativo";
            this.btnAdministrativo.Size = new System.Drawing.Size(171, 43);
            this.btnAdministrativo.TabIndex = 2;
            this.btnAdministrativo.Text = "Administrativo";
            this.btnAdministrativo.UseVisualStyleBackColor = true;
            this.btnAdministrativo.Click += new System.EventHandler(this.btnAdministrativo_Click);
            // 
            // btnSoporteInfo
            // 
            this.btnSoporteInfo.Location = new System.Drawing.Point(46, 163);
            this.btnSoporteInfo.Name = "btnSoporteInfo";
            this.btnSoporteInfo.Size = new System.Drawing.Size(171, 43);
            this.btnSoporteInfo.TabIndex = 3;
            this.btnSoporteInfo.Text = "Soporte Información";
            this.btnSoporteInfo.UseVisualStyleBackColor = true;
            this.btnSoporteInfo.Click += new System.EventHandler(this.btnSoporteInfo_Click);
            // 
            // btnEnfermeria
            // 
            this.btnEnfermeria.Location = new System.Drawing.Point(251, 56);
            this.btnEnfermeria.Name = "btnEnfermeria";
            this.btnEnfermeria.Size = new System.Drawing.Size(171, 43);
            this.btnEnfermeria.TabIndex = 4;
            this.btnEnfermeria.Text = "Enfermería";
            this.btnEnfermeria.UseVisualStyleBackColor = true;
            this.btnEnfermeria.Click += new System.EventHandler(this.btnEnfermeria_Click);
            // 
            // btnMedico
            // 
            this.btnMedico.Location = new System.Drawing.Point(251, 105);
            this.btnMedico.Name = "btnMedico";
            this.btnMedico.Size = new System.Drawing.Size(171, 43);
            this.btnMedico.TabIndex = 5;
            this.btnMedico.Text = "Médicos";
            this.btnMedico.UseVisualStyleBackColor = true;
            this.btnMedico.Click += new System.EventHandler(this.btnMedico_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(122, 242);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(171, 32);
            this.btnCerrarSesion.TabIndex = 6;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.Location = new System.Drawing.Point(251, 163);
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Size = new System.Drawing.Size(170, 42);
            this.btnFacturacion.TabIndex = 7;
            this.btnFacturacion.Text = "Facturación";
            this.btnFacturacion.UseVisualStyleBackColor = true;
            this.btnFacturacion.Click += new System.EventHandler(this.btnFacturacion_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 327);
            this.Controls.Add(this.btnFacturacion);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnMedico);
            this.Controls.Add(this.btnEnfermeria);
            this.Controls.Add(this.btnSoporteInfo);
            this.Controls.Add(this.btnAdministrativo);
            this.Controls.Add(this.btnRRHH);
            this.Controls.Add(this.lblBienvenida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú principal - Clínica";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Button btnRRHH;
        private System.Windows.Forms.Button btnAdministrativo;
        private System.Windows.Forms.Button btnSoporteInfo;
        private System.Windows.Forms.Button btnEnfermeria;
        private System.Windows.Forms.Button btnMedico;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnFacturacion;
    }
}
