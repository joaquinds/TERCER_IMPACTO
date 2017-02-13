using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Registro_Resultado
{
    public partial class Registrar_Resultado : Form
    {
        private decimal id_Medico;
        private decimal id_consulta;
        private decimal id_turno;
    
        public Registrar_Resultado()
        {
            id_Medico = -1;
            id_consulta = -1;
            id_turno = -1;
            InitializeComponent();
        }

        private void txtSintomas_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registrar_Resultado_Load(object sender, EventArgs e)
        {
            lblAdmin.Visible = false;
            cmbMedico.Visible = false;
            lblDiagnostico.Visible= false;
            lblSintomas.Visible = false;
            btnDiagnostico.Visible = false;
            txtEnfermedad.Visible = false;
            txtSintomas.Visible = false;
            btnMedico.Visible = false;
            if (Globals.nombre_rol == "ADMINISTRATIVO")
            {
                lblAdmin.Visible = true;
                cmbMedico.Visible = true;
                btnMedico.Visible = true;
                llenarCmbMedico();
                
            }
            else
            {

                llenarCmbFechas();

            }
        }

        private void llenarCmbMedico()
        {
            cmbMedico.DataSource = new Query("SELECT NOMBRE+' '+APELLIDO as N ,MATRICULA FROM TERCER_IMPACTO.PROFESIONAL").ObtenerDataTable();
            cmbMedico.ValueMember = "MATRICULA";
            cmbMedico.DisplayMember = "N";
            cmbMedico.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void llenarCmbFechas ()
        {

            if (Globals.nombre_rol == "PROFESIONAL")
            {
                id_Medico = (decimal)new Query("SELECT TOP 1 MATRICULA FROM TERCER_IMPACTO.PROFESIONAL WHERE USUARIO_ID='" + Globals.id_usuario + "'").ObtenerUnicoCampo();

            }

            cmbHora.DataSource = new Query("SELECT FECHA FROM TERCER_IMPACTO.TURNO"
               +" JOIN TERCER_IMPACTO.PROFESIONAL_ESPECIALIDAD"
                   +" ON ID_PROF_ESP=ID_MEDICO"
                   +" WHERE ID_PROFESIONAL='" + id_Medico + "' ").ObtenerDataTable();
            cmbHora.ValueMember = "FECHA";
            cmbHora.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void btnMedico_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbMedico.Text))
            {
                MessageBox.Show("Seleccion un medico", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // Aca tenemos que obtener de alguna forma el ID_PROF_ESP
            id_Medico = decimal.Parse(cmbMedico.SelectedValue.ToString());
            llenarCmbFechas();
        }

        private void btnFecha_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbHora.Text))
            {
                MessageBox.Show("Seleccion una fecha ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //Busca Id_Medico, cuando deberia buscar Id_PROF_ESP para comparar con el ID_MEDICO del turno

            //Busca Id_Medico, cuando deberia buscar Id_PROF_ESP para comparar con el ID_MEDICO del turno
            string format = "yyyy-MM-dd HH:mm:ss";
            id_turno = (decimal)new Query("SELECT ID_TURNO FROM TERCER_IMPACTO.TURNO T, TERCER_IMPACTO.PROFESIONAL_ESPECIALIDAD P WHERE FECHA ='" + Convert.ToDateTime(cmbHora.Text).ToString(format) + "' AND T.ID_MEDICO = P.ID_PROF_ESP AND P.ID_PROFESIONAL = '" + id_Medico + "'").ObtenerUnicoCampo();
            bool ya_existe_consulta= false;
         

       
            Query qrc = new Query("SELECT TERCER_IMPACTO.EXISTE_CONSULTA('" + id_turno + "','" + Convert.ToDateTime(cmbHora.Text).ToString(format) + "')");
            ya_existe_consulta = (bool)qrc.ObtenerUnicoCampo();

            if (!ya_existe_consulta)
            {
                MessageBox.Show("No hay consulta confirmada para la fecha ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
                
            }
            else {

                id_consulta = (decimal)new Query("SELECT TOP 1 ID_CONSULTA FROM TERCER_IMPACTO.CONSULTA WHERE ID_TURNO='" + id_turno + "' AND FECHA = '" + Convert.ToDateTime(cmbHora.Text).ToString(format) + "'").ObtenerUnicoCampo();
            }

            lblDiagnostico.Visible= true;
            lblSintomas.Visible = true;
            btnDiagnostico.Visible = true;
            txtEnfermedad.Visible = true;
            txtSintomas.Visible = true;

        }

        private void cmbHora_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDiagnostico_Click(object sender, EventArgs e)
        {
            if ((txtSintomas.Text != "" && txtEnfermedad.Text != ""))
            {

                Query qr1 = new Query("TERCER_IMPACTO.AGREGAR_SINTOMA");
                qr1.addParameter("@SINTOMA", txtSintomas.Text);
                qr1.addParameter("@ID_CON", id_consulta.ToString());
                qr1.Ejecutar();

                Query qr2 = new Query("TERCER_IMPACTO.AGREGAR_ENFERMEDAD");
                qr2.addParameter("@ENFERMEDAD", txtEnfermedad.Text);
                qr2.addParameter("@ID_CON", id_consulta.ToString());
                qr2.Ejecutar();


                MessageBox.Show("La consulta se ha registrado exitosamente",
                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor complete el sintoma y el diagnostico ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }


    }
}
