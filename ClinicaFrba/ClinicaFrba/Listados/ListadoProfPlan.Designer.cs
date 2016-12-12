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
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.ProfMasConsultadosGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtanio = new System.Windows.Forms.TextBox();
            this.cmbplan = new System.Windows.Forms.ComboBox();
            this.cmbsemestre = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProfMasConsultadosGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(12, 119);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpiar.TabIndex = 19;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(530, 119);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 18;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.buscar_Click);
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
           // this.ProfMasConsultadosGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProfMasConsultadosGridView_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Año:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Semestre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Plan:";
            // 
            // txtanio
            // 
            this.txtanio.Location = new System.Drawing.Point(84, 27);
            this.txtanio.Name = "txtanio";
            this.txtanio.Size = new System.Drawing.Size(100, 20);
            this.txtanio.TabIndex = 12;
            // 
            // cmbplan
            // 
            this.cmbplan.FormattingEnabled = true;
            this.cmbplan.Location = new System.Drawing.Point(425, 27);
            this.cmbplan.Name = "cmbplan";
            this.cmbplan.Size = new System.Drawing.Size(121, 21);
            this.cmbplan.TabIndex = 13;
            // 
            // cmbsemestre
            // 
            this.cmbsemestre.FormattingEnabled = true;
            this.cmbsemestre.Location = new System.Drawing.Point(84, 56);
            this.cmbsemestre.Name = "cmbsemestre";
            this.cmbsemestre.Size = new System.Drawing.Size(121, 21);
            this.cmbsemestre.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbsemestre);
            this.groupBox1.Controls.Add(this.cmbplan);
            this.groupBox1.Controls.Add(this.txtanio);
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
            this.ClientSize = new System.Drawing.Size(633, 410);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnbuscar);
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

        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.DataGridView ProfMasConsultadosGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtanio;
        private System.Windows.Forms.ComboBox cmbplan;
        private System.Windows.Forms.ComboBox cmbsemestre;
        private System.Windows.Forms.GroupBox groupBox1;

    }
}