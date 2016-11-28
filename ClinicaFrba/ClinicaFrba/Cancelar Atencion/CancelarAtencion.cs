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
    public partial class CancelarAtencion : Form
    {
        private decimal id_Afiliado;
        private decimal id_Turno;
        private DateTime fechaTurno;

        public CancelarAtencion()
        {
            id_Afiliado = -1;
            id_Turno = -1;
            InitializeComponent();
        }
        private void llenarComboAfiliado()
        {
            cmbAfiliado.DataSource = new Query("SELECT ID_AFILIADO FROM TERCER_IMPACTO.AFILIADO").ObtenerDataTable();
            cmbAfiliado.ValueMember = "ID_AFILIADO";
            cmbAfiliado.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CancelarAtencion_Load(object sender, EventArgs e)
        {
            btnConfirmar.Visible = false;
            lblAfiliado.Visible = false;
            cmbAfiliado.Visible = false;
            btnAfiliado.Visible = false;

            if (Globals.nombre_rol == "ADMINISTRATIVO")
            {
                lblAfiliado.Visible = true;
                cmbAfiliado.Visible = true;
                btnAfiliado.Visible = true;
                llenarComboAfiliado();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void llenarCmbTurno()
        {
            cmbTurno.DataSource = new Query("SELECT FECHA FROM TERCER_IMPACTO.TURNO " +           
                " WHERE ID_AFILIADO='" +  id_Afiliado + "'").ObtenerDataTable();
            cmbTurno.ValueMember = "FECHA";
            cmbTurno.SelectedItem = null;
            cmbTurno.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnAfiliado_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbAfiliado.Text))
            {
                MessageBox.Show("Seleccione un afiliado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            id_Afiliado = Decimal.Parse(cmbAfiliado.Text);
            btnConfirmar.Visible = true;
            llenarCmbTurno();

        }

        private void btnTurno_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbTurno.Text) )
            {
                MessageBox.Show("Seleccione un Turno", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrEmpty(txtExplicacion.Text))
            {
                MessageBox.Show("Por favor denos una explicacion de por que cancela el turno", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            fechaTurno = Convert.ToDateTime(cmbTurno.Text);

            //error aca...
            id_Turno = (decimal)new Query("SELECT TOP 1 ID_TURNO FROM TERCER_IMPACTO.TURNO WHERE FECHA='" + fechaTurno + "'AND ID_AFILIADO ='" + id_Afiliado + "' ").ObtenerUnicoCampo();
            //
            Query qr = new Query("TERCER_IMPACTO.AGREGAR_CANCELACION");
            qr.addParameter("@ID_TUR", id_Turno.ToString());
            qr.addParameter("@TIPO", "AFILIADO");
            qr.addParameter("@EXPLICACION", txtExplicacion.Text);
            qr.Ejecutar();
            MessageBox.Show("Se ha cancelado el turno exitosamente",
                "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }



    }
}
