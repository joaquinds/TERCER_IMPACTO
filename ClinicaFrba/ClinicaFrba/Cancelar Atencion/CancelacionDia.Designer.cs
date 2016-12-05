namespace ClinicaFrba.Cancelar_Atencion
{
    partial class CancelacionDia
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
            this.cmbMedico = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAgenda = new System.Windows.Forms.ComboBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCM = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCancelacion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione matricula medico:";
            // 
            // cmbMedico
            // 
            this.cmbMedico.FormattingEnabled = true;
            this.cmbMedico.Location = new System.Drawing.Point(207, 40);
            this.cmbMedico.Name = "cmbMedico";
            this.cmbMedico.Size = new System.Drawing.Size(121, 21);
            this.cmbMedico.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleccione dia de su agenda que quiere cancelar sus turnos";
            // 
            // cmbAgenda
            // 
            this.cmbAgenda.FormattingEnabled = true;
            this.cmbAgenda.Location = new System.Drawing.Point(32, 111);
            this.cmbAgenda.Name = "cmbAgenda";
            this.cmbAgenda.Size = new System.Drawing.Size(121, 21);
            this.cmbAgenda.TabIndex = 3;
            this.cmbAgenda.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(35, 236);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(180, 35);
            this.btnConfirmar.TabIndex = 4;
            this.btnConfirmar.Text = "Confirmar cancelacion";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCM
            // 
            this.btnCM.Location = new System.Drawing.Point(356, 40);
            this.btnCM.Name = "btnCM";
            this.btnCM.Size = new System.Drawing.Size(75, 23);
            this.btnCM.TabIndex = 5;
            this.btnCM.Text = "Confirmar";
            this.btnCM.UseVisualStyleBackColor = true;
            this.btnCM.Click += new System.EventHandler(this.btnCM_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Explique por que da de baja el turno:";
            // 
            // txtCancelacion
            // 
            this.txtCancelacion.Location = new System.Drawing.Point(32, 181);
            this.txtCancelacion.Name = "txtCancelacion";
            this.txtCancelacion.Size = new System.Drawing.Size(317, 20);
            this.txtCancelacion.TabIndex = 7;
            // 
            // CancelacionDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 301);
            this.Controls.Add(this.txtCancelacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCM);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.cmbAgenda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbMedico);
            this.Controls.Add(this.label1);
            this.Name = "CancelacionDia";
            this.Text = "CancelacionDia";
            this.Load += new System.EventHandler(this.CancelacionDia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMedico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAgenda;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCancelacion;
    }
}