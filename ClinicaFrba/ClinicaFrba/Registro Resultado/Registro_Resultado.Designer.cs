namespace ClinicaFrba.Registro_Resultado
{
    partial class Registrar_Resultado
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
            this.txtSintomas = new System.Windows.Forms.TextBox();
            this.txtEnfermedad = new System.Windows.Forms.TextBox();
            this.lblSintomas = new System.Windows.Forms.Label();
            this.lblDiagnostico = new System.Windows.Forms.Label();
            this.cmbMedico = new System.Windows.Forms.ComboBox();
            this.cmbHora = new System.Windows.Forms.ComboBox();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMedico = new System.Windows.Forms.Button();
            this.btnFecha = new System.Windows.Forms.Button();
            this.btnDiagnostico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSintomas
            // 
            this.txtSintomas.Location = new System.Drawing.Point(33, 231);
            this.txtSintomas.Name = "txtSintomas";
            this.txtSintomas.Size = new System.Drawing.Size(100, 20);
            this.txtSintomas.TabIndex = 0;
            this.txtSintomas.TextChanged += new System.EventHandler(this.txtSintomas_TextChanged);
            // 
            // txtEnfermedad
            // 
            this.txtEnfermedad.Location = new System.Drawing.Point(233, 231);
            this.txtEnfermedad.Name = "txtEnfermedad";
            this.txtEnfermedad.Size = new System.Drawing.Size(100, 20);
            this.txtEnfermedad.TabIndex = 1;
            // 
            // lblSintomas
            // 
            this.lblSintomas.AutoSize = true;
            this.lblSintomas.Location = new System.Drawing.Point(29, 198);
            this.lblSintomas.Name = "lblSintomas";
            this.lblSintomas.Size = new System.Drawing.Size(105, 13);
            this.lblSintomas.TabIndex = 2;
            this.lblSintomas.Text = "Ingrese los sintomas:";
            // 
            // lblDiagnostico
            // 
            this.lblDiagnostico.AutoSize = true;
            this.lblDiagnostico.Location = new System.Drawing.Point(230, 198);
            this.lblDiagnostico.Name = "lblDiagnostico";
            this.lblDiagnostico.Size = new System.Drawing.Size(113, 13);
            this.lblDiagnostico.TabIndex = 3;
            this.lblDiagnostico.Text = "Ingrese el diagnostico:";
            // 
            // cmbMedico
            // 
            this.cmbMedico.FormattingEnabled = true;
            this.cmbMedico.Location = new System.Drawing.Point(30, 33);
            this.cmbMedico.Name = "cmbMedico";
            this.cmbMedico.Size = new System.Drawing.Size(121, 21);
            this.cmbMedico.TabIndex = 4;
            // 
            // cmbHora
            // 
            this.cmbHora.FormattingEnabled = true;
            this.cmbHora.Location = new System.Drawing.Point(30, 106);
            this.cmbHora.Name = "cmbHora";
            this.cmbHora.Size = new System.Drawing.Size(121, 21);
            this.cmbHora.TabIndex = 5;
            this.cmbHora.SelectedIndexChanged += new System.EventHandler(this.cmbHora_SelectedIndexChanged);
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Location = new System.Drawing.Point(32, 14);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(110, 13);
            this.lblAdmin.TabIndex = 6;
            this.lblAdmin.Text = "Seleccione Id Medico";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(283, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Confirme que el paciente llego a tiempo y hora en la fecha:";
            // 
            // btnMedico
            // 
            this.btnMedico.Location = new System.Drawing.Point(209, 33);
            this.btnMedico.Name = "btnMedico";
            this.btnMedico.Size = new System.Drawing.Size(75, 23);
            this.btnMedico.TabIndex = 8;
            this.btnMedico.Text = "Seleccionar";
            this.btnMedico.UseVisualStyleBackColor = true;
            this.btnMedico.Click += new System.EventHandler(this.btnMedico_Click);
            // 
            // btnFecha
            // 
            this.btnFecha.Location = new System.Drawing.Point(209, 106);
            this.btnFecha.Name = "btnFecha";
            this.btnFecha.Size = new System.Drawing.Size(75, 23);
            this.btnFecha.TabIndex = 9;
            this.btnFecha.Text = "Seleccionar";
            this.btnFecha.UseVisualStyleBackColor = true;
            this.btnFecha.Click += new System.EventHandler(this.btnFecha_Click);
            // 
            // btnDiagnostico
            // 
            this.btnDiagnostico.Location = new System.Drawing.Point(98, 274);
            this.btnDiagnostico.Name = "btnDiagnostico";
            this.btnDiagnostico.Size = new System.Drawing.Size(186, 23);
            this.btnDiagnostico.TabIndex = 10;
            this.btnDiagnostico.Text = "Confirmar diagnostico";
            this.btnDiagnostico.UseVisualStyleBackColor = true;
            this.btnDiagnostico.Click += new System.EventHandler(this.btnDiagnostico_Click);
            // 
            // Registrar_Resultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 329);
            this.Controls.Add(this.btnDiagnostico);
            this.Controls.Add(this.btnFecha);
            this.Controls.Add(this.btnMedico);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.cmbHora);
            this.Controls.Add(this.cmbMedico);
            this.Controls.Add(this.lblDiagnostico);
            this.Controls.Add(this.lblSintomas);
            this.Controls.Add(this.txtEnfermedad);
            this.Controls.Add(this.txtSintomas);
            this.Name = "Registrar_Resultado";
            this.Text = "Registrar resultado de atencion medica";
            this.Load += new System.EventHandler(this.Registrar_Resultado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSintomas;
        private System.Windows.Forms.TextBox txtEnfermedad;
        private System.Windows.Forms.Label lblSintomas;
        private System.Windows.Forms.Label lblDiagnostico;
        private System.Windows.Forms.ComboBox cmbMedico;
        private System.Windows.Forms.ComboBox cmbHora;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMedico;
        private System.Windows.Forms.Button btnFecha;
        private System.Windows.Forms.Button btnDiagnostico;
    }
}