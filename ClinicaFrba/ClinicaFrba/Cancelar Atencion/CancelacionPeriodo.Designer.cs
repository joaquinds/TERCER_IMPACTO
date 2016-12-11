namespace ClinicaFrba.Cancelar_Atencion
{
    partial class CancelacionPeriodo
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
            this.txtCancelacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMedico = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerHasta = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDesde = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtCancelacion
            // 
            this.txtCancelacion.Location = new System.Drawing.Point(68, 244);
            this.txtCancelacion.Name = "txtCancelacion";
            this.txtCancelacion.Size = new System.Drawing.Size(317, 20);
            this.txtCancelacion.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Explique por que da de baja el turno:";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(71, 299);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(180, 35);
            this.btnConfirmar.TabIndex = 12;
            this.btnConfirmar.Text = "Confirmar cancelacion";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Seleccione el periodo de tiempo que desea dar de baja";
            // 
            // cmbMedico
            // 
            this.cmbMedico.FormattingEnabled = true;
            this.cmbMedico.Location = new System.Drawing.Point(246, 52);
            this.cmbMedico.Name = "cmbMedico";
            this.cmbMedico.Size = new System.Drawing.Size(121, 21);
            this.cmbMedico.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Seleccione matricula medico:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Fecha Hasta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Fecha Desde:";
            // 
            // dateTimePickerHasta
            // 
            this.dateTimePickerHasta.Location = new System.Drawing.Point(167, 158);
            this.dateTimePickerHasta.Name = "dateTimePickerHasta";
            this.dateTimePickerHasta.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerHasta.TabIndex = 23;
            // 
            // dateTimePickerDesde
            // 
            this.dateTimePickerDesde.Location = new System.Drawing.Point(167, 132);
            this.dateTimePickerDesde.Name = "dateTimePickerDesde";
            this.dateTimePickerDesde.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDesde.TabIndex = 22;
            // 
            // CancelacionPeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 406);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePickerHasta);
            this.Controls.Add(this.dateTimePickerDesde);
            this.Controls.Add(this.txtCancelacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbMedico);
            this.Controls.Add(this.label1);
            this.Name = "CancelacionPeriodo";
            this.Text = "CancelacionPeriodo";
            this.Load += new System.EventHandler(this.CancelacionPeriodo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCancelacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMedico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerHasta;
        private System.Windows.Forms.DateTimePicker dateTimePickerDesde;
    }
}