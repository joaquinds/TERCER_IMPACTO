namespace ClinicaFrba.Pedir_Turno
{
    partial class Pedir_Turno
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
            this.cmbElegirEsp = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbElegirProf = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbElegirFecha = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbElegirHorario = new System.Windows.Forms.ComboBox();
            this.btnConfirmarT = new System.Windows.Forms.Button();
            this.btnConfirmarP = new System.Windows.Forms.Button();
            this.btnEEsp = new System.Windows.Forms.Button();
            this.btnElegirFecha = new System.Windows.Forms.Button();
            this.comboAfiliado = new System.Windows.Forms.ComboBox();
            this.labelAdmin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbElegirEsp
            // 
            this.cmbElegirEsp.FormattingEnabled = true;
            this.cmbElegirEsp.Location = new System.Drawing.Point(30, 75);
            this.cmbElegirEsp.Name = "cmbElegirEsp";
            this.cmbElegirEsp.Size = new System.Drawing.Size(121, 21);
            this.cmbElegirEsp.TabIndex = 0;
            this.cmbElegirEsp.SelectedIndexChanged += new System.EventHandler(this.cmbElegirEsp_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione el profesional con el que desea atenderse:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleccione la especialidad:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmbElegirProf
            // 
            this.cmbElegirProf.FormattingEnabled = true;
            this.cmbElegirProf.Location = new System.Drawing.Point(29, 140);
            this.cmbElegirProf.Name = "cmbElegirProf";
            this.cmbElegirProf.Size = new System.Drawing.Size(121, 21);
            this.cmbElegirProf.TabIndex = 3;
            this.cmbElegirProf.SelectedIndexChanged += new System.EventHandler(this.cmbElegirProf_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Seleccione la fecha que desea atenderse:";
            // 
            // cmbElegirFecha
            // 
            this.cmbElegirFecha.FormattingEnabled = true;
            this.cmbElegirFecha.Location = new System.Drawing.Point(29, 215);
            this.cmbElegirFecha.Name = "cmbElegirFecha";
            this.cmbElegirFecha.Size = new System.Drawing.Size(121, 21);
            this.cmbElegirFecha.TabIndex = 5;
            this.cmbElegirFecha.SelectedIndexChanged += new System.EventHandler(this.cmbElegirFecha_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Seleccione horario";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cmbElegirHorario
            // 
            this.cmbElegirHorario.FormattingEnabled = true;
            this.cmbElegirHorario.Location = new System.Drawing.Point(29, 285);
            this.cmbElegirHorario.Name = "cmbElegirHorario";
            this.cmbElegirHorario.Size = new System.Drawing.Size(121, 21);
            this.cmbElegirHorario.TabIndex = 7;
            // 
            // btnConfirmarT
            // 
            this.btnConfirmarT.Location = new System.Drawing.Point(29, 348);
            this.btnConfirmarT.Name = "btnConfirmarT";
            this.btnConfirmarT.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmarT.TabIndex = 8;
            this.btnConfirmarT.Text = "Confirmar";
            this.btnConfirmarT.UseVisualStyleBackColor = true;
            this.btnConfirmarT.Click += new System.EventHandler(this.btnConfirmarT_Click);
            // 
            // btnConfirmarP
            // 
            this.btnConfirmarP.Location = new System.Drawing.Point(214, 140);
            this.btnConfirmarP.Name = "btnConfirmarP";
            this.btnConfirmarP.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmarP.TabIndex = 9;
            this.btnConfirmarP.Text = "Seleccionar";
            this.btnConfirmarP.UseVisualStyleBackColor = true;
            this.btnConfirmarP.Click += new System.EventHandler(this.btnConfirmarP_Click);
            // 
            // btnEEsp
            // 
            this.btnEEsp.Location = new System.Drawing.Point(214, 75);
            this.btnEEsp.Name = "btnEEsp";
            this.btnEEsp.Size = new System.Drawing.Size(75, 23);
            this.btnEEsp.TabIndex = 10;
            this.btnEEsp.Text = "Seleccionar";
            this.btnEEsp.UseVisualStyleBackColor = true;
            this.btnEEsp.Click += new System.EventHandler(this.btnEEsp_Click);
            // 
            // btnElegirFecha
            // 
            this.btnElegirFecha.Location = new System.Drawing.Point(214, 215);
            this.btnElegirFecha.Name = "btnElegirFecha";
            this.btnElegirFecha.Size = new System.Drawing.Size(75, 23);
            this.btnElegirFecha.TabIndex = 11;
            this.btnElegirFecha.Text = "Seleccionar";
            this.btnElegirFecha.UseVisualStyleBackColor = true;
            this.btnElegirFecha.Click += new System.EventHandler(this.btnElegirFecha_Click);
            // 
            // comboAfiliado
            // 
            this.comboAfiliado.FormattingEnabled = true;
            this.comboAfiliado.Location = new System.Drawing.Point(214, 12);
            this.comboAfiliado.Name = "comboAfiliado";
            this.comboAfiliado.Size = new System.Drawing.Size(121, 21);
            this.comboAfiliado.TabIndex = 12;
            this.comboAfiliado.SelectedIndexChanged += new System.EventHandler(this.comboAfiliado_SelectedIndexChanged);
            // 
            // labelAdmin
            // 
            this.labelAdmin.AutoSize = true;
            this.labelAdmin.Location = new System.Drawing.Point(26, 15);
            this.labelAdmin.Name = "labelAdmin";
            this.labelAdmin.Size = new System.Drawing.Size(79, 13);
            this.labelAdmin.TabIndex = 13;
            this.labelAdmin.Text = "Nro de Afiliado:";
            // 
            // Pedir_Turno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 412);
            this.Controls.Add(this.labelAdmin);
            this.Controls.Add(this.comboAfiliado);
            this.Controls.Add(this.btnElegirFecha);
            this.Controls.Add(this.btnEEsp);
            this.Controls.Add(this.btnConfirmarP);
            this.Controls.Add(this.btnConfirmarT);
            this.Controls.Add(this.cmbElegirHorario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbElegirFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbElegirProf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbElegirEsp);
            this.Name = "Pedir_Turno";
            this.Text = "Pedir_Turno";
            this.Load += new System.EventHandler(this.Pedir_Turno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbElegirEsp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbElegirProf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbElegirFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbElegirHorario;
        private System.Windows.Forms.Button btnConfirmarT;
        private System.Windows.Forms.Button btnConfirmarP;
        private System.Windows.Forms.Button btnEEsp;
        private System.Windows.Forms.Button btnElegirFecha;
        private System.Windows.Forms.ComboBox comboAfiliado;
        private System.Windows.Forms.Label labelAdmin;
    }
}