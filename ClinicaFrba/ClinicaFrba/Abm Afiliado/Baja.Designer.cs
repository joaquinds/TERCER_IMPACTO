namespace ClinicaFrba.Abm_Afiliado
{
    partial class Baja
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
            this.cmbafiliados = new System.Windows.Forms.ComboBox();
            this.btnbaja = new System.Windows.Forms.Button();
            this.btnvolver = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Afiliado:";
            // 
            // cmbafiliados
            // 
            this.cmbafiliados.FormattingEnabled = true;
            this.cmbafiliados.Location = new System.Drawing.Point(80, 14);
            this.cmbafiliados.Name = "cmbafiliados";
            this.cmbafiliados.Size = new System.Drawing.Size(405, 21);
            this.cmbafiliados.TabIndex = 1;
            // 
            // btnbaja
            // 
            this.btnbaja.Location = new System.Drawing.Point(367, 68);
            this.btnbaja.Name = "btnbaja";
            this.btnbaja.Size = new System.Drawing.Size(133, 23);
            this.btnbaja.TabIndex = 4;
            this.btnbaja.Text = "Baja";
            this.btnbaja.UseVisualStyleBackColor = true;
            // 
            // btnvolver
            // 
            this.btnvolver.Location = new System.Drawing.Point(19, 68);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(133, 23);
            this.btnvolver.TabIndex = 5;
            this.btnvolver.Text = "Volver";
            this.btnvolver.UseVisualStyleBackColor = true;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(200, 68);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(133, 23);
            this.btnlimpiar.TabIndex = 7;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            // 
            // Baja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(534, 102);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.btnbaja);
            this.Controls.Add(this.cmbafiliados);
            this.Controls.Add(this.label1);
            this.Name = "Baja";
            this.Text = "ABM Baja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbafiliados;
        private System.Windows.Forms.Button btnbaja;
        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.Button btnlimpiar;
    }
}