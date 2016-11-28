﻿namespace ClinicaFrba.MenuPrincipal
{
    partial class Menus
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
            this.btnABMRol = new System.Windows.Forms.Button();
            this.btnAgenda = new System.Windows.Forms.Button();
            this.btnafiliado = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnPTurno = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRegistrarResul = new System.Windows.Forms.Button();
            this.btnCancelarA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnABMRol
            // 
            this.btnABMRol.Location = new System.Drawing.Point(22, 33);
            this.btnABMRol.Name = "btnABMRol";
            this.btnABMRol.Size = new System.Drawing.Size(75, 23);
            this.btnABMRol.TabIndex = 0;
            this.btnABMRol.Text = "ABM Rol";
            this.btnABMRol.UseVisualStyleBackColor = true;
            this.btnABMRol.Click += new System.EventHandler(this.btnABMRol_Click);
            // 
            // btnAgenda
            // 
            this.btnAgenda.Location = new System.Drawing.Point(22, 77);
            this.btnAgenda.Name = "btnAgenda";
            this.btnAgenda.Size = new System.Drawing.Size(75, 23);
            this.btnAgenda.TabIndex = 1;
            this.btnAgenda.Text = "Agenda";
            this.btnAgenda.UseVisualStyleBackColor = true;
            this.btnAgenda.Click += new System.EventHandler(this.btnAgenda_Click);
            // 
            // btnafiliado
            // 
            this.btnafiliado.Location = new System.Drawing.Point(171, 33);
            this.btnafiliado.Name = "btnafiliado";
            this.btnafiliado.Size = new System.Drawing.Size(75, 23);
            this.btnafiliado.TabIndex = 2;
            this.btnafiliado.Text = "ABM Afiliado";
            this.btnafiliado.UseVisualStyleBackColor = true;
            this.btnafiliado.Click += new System.EventHandler(this.btnafiliado_Click_1);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(22, 201);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(103, 23);
            this.btnRegistrar.TabIndex = 3;
            this.btnRegistrar.Text = "Registrar Llegada";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click_1);
            // 
            // btnPTurno
            // 
            this.btnPTurno.Location = new System.Drawing.Point(22, 160);
            this.btnPTurno.Name = "btnPTurno";
            this.btnPTurno.Size = new System.Drawing.Size(103, 23);
            this.btnPTurno.TabIndex = 4;
            this.btnPTurno.Text = "Pedir Turno";
            this.btnPTurno.UseVisualStyleBackColor = true;
            this.btnPTurno.Click += new System.EventHandler(this.btnPTurno_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Comprar Bono";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRegistrarResul
            // 
            this.btnRegistrarResul.Location = new System.Drawing.Point(171, 77);
            this.btnRegistrarResul.Name = "btnRegistrarResul";
            this.btnRegistrarResul.Size = new System.Drawing.Size(177, 23);
            this.btnRegistrarResul.TabIndex = 6;
            this.btnRegistrarResul.Text = "Registrar resultado de atencion";
            this.btnRegistrarResul.UseVisualStyleBackColor = true;
            this.btnRegistrarResul.Click += new System.EventHandler(this.btnRegistrarResul_Click);
            // 
            // btnCancelarA
            // 
            this.btnCancelarA.Location = new System.Drawing.Point(171, 120);
            this.btnCancelarA.Name = "btnCancelarA";
            this.btnCancelarA.Size = new System.Drawing.Size(177, 23);
            this.btnCancelarA.TabIndex = 7;
            this.btnCancelarA.Text = "Cancelar Turno Afiliado";
            this.btnCancelarA.UseVisualStyleBackColor = true;
            this.btnCancelarA.Click += new System.EventHandler(this.cmbTurnoA_Click);
            // 
            // Menus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 286);
            this.Controls.Add(this.btnCancelarA);
            this.Controls.Add(this.btnRegistrarResul);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPTurno);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnafiliado);
            this.Controls.Add(this.btnAgenda);
            this.Controls.Add(this.btnABMRol);
            this.Name = "Menus";
            this.Text = "ClinicaFrba";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnABMRol;
        private System.Windows.Forms.Button btnAgenda;
        private System.Windows.Forms.Button btnafiliado;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnPTurno;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRegistrarResul;
        private System.Windows.Forms.Button btnCancelarA;
    }
}