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
    public partial class CancelacionPeriodo : Form
    {
      

        public CancelacionPeriodo()
        {
            InitializeComponent();
        }

        private void btnCM_Click(object sender, EventArgs e)
        {

        }

        private void CancelacionPeriodo_Load(object sender, EventArgs e)
        {
            cmbMedico.DataSource = new Query("SELECT MATRICULA FROM TERCER_IMPACTO.PROFESIONAL").ObtenerDataTable();
            cmbMedico.ValueMember = "MATRICULA";
            cmbMedico.DropDownStyle = ComboBoxStyle.DropDownList;

            dateTimePickerDesde.Value = Convert.ToDateTime(Globals.fecha_sistema);
            dateTimePickerHasta.Value = Convert.ToDateTime(Globals.fecha_sistema);


            dateTimePickerDesde.MinDate = Convert.ToDateTime(Globals.fecha_sistema).AddDays(1);
            dateTimePickerHasta.MinDate = Convert.ToDateTime(Globals.fecha_sistema).AddDays(1);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(cmbMedico.Text))
            {
                MessageBox.Show("Seleccione una matricula de medico ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DateTime desde = Convert.ToDateTime(dateTimePickerDesde.Text);
            DateTime hasta = Convert.ToDateTime(dateTimePickerHasta.Text);

            if (desde > hasta)
            {
                MessageBox.Show("La fecha desde debe ser menor o igual a la fecha hasta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            for (DateTime dia = desde; dia <= hasta; dia = dia.AddDays(1))
            {              
                    Query qr = new Query("TERCER_IMPACTO.CANCELAR_TURNO_PROF_PERIODO");
                    qr.addParameter("@FECHA", dia );
                    qr.addParameter("@EXPLICACION", txtCancelacion.Text.ToString());
                    qr.addParameter("@ID_MED", cmbMedico.Text.ToString());
                    qr.Ejecutar();
                
            }
                    
                    

            MessageBox.Show("Se ha dado de baja el periodo seleccionado y junto a este todos los turnos asociados a ese dia",
               "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
                 
        }
    }
}
