namespace ClinicaFrba.Listados
{
    partial class EspecialidadConMasBonos
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
            this.limpiar = new System.Windows.Forms.Button();
            this.buscar = new System.Windows.Forms.Button();
            this.EspecMasBonosGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSemestre = new System.Windows.Forms.ComboBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.EspecMasBonosGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(13, 135);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(75, 23);
            this.limpiar.TabIndex = 23;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(528, 135);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(75, 23);
            this.buscar.TabIndex = 22;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // EspecMasBonosGridView
            // 
            this.EspecMasBonosGridView.AllowUserToAddRows = false;
            this.EspecMasBonosGridView.AllowUserToDeleteRows = false;
            this.EspecMasBonosGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EspecMasBonosGridView.Location = new System.Drawing.Point(13, 164);
            this.EspecMasBonosGridView.Name = "EspecMasBonosGridView";
            this.EspecMasBonosGridView.ReadOnly = true;
            this.EspecMasBonosGridView.Size = new System.Drawing.Size(590, 252);
            this.EspecMasBonosGridView.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbSemestre);
            this.groupBox1.Controls.Add(this.txtAño);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 92);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccion de consulta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Semestre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Año";
            // 
            // cmbSemestre
            // 
            this.cmbSemestre.FormattingEnabled = true;
            this.cmbSemestre.Location = new System.Drawing.Point(68, 60);
            this.cmbSemestre.Name = "cmbSemestre";
            this.cmbSemestre.Size = new System.Drawing.Size(121, 21);
            this.cmbSemestre.TabIndex = 16;
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(68, 33);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(100, 20);
            this.txtAño.TabIndex = 15;
            // 
            // EspecialidadConMasBonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 436);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.EspecMasBonosGridView);
            this.Controls.Add(this.groupBox1);
            this.Name = "EspecialidadConMasBonos";
            this.Text = "EspecialidadConMasBonos";
            this.Load += new System.EventHandler(this.EspecialidadConMasBonos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EspecMasBonosGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.DataGridView EspecMasBonosGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSemestre;
        private System.Windows.Forms.TextBox txtAño;
    }
}