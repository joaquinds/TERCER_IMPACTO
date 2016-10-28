namespace ClinicaFrba.MenuPrincipal
{
    partial class ElegirRol
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
            this.comboRol = new System.Windows.Forms.ComboBox();
            this.btnElegir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboRol
            // 
            this.comboRol.FormattingEnabled = true;
            this.comboRol.Location = new System.Drawing.Point(32, 28);
            this.comboRol.Name = "comboRol";
            this.comboRol.Size = new System.Drawing.Size(225, 21);
            this.comboRol.TabIndex = 0;
            // 
            // btnElegir
            // 
            this.btnElegir.Location = new System.Drawing.Point(32, 91);
            this.btnElegir.Name = "btnElegir";
            this.btnElegir.Size = new System.Drawing.Size(75, 23);
            this.btnElegir.TabIndex = 1;
            this.btnElegir.Text = "Elegir";
            this.btnElegir.UseVisualStyleBackColor = true;
            this.btnElegir.Click += new System.EventHandler(this.btnElegir_Click);
            // 
            // ElegirRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.btnElegir);
            this.Controls.Add(this.comboRol);
            this.Name = "ElegirRol";
            this.Text = "ElegirRol";
            this.Load += new System.EventHandler(this.ElegirRol_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboRol;
        private System.Windows.Forms.Button btnElegir;
    }
}