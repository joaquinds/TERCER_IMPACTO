namespace ClinicaFrba.Registro_Llegada
{
    partial class Registro_Llegada
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
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbProfesional = new System.Windows.Forms.ComboBox();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEspecialidad = new System.Windows.Forms.Button();
            this.btnProfesional = new System.Windows.Forms.Button();
            this.btnTurno = new System.Windows.Forms.Button();
            this.lblBonos = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEfectivizar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAfiliado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione especialidad:";
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(15, 56);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(121, 21);
            this.cmbEspecialidad.TabIndex = 1;
            this.cmbEspecialidad.SelectedIndexChanged += new System.EventHandler(this.cmbEspecialidad_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleccione profesional:";
            // 
            // cmbProfesional
            // 
            this.cmbProfesional.FormattingEnabled = true;
            this.cmbProfesional.Location = new System.Drawing.Point(15, 139);
            this.cmbProfesional.Name = "cmbProfesional";
            this.cmbProfesional.Size = new System.Drawing.Size(121, 21);
            this.cmbProfesional.TabIndex = 3;
            this.cmbProfesional.SelectedIndexChanged += new System.EventHandler(this.cmbProfesional_SelectedIndexChanged);
            // 
            // cmbTurno
            // 
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Location = new System.Drawing.Point(15, 209);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(121, 21);
            this.cmbTurno.TabIndex = 4;
            this.cmbTurno.SelectedIndexChanged += new System.EventHandler(this.cmbTurno_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Seleccione turno a efectivizar:";
            // 
            // btnEspecialidad
            // 
            this.btnEspecialidad.Location = new System.Drawing.Point(214, 54);
            this.btnEspecialidad.Name = "btnEspecialidad";
            this.btnEspecialidad.Size = new System.Drawing.Size(75, 23);
            this.btnEspecialidad.TabIndex = 6;
            this.btnEspecialidad.Text = "Seleccionar";
            this.btnEspecialidad.UseVisualStyleBackColor = true;
            this.btnEspecialidad.Click += new System.EventHandler(this.btnEspecialidad_Click);
            // 
            // btnProfesional
            // 
            this.btnProfesional.Location = new System.Drawing.Point(214, 137);
            this.btnProfesional.Name = "btnProfesional";
            this.btnProfesional.Size = new System.Drawing.Size(75, 23);
            this.btnProfesional.TabIndex = 7;
            this.btnProfesional.Text = "Seleccionar";
            this.btnProfesional.UseVisualStyleBackColor = true;
            this.btnProfesional.Click += new System.EventHandler(this.btnProfesional_Click);
            // 
            // btnTurno
            // 
            this.btnTurno.Location = new System.Drawing.Point(214, 209);
            this.btnTurno.Name = "btnTurno";
            this.btnTurno.Size = new System.Drawing.Size(75, 23);
            this.btnTurno.TabIndex = 8;
            this.btnTurno.Text = "Seleccionar";
            this.btnTurno.UseVisualStyleBackColor = true;
            this.btnTurno.Click += new System.EventHandler(this.btnTurno_Click);
            // 
            // lblBonos
            // 
            this.lblBonos.AutoSize = true;
            this.lblBonos.Location = new System.Drawing.Point(232, 282);
            this.lblBonos.Name = "lblBonos";
            this.lblBonos.Size = new System.Drawing.Size(10, 13);
            this.lblBonos.TabIndex = 9;
            this.lblBonos.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cantidad bonos disponibles del usuario:";
            // 
            // btnEfectivizar
            // 
            this.btnEfectivizar.Location = new System.Drawing.Point(15, 348);
            this.btnEfectivizar.Name = "btnEfectivizar";
            this.btnEfectivizar.Size = new System.Drawing.Size(75, 23);
            this.btnEfectivizar.TabIndex = 11;
            this.btnEfectivizar.Text = "Efectivizar";
            this.btnEfectivizar.UseVisualStyleBackColor = true;
            this.btnEfectivizar.Click += new System.EventHandler(this.btnEfectivizar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nro. Afiliado: ";
            // 
            // lblAfiliado
            // 
            this.lblAfiliado.AutoSize = true;
            this.lblAfiliado.Location = new System.Drawing.Point(232, 311);
            this.lblAfiliado.Name = "lblAfiliado";
            this.lblAfiliado.Size = new System.Drawing.Size(10, 13);
            this.lblAfiliado.TabIndex = 13;
            this.lblAfiliado.Text = "-";
            // 
            // Registro_Llegada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 413);
            this.Controls.Add(this.lblAfiliado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEfectivizar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblBonos);
            this.Controls.Add(this.btnTurno);
            this.Controls.Add(this.btnProfesional);
            this.Controls.Add(this.btnEspecialidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTurno);
            this.Controls.Add(this.cmbProfesional);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbEspecialidad);
            this.Controls.Add(this.label1);
            this.Name = "Registro_Llegada";
            this.Text = "Registro Llegada";
            this.Load += new System.EventHandler(this.Registro_Llegada_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbProfesional;
        private System.Windows.Forms.ComboBox cmbTurno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEspecialidad;
        private System.Windows.Forms.Button btnProfesional;
        private System.Windows.Forms.Button btnTurno;
        private System.Windows.Forms.Label lblBonos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEfectivizar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAfiliado;
    }
}