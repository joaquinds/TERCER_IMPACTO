namespace ClinicaFrba.Compra_Bono
{
    partial class Compra
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
            this.comboAfiliado = new System.Windows.Forms.ComboBox();
            this.afiLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textCantidad = new System.Windows.Forms.TextBox();
            this.btnCompra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboAfiliado
            // 
            this.comboAfiliado.FormattingEnabled = true;
            this.comboAfiliado.Location = new System.Drawing.Point(131, 25);
            this.comboAfiliado.Name = "comboAfiliado";
            this.comboAfiliado.Size = new System.Drawing.Size(121, 21);
            this.comboAfiliado.TabIndex = 0;
            // 
            // afiLabel
            // 
            this.afiLabel.AutoSize = true;
            this.afiLabel.Location = new System.Drawing.Point(25, 33);
            this.afiLabel.Name = "afiLabel";
            this.afiLabel.Size = new System.Drawing.Size(64, 13);
            this.afiLabel.TabIndex = 1;
            this.afiLabel.Text = "Nro.Afiliado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad de Bonos:";
            // 
            // textCantidad
            // 
            this.textCantidad.Location = new System.Drawing.Point(131, 66);
            this.textCantidad.Name = "textCantidad";
            this.textCantidad.Size = new System.Drawing.Size(121, 20);
            this.textCantidad.TabIndex = 3;
            // 
            // btnCompra
            // 
            this.btnCompra.Location = new System.Drawing.Point(28, 140);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(75, 23);
            this.btnCompra.TabIndex = 4;
            this.btnCompra.Text = "Comprar";
            this.btnCompra.UseVisualStyleBackColor = true;
            this.btnCompra.Click += new System.EventHandler(this.btnCompra_Click);
            // 
            // Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.btnCompra);
            this.Controls.Add(this.textCantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.afiLabel);
            this.Controls.Add(this.comboAfiliado);
            this.Name = "Compra";
            this.Text = "Compra";
            this.Load += new System.EventHandler(this.Compra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboAfiliado;
        private System.Windows.Forms.Label afiLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textCantidad;
        private System.Windows.Forms.Button btnCompra;
    }
}