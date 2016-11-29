namespace ClinicaFrba.Cancelar_Atencion
{
    partial class CancelarAtencion
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
            this.cmbAfiliado = new System.Windows.Forms.ComboBox();
            this.btnAfiliado = new System.Windows.Forms.Button();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblAfiliado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtExplicacion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbAfiliado
            // 
            this.cmbAfiliado.FormattingEnabled = true;
            this.cmbAfiliado.Location = new System.Drawing.Point(66, 47);
            this.cmbAfiliado.Name = "cmbAfiliado";
            this.cmbAfiliado.Size = new System.Drawing.Size(121, 21);
            this.cmbAfiliado.TabIndex = 0;
            // 
            // btnAfiliado
            // 
            this.btnAfiliado.Location = new System.Drawing.Point(245, 45);
            this.btnAfiliado.Name = "btnAfiliado";
            this.btnAfiliado.Size = new System.Drawing.Size(75, 23);
            this.btnAfiliado.TabIndex = 1;
            this.btnAfiliado.Text = "Seleccionar";
            this.btnAfiliado.UseVisualStyleBackColor = true;
            this.btnAfiliado.Click += new System.EventHandler(this.btnAfiliado_Click);
            // 
            // cmbTurno
            // 
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Location = new System.Drawing.Point(66, 106);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(295, 21);
            this.cmbTurno.TabIndex = 3;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(66, 235);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 21);
            this.btnConfirmar.TabIndex = 4;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblAfiliado
            // 
            this.lblAfiliado.AutoSize = true;
            this.lblAfiliado.Location = new System.Drawing.Point(66, 28);
            this.lblAfiliado.Name = "lblAfiliado";
            this.lblAfiliado.Size = new System.Drawing.Size(163, 13);
            this.lblAfiliado.TabIndex = 6;
            this.lblAfiliado.Text = "Seleccione el numero de afiliado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Seleccione el turno a cancelar;";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(338, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Por favor, diganos la razon de la cancelacion y una breve explicacion:";
            // 
            // txtExplicacion
            // 
            this.txtExplicacion.Location = new System.Drawing.Point(66, 175);
            this.txtExplicacion.Name = "txtExplicacion";
            this.txtExplicacion.Size = new System.Drawing.Size(295, 20);
            this.txtExplicacion.TabIndex = 9;
            // 
            // CancelarAtencion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 331);
            this.Controls.Add(this.txtExplicacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAfiliado);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.cmbTurno);
            this.Controls.Add(this.btnAfiliado);
            this.Controls.Add(this.cmbAfiliado);
            this.Name = "CancelarAtencion";
            this.Text = "Cancelar Atencion";
            this.Load += new System.EventHandler(this.CancelarAtencion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAfiliado;
        private System.Windows.Forms.Button btnAfiliado;
        private System.Windows.Forms.ComboBox cmbTurno;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblAfiliado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtExplicacion;
    }
}