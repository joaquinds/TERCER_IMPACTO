namespace ClinicaFrba.Listados
{
    partial class ListadoProfPlan
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
            this.ProfMasConsultadosGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.cmbPlan = new System.Windows.Forms.ComboBox();
            this.cmbSemestre = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProfMasConsultadosGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(15, 119);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(75, 23);
            this.limpiar.TabIndex = 19;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(507, 119);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(75, 23);
            this.buscar.TabIndex = 18;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // ProfMasConsultadosGridView
            // 
            this.ProfMasConsultadosGridView.AllowUserToAddRows = false;
            this.ProfMasConsultadosGridView.AllowUserToDeleteRows = false;
            this.ProfMasConsultadosGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProfMasConsultadosGridView.Location = new System.Drawing.Point(15, 148);
            this.ProfMasConsultadosGridView.Name = "ProfMasConsultadosGridView";
            this.ProfMasConsultadosGridView.ReadOnly = true;
            this.ProfMasConsultadosGridView.Size = new System.Drawing.Size(590, 252);
            this.ProfMasConsultadosGridView.TabIndex = 17;
            this.ProfMasConsultadosGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProfMasConsultadosGridView_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Año";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Semestre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Plan";
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(119, 34);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(100, 20);
            this.txtAño.TabIndex = 12;
            // 
            // cmbPlan
            // 
            this.cmbPlan.FormattingEnabled = true;
            this.cmbPlan.Location = new System.Drawing.Point(294, 31);
            this.cmbPlan.Name = "cmbPlan";
            this.cmbPlan.Size = new System.Drawing.Size(121, 21);
            this.cmbPlan.TabIndex = 13;
            // 
            // cmbSemestre
            // 
            this.cmbSemestre.FormattingEnabled = true;
            this.cmbSemestre.Location = new System.Drawing.Point(119, 64);
            this.cmbSemestre.Name = "cmbSemestre";
            this.cmbSemestre.Size = new System.Drawing.Size(121, 21);
            this.cmbSemestre.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbSemestre);
            this.groupBox1.Controls.Add(this.cmbPlan);
            this.groupBox1.Controls.Add(this.txtAño);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 94);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccion de consulta";
            // 
            // ListadoProfPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 445);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.ProfMasConsultadosGridView);
            this.Controls.Add(this.groupBox1);
            this.Name = "ListadoProfPlan";
            this.Text = "ListadoProfPlan";
            this.Load += new System.EventHandler(this.ListadoProfPlan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProfMasConsultadosGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.DataGridView ProfMasConsultadosGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.ComboBox cmbPlan;
        private System.Windows.Forms.ComboBox cmbSemestre;
        private System.Windows.Forms.GroupBox groupBox1;

    }
}