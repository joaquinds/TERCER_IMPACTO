using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Cancelar_Atencion
{
    public partial class CancelacionDia : Form
    {
        public CancelacionDia()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CancelacionDia_Load(object sender, EventArgs e)
        {
            cmbMedico.DataSource = new Query("SELECT MATRICULA FROM TERCER_IMPACTO.PROFESIONAL").ObtenerDataTable();
            cmbMedico.ValueMember = "MATRICULA";
            cmbMedico.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void llenarCmbAgenda()
        {
            DateTime fecha=Convert.ToDateTime(Globals.fecha_sistema);
            string format = "yyyy-MM-dd hh:mm:ss";
            cmbAgenda.SelectedItem = null;
            cmbAgenda.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAgenda.DisplayMember = "FECHA";
            cmbAgenda.ValueMember = "FECHA";
            cmbAgenda.DataSource = new Query("SELECT D.FECHA FROM TERCER_IMPACTO.PROFESIONAL_DIA P JOIN TERCER_IMPACTO.DIA D ON" +
             " P.ID_DIA = D.ID_DIA JOIN TERCER_IMPACTO.PROFESIONAL_ESPECIALIDAD PE ON PE.ID_PROF_ESP=P.ID_PROF_ESP "+
             "WHERE PE.ID_PROFESIONAL='"+cmbMedico.Text+"' AND P.HABILITADO=1 AND D.FECHA>CONVERT(DATE,'"+fecha.ToString(format)+"')").ObtenerDataTable();

        }


        private void btnCM_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbMedico.Text))
            {
                MessageBox.Show("Seleccione una matricula de medico ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            llenarCmbAgenda();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbAgenda.Text))
            {
                MessageBox.Show("Seleccione un dia de la agenda ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            if (string.IsNullOrEmpty(txtCancelacion.Text))
            {
                MessageBox.Show("Por favor explique por que da de baja el turno ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // No agrega los turnos a cancelar turno, lanza el mensaje pero no agrega, posible error en el script?
            Query qr = new Query("TERCER_IMPACTO.CANCELAR_TURNO_PROF");
            qr.addParameter("@FECHA", Convert.ToDateTime(cmbAgenda.Text));
            qr.addParameter("@EXPLICACION", txtCancelacion.Text.ToString());
            qr.addParameter("@ID_MEDICO", cmbMedico.Text.ToString());
            qr.Ejecutar();
            MessageBox.Show("Se ha dado de baja el dia y junto a este todos los turnos asociados a ese dia",
               "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            llenarCmbAgenda();



        }


    }
}
