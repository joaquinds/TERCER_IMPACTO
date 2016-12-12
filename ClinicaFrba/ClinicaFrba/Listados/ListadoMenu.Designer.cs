namespace ClinicaFrba.Listados
{
    partial class ListadoMenu
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
            this.btnbonoscomprados = new System.Windows.Forms.Button();
            this.btnbonosutilizados = new System.Windows.Forms.Button();
            this.btnconsulta = new System.Windows.Forms.Button();
            this.btnhoras = new System.Windows.Forms.Button();
            this.btncancelaciones = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnbonoscomprados
            // 
            this.btnbonoscomprados.Location = new System.Drawing.Point(41, 116);
            this.btnbonoscomprados.Name = "btnbonoscomprados";
            this.btnbonoscomprados.Size = new System.Drawing.Size(434, 38);
            this.btnbonoscomprados.TabIndex = 5;
            this.btnbonoscomprados.Text = "Afiliado con mas bonos comprados";
            this.btnbonoscomprados.UseVisualStyleBackColor = true;
            this.btnbonoscomprados.Click += new System.EventHandler(this.btnbonoscomprados_Click);
            // 
            // btnbonosutilizados
            // 
            this.btnbonosutilizados.Location = new System.Drawing.Point(41, 64);
            this.btnbonosutilizados.Name = "btnbonosutilizados";
            this.btnbonosutilizados.Size = new System.Drawing.Size(434, 38);
            this.btnbonosutilizados.TabIndex = 4;
            this.btnbonosutilizados.Text = "Especialidades con mas bonos utilizados";
            this.btnbonosutilizados.UseVisualStyleBackColor = true;
            this.btnbonosutilizados.Click += new System.EventHandler(this.btnbonosutilizados_Click);
            // 
            // btnconsulta
            // 
            this.btnconsulta.Location = new System.Drawing.Point(41, 12);
            this.btnconsulta.Name = "btnconsulta";
            this.btnconsulta.Size = new System.Drawing.Size(434, 38);
            this.btnconsulta.TabIndex = 3;
            this.btnconsulta.Text = "Profesionales mas consultados por plan";
            this.btnconsulta.UseVisualStyleBackColor = true;
            this.btnconsulta.Click += new System.EventHandler(this.btnconsulta_Click);
            // 
            // btnhoras
            // 
            this.btnhoras.Location = new System.Drawing.Point(41, 168);
            this.btnhoras.Name = "btnhoras";
            this.btnhoras.Size = new System.Drawing.Size(434, 38);
            this.btnhoras.TabIndex = 6;
            this.btnhoras.Text = "Profesionales con menos horas trabajadas";
            this.btnhoras.UseVisualStyleBackColor = true;
            this.btnhoras.Click += new System.EventHandler(this.btnhoras_Click);
            // 
            // btncancelaciones
            // 
            this.btncancelaciones.Location = new System.Drawing.Point(41, 220);
            this.btncancelaciones.Name = "btncancelaciones";
            this.btncancelaciones.Size = new System.Drawing.Size(434, 38);
            this.btncancelaciones.TabIndex = 7;
            this.btncancelaciones.Text = "Especialidades que mas registraron cancelaciones";
            this.btncancelaciones.UseVisualStyleBackColor = true;
            this.btncancelaciones.Click += new System.EventHandler(this.btncancelaciones_Click);
            // 
            // ListadoMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 289);
            this.Controls.Add(this.btncancelaciones);
            this.Controls.Add(this.btnhoras);
            this.Controls.Add(this.btnbonoscomprados);
            this.Controls.Add(this.btnbonosutilizados);
            this.Controls.Add(this.btnconsulta);
            this.Name = "ListadoMenu";
            this.Text = "ListadoMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnbonoscomprados;
        private System.Windows.Forms.Button btnbonosutilizados;
        private System.Windows.Forms.Button btnconsulta;
        private System.Windows.Forms.Button btnhoras;
        private System.Windows.Forms.Button btncancelaciones;
    }
}