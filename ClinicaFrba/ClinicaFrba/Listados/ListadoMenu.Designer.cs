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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(41, 188);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(238, 42);
            this.button3.TabIndex = 5;
            this.button3.Text = "Afiliado con mas bonos comprados";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(41, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(238, 41);
            this.button2.TabIndex = 4;
            this.button2.Text = "Especialidades con mas bonos utilizados";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Profesionales mas consultados por plan";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ListadoMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 306);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "ListadoMenu";
            this.Text = "ListadoMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}