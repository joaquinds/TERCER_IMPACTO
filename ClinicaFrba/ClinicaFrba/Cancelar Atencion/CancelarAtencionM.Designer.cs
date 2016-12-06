namespace ClinicaFrba.Cancelar_Atencion
{
    partial class CancelarAtencionM
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
            this.btnDia = new System.Windows.Forms.Button();
            this.btnPeriodo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDia
            // 
            this.btnDia.Location = new System.Drawing.Point(114, 62);
            this.btnDia.Name = "btnDia";
            this.btnDia.Size = new System.Drawing.Size(140, 40);
            this.btnDia.TabIndex = 0;
            this.btnDia.Text = "Cancelacion por dia";
            this.btnDia.UseVisualStyleBackColor = true;
            this.btnDia.Click += new System.EventHandler(this.btnDia_Click);
            // 
            // btnPeriodo
            // 
            this.btnPeriodo.Location = new System.Drawing.Point(114, 119);
            this.btnPeriodo.Name = "btnPeriodo";
            this.btnPeriodo.Size = new System.Drawing.Size(140, 38);
            this.btnPeriodo.TabIndex = 1;
            this.btnPeriodo.Text = "Cancelacion por periodo";
            this.btnPeriodo.UseVisualStyleBackColor = true;
            this.btnPeriodo.Click += new System.EventHandler(this.btnPeriodo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione el tipo de cancenlacion turno de turno que desea:";
            // 
            // CancelarAtencionM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 220);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPeriodo);
            this.Controls.Add(this.btnDia);
            this.Name = "CancelarAtencionM";
            this.Text = "CancelarAtencionM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDia;
        private System.Windows.Forms.Button btnPeriodo;
        private System.Windows.Forms.Label label1;
    }
}