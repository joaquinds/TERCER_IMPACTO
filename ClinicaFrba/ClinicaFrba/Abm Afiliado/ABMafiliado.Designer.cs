namespace ClinicaFrba.Abm_Afiliado
{
    partial class ABMafiliado
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
            this.btnalta = new System.Windows.Forms.Button();
            this.btnmodif = new System.Windows.Forms.Button();
            this.btnbaja = new System.Windows.Forms.Button();
            this.btnvolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnalta
            // 
            this.btnalta.Location = new System.Drawing.Point(109, 34);
            this.btnalta.Name = "btnalta";
            this.btnalta.Size = new System.Drawing.Size(75, 23);
            this.btnalta.TabIndex = 0;
            this.btnalta.Text = "Alta";
            this.btnalta.UseVisualStyleBackColor = true;
            // 
            // btnmodif
            // 
            this.btnmodif.Location = new System.Drawing.Point(109, 92);
            this.btnmodif.Name = "btnmodif";
            this.btnmodif.Size = new System.Drawing.Size(75, 23);
            this.btnmodif.TabIndex = 1;
            this.btnmodif.Text = "Modificación";
            this.btnmodif.UseVisualStyleBackColor = true;
            // 
            // btnbaja
            // 
            this.btnbaja.Location = new System.Drawing.Point(109, 150);
            this.btnbaja.Name = "btnbaja";
            this.btnbaja.Size = new System.Drawing.Size(75, 23);
            this.btnbaja.TabIndex = 2;
            this.btnbaja.Text = "Baja";
            this.btnbaja.UseVisualStyleBackColor = true;
            // 
            // btnvolver
            // 
            this.btnvolver.Location = new System.Drawing.Point(109, 209);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(75, 23);
            this.btnvolver.TabIndex = 3;
            this.btnvolver.Text = "Volver";
            this.btnvolver.UseVisualStyleBackColor = true;
            // 
            // ABMafiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.btnbaja);
            this.Controls.Add(this.btnmodif);
            this.Controls.Add(this.btnalta);
            this.Name = "ABMafiliado";
            this.Text = "ABM Afiliado";
            this.Load += new System.EventHandler(this.ABMafiliado_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnalta;
        private System.Windows.Forms.Button btnmodif;
        private System.Windows.Forms.Button btnbaja;
        private System.Windows.Forms.Button btnvolver;
    }
}