namespace ClinicaFrba.ABM_Afiliado2
{
    partial class Modificacion
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbId = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dirTxt = new System.Windows.Forms.TextBox();
            this.telTxt = new System.Windows.Forms.TextBox();
            this.canTxt = new System.Windows.Forms.TextBox();
            this.cmbPlan = new System.Windows.Forms.ComboBox();
            this.btn_sel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.motivoTxt = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mailTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dirección:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Teléfono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estado Civil:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad de hijos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Plan Médico:";
            // 
            // cmbId
            // 
            this.cmbId.FormattingEnabled = true;
            this.cmbId.Location = new System.Drawing.Point(110, 18);
            this.cmbId.Name = "cmbId";
            this.cmbId.Size = new System.Drawing.Size(245, 21);
            this.cmbId.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Id Afiliado:";
            // 
            // dirTxt
            // 
            this.dirTxt.Location = new System.Drawing.Point(110, 52);
            this.dirTxt.Name = "dirTxt";
            this.dirTxt.Size = new System.Drawing.Size(245, 20);
            this.dirTxt.TabIndex = 7;
            // 
            // telTxt
            // 
            this.telTxt.Location = new System.Drawing.Point(110, 80);
            this.telTxt.Name = "telTxt";
            this.telTxt.Size = new System.Drawing.Size(245, 20);
            this.telTxt.TabIndex = 8;
            // 
            // canTxt
            // 
            this.canTxt.Location = new System.Drawing.Point(110, 141);
            this.canTxt.Name = "canTxt";
            this.canTxt.Size = new System.Drawing.Size(245, 20);
            this.canTxt.TabIndex = 10;
            // 
            // cmbPlan
            // 
            this.cmbPlan.FormattingEnabled = true;
            this.cmbPlan.Location = new System.Drawing.Point(110, 193);
            this.cmbPlan.Name = "cmbPlan";
            this.cmbPlan.Size = new System.Drawing.Size(245, 21);
            this.cmbPlan.TabIndex = 11;
            // 
            // btn_sel
            // 
            this.btn_sel.Location = new System.Drawing.Point(391, 18);
            this.btn_sel.Name = "btn_sel";
            this.btn_sel.Size = new System.Drawing.Size(75, 23);
            this.btn_sel.TabIndex = 12;
            this.btn_sel.Text = "Seleccionar";
            this.btn_sel.UseVisualStyleBackColor = true;
            this.btn_sel.Click += new System.EventHandler(this.btn_sel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Motivo Cambio de Plan: ";
            // 
            // motivoTxt
            // 
            this.motivoTxt.Location = new System.Drawing.Point(140, 227);
            this.motivoTxt.Multiline = true;
            this.motivoTxt.Name = "motivoTxt";
            this.motivoTxt.Size = new System.Drawing.Size(215, 67);
            this.motivoTxt.TabIndex = 14;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(15, 303);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 15;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(110, 108);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(245, 21);
            this.cmbEstado.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Mail:";
            // 
            // mailTxt
            // 
            this.mailTxt.Location = new System.Drawing.Point(110, 169);
            this.mailTxt.Name = "mailTxt";
            this.mailTxt.Size = new System.Drawing.Size(245, 20);
            this.mailTxt.TabIndex = 18;
            // 
            // Modificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 338);
            this.Controls.Add(this.mailTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.motivoTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_sel);
            this.Controls.Add(this.cmbPlan);
            this.Controls.Add(this.canTxt);
            this.Controls.Add(this.telTxt);
            this.Controls.Add(this.dirTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Modificacion";
            this.Text = "Modificacion";
            this.Load += new System.EventHandler(this.Modificacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox dirTxt;
        private System.Windows.Forms.TextBox telTxt;
        private System.Windows.Forms.TextBox canTxt;
        private System.Windows.Forms.ComboBox cmbPlan;
        private System.Windows.Forms.Button btn_sel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox motivoTxt;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox mailTxt;
    }
}