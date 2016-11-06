namespace ClinicaFrba.Listados
{
    partial class ListadoEstadistico
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtanio = new System.Windows.Forms.TextBox();
            this.cmbsemestre = new System.Windows.Forms.ComboBox();
            this.cmbmes = new System.Windows.Forms.ComboBox();
            this.btncancelaciones = new System.Windows.Forms.Button();
            this.btnconsultados = new System.Windows.Forms.Button();
            this.btnhoras = new System.Windows.Forms.Button();
            this.btnbonos = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnbonoconsulta = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Semestre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(395, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Año (AAAA):";
            // 
            // txtanio
            // 
            this.txtanio.Location = new System.Drawing.Point(84, 24);
            this.txtanio.Name = "txtanio";
            this.txtanio.Size = new System.Drawing.Size(100, 20);
            this.txtanio.TabIndex = 3;
            // 
            // cmbsemestre
            // 
            this.cmbsemestre.FormattingEnabled = true;
            this.cmbsemestre.Location = new System.Drawing.Point(259, 24);
            this.cmbsemestre.Name = "cmbsemestre";
            this.cmbsemestre.Size = new System.Drawing.Size(121, 21);
            this.cmbsemestre.TabIndex = 4;
            // 
            // cmbmes
            // 
            this.cmbmes.FormattingEnabled = true;
            this.cmbmes.Location = new System.Drawing.Point(431, 23);
            this.cmbmes.Name = "cmbmes";
            this.cmbmes.Size = new System.Drawing.Size(85, 21);
            this.cmbmes.TabIndex = 5;
            // 
            // btncancelaciones
            // 
            this.btncancelaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelaciones.Location = new System.Drawing.Point(16, 19);
            this.btncancelaciones.Name = "btncancelaciones";
            this.btncancelaciones.Size = new System.Drawing.Size(96, 75);
            this.btncancelaciones.TabIndex = 6;
            this.btncancelaciones.Text = "Top 5 especialidades con mas cancelaciones";
            this.btncancelaciones.UseVisualStyleBackColor = true;
            // 
            // btnconsultados
            // 
            this.btnconsultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconsultados.Location = new System.Drawing.Point(118, 19);
            this.btnconsultados.Name = "btnconsultados";
            this.btnconsultados.Size = new System.Drawing.Size(93, 75);
            this.btnconsultados.TabIndex = 7;
            this.btnconsultados.Text = "Top 5 profesionales mas consultados por plan";
            this.btnconsultados.UseVisualStyleBackColor = true;
            // 
            // btnhoras
            // 
            this.btnhoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhoras.Location = new System.Drawing.Point(217, 19);
            this.btnhoras.Name = "btnhoras";
            this.btnhoras.Size = new System.Drawing.Size(94, 75);
            this.btnhoras.TabIndex = 8;
            this.btnhoras.Text = "Top 5 profesionales con menos horas trabajadas";
            this.btnhoras.UseVisualStyleBackColor = true;
            // 
            // btnbonos
            // 
            this.btnbonos.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbonos.Location = new System.Drawing.Point(317, 19);
            this.btnbonos.Name = "btnbonos";
            this.btnbonos.Size = new System.Drawing.Size(96, 75);
            this.btnbonos.TabIndex = 9;
            this.btnbonos.Text = "Top 5 afiliados con mayor cantidad de bonos comprados";
            this.btnbonos.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnbonoconsulta);
            this.groupBox1.Controls.Add(this.btnbonos);
            this.groupBox1.Controls.Add(this.btncancelaciones);
            this.groupBox1.Controls.Add(this.btnhoras);
            this.groupBox1.Controls.Add(this.btnconsultados);
            this.groupBox1.Location = new System.Drawing.Point(12, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 110);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listados";
            // 
            // btnbonoconsulta
            // 
            this.btnbonoconsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbonoconsulta.Location = new System.Drawing.Point(419, 19);
            this.btnbonoconsulta.Name = "btnbonoconsulta";
            this.btnbonoconsulta.Size = new System.Drawing.Size(95, 75);
            this.btnbonoconsulta.TabIndex = 10;
            this.btnbonoconsulta.Text = "Top 5 especialidades de Médicos con mas bonos de consulta utilizados";
            this.btnbonoconsulta.UseVisualStyleBackColor = true;
            // 
            // ListadoEstadistico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(544, 395);
            this.Controls.Add(this.cmbmes);
            this.Controls.Add(this.cmbsemestre);
            this.Controls.Add(this.txtanio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ListadoEstadistico";
            this.Text = "Listado Estadístico";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtanio;
        private System.Windows.Forms.ComboBox cmbsemestre;
        private System.Windows.Forms.ComboBox cmbmes;
        private System.Windows.Forms.Button btncancelaciones;
        private System.Windows.Forms.Button btnconsultados;
        private System.Windows.Forms.Button btnhoras;
        private System.Windows.Forms.Button btnbonos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnbonoconsulta;
    }
}