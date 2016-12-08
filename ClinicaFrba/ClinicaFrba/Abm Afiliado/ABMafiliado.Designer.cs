namespace ClinicaFrba.ABM_Afiliado2
{
    partial class ABMAfiliado
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
            this.btn_alta = new System.Windows.Forms.Button();
            this.btn_baja = new System.Windows.Forms.Button();
            this.btn_mod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_alta
            // 
            this.btn_alta.Location = new System.Drawing.Point(96, 43);
            this.btn_alta.Name = "btn_alta";
            this.btn_alta.Size = new System.Drawing.Size(75, 23);
            this.btn_alta.TabIndex = 0;
            this.btn_alta.Text = "Alta";
            this.btn_alta.UseVisualStyleBackColor = true;
            this.btn_alta.Click += new System.EventHandler(this.btn_alta_Click);
            // 
            // btn_baja
            // 
            this.btn_baja.Location = new System.Drawing.Point(96, 107);
            this.btn_baja.Name = "btn_baja";
            this.btn_baja.Size = new System.Drawing.Size(75, 23);
            this.btn_baja.TabIndex = 1;
            this.btn_baja.Text = "Baja";
            this.btn_baja.UseVisualStyleBackColor = true;
            this.btn_baja.Click += new System.EventHandler(this.btn_baja_Click);
            // 
            // btn_mod
            // 
            this.btn_mod.Location = new System.Drawing.Point(96, 179);
            this.btn_mod.Name = "btn_mod";
            this.btn_mod.Size = new System.Drawing.Size(75, 23);
            this.btn_mod.TabIndex = 2;
            this.btn_mod.Text = "Modificación";
            this.btn_mod.UseVisualStyleBackColor = true;
            this.btn_mod.Click += new System.EventHandler(this.btn_mod_Click);
            // 
            // ABMAfiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.btn_mod);
            this.Controls.Add(this.btn_baja);
            this.Controls.Add(this.btn_alta);
            this.Name = "ABMAfiliado";
            this.Text = "ABMAfiliado";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_alta;
        private System.Windows.Forms.Button btn_baja;
        private System.Windows.Forms.Button btn_mod;
    }
}