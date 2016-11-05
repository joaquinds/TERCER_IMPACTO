using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Pedir_Turno
{
    public partial class Pedir_Turno : Form
    {
        private decimal id_Especialidad;
        private decimal id_Medico;
        private decimal id_Prof_Especialidad;
        private decimal id_Dia;
        private DateTime horaInicio;
        private DateTime horaFin;
        private decimal id_afiliado;

        public Pedir_Turno()
        {
            id_Especialidad = -1;
            id_Medico= -1;
            id_Prof_Especialidad = -1;
            id_Dia = -1;
            InitializeComponent();

        }


        private void llenarEspecialidades()
        {
            cmbElegirEsp.DataSource = new Query("SELECT DESCRIPCION FROM TERCER_IMPACTO.ESPECIALIDAD").ObtenerDataTable();
            cmbElegirEsp.ValueMember = "DESCRIPCION";
            cmbElegirEsp.DropDownStyle = ComboBoxStyle.DropDownList;



        }
        private void llenarCmbProf()
        {
            cmbElegirProf.DataSource = new Query("SELECT NOMBRE, APELLIDO FROM TERCER_IMPACTO.PROFESIONAL " +
                "JOIN TERCER_IMPACTO.PROFESIONAL_ESPECIALIDAD ON ID_PROFESIONAL=MATRICULA " +
                " WHERE ID_ESPECIALIDAD='" + id_Especialidad + "'").ObtenerDataTable();
            cmbElegirProf.ValueMember = "APELLIDO";
            cmbElegirProf.SelectedItem = null;
            cmbElegirProf.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void llenarCmbFecha()
        {

            cmbElegirFecha.DataSource = new Query("SELECT DISTINCT FECHA FROM TERCER_IMPACTO.DIA D1, TERCER_IMPACTO.PROFESIONAL_DIA P1" +
              
                " WHERE P1.ID_PROF_ESP='" + id_Prof_Especialidad + "' AND D1.ID_DIA = P1.ID_DIA").ObtenerDataTable();
            cmbElegirFecha.ValueMember = "FECHA";
            cmbElegirFecha.SelectedItem = null;
            cmbElegirFecha.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void llenarCmbHorario()

        {
            DateTime tiempo= new DateTime();

            //hay que completar con los horarios disponibles cada media hora, desde horaInicio, hasta horaFin
            
            for (DateTime tm = tiempo.AddHours(7); tm <= tiempo.AddHours(20); tm = tm.AddMinutes(30))
            {
                cmbElegirHorario.Items.Add(tm.ToShortTimeString());        
            }

  
            cmbElegirHorario.SelectedItem = null;
            cmbElegirHorario.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Pedir_Turno_Load(object sender, EventArgs e)
        {
            llenarEspecialidades();
            btnConfirmarT.Visible = false;
        }

        private void btnEEsp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbElegirEsp.Text))
            {
                MessageBox.Show("Seleccione una especialidad", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            id_Especialidad = (decimal)new Query("SELECT TOP 1 ID_ESPECIALIDAD FROM TERCER_IMPACTO.ESPECIALIDAD WHERE DESCRIPCION='" + cmbElegirEsp.Text + "'").ObtenerUnicoCampo();
            llenarCmbProf();


        }

        private void btnConfirmarT_Click(object sender, EventArgs e)
        {
           // arreglar la forma en la que compara la fecha (error de comparacion string con Datetime)
            decimal estaLibre = 0;
            id_afiliado = (decimal)new Query("SELECT TOP 1 ID_AFILIADO FROM TERCER_IMPACTO.AFILIADO WHERE ID_USUARIO='" + Globals.id_usuario + "'").ObtenerUnicoCampo();
            estaLibre = (decimal)new Query("SELECT ID_TURNO FROM TERCER_IMPACTO.TURNO WHERE ID_MEDICO'" +
               id_Medico + "' AND ID_AFILIADO ='" + id_afiliado  + "' AND FECHA = '" + cmbElegirFecha.Text + "'  ").ObtenerUnicoCampo();
            
            //FECHA debe recibir fechaCompleta con la FECHA de cmb y el horario JUNTOS (hay q juntar la info de los cmbElegirFecha y cmbElegirHorario)
            //arreglar fechaCompleta
           
            if (estaLibre == 0)
            {
                new Query("INSERT INTO TERCER_IMPACTO.TURNO (ID_MEDICO,ID_AFILIADO,FECHA) VALUES ('" + id_Medico + "','" + id_afiliado + "','" + cmbElegirFecha.Text + "')").Ejecutar();
                MessageBox.Show("El turno se ha registrado exitosamente",
                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                MessageBox.Show("El turno no esta disponible, por favor seleccione otro horario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }

        private void btnConfirmarP_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbElegirProf.Text))
            {
                MessageBox.Show("Seleccione un Profesional", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            id_Medico = (decimal)new Query("SELECT TOP 1 MATRICULA FROM TERCER_IMPACTO.PROFESIONAL WHERE APELLIDO='" + cmbElegirProf.Text + "'").ObtenerUnicoCampo();
            id_Prof_Especialidad = (decimal)new Query("SELECT TOP 1 ID_PROF_ESP FROM TERCER_IMPACTO.PROFESIONAL_ESPECIALIDAD WHERE ID_PROFESIONAL='" + id_Medico + "'").ObtenerUnicoCampo();
            llenarCmbFecha();

        }

        private void btnElegirFecha_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbElegirFecha.Text))
            {
                MessageBox.Show("Seleccione una Fecha", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //arreglar la forma en la que compara la fecha (error de comparacion string con Datetime)
            DateTime FechaTxt = DateTime.ParseExact(cmbElegirFecha.Text, "yyyy-MM-dd", null);
            id_Dia = (decimal)new Query("SELECT TOP 1 ID_DIA FROM TERCER_IMPACTO.DIA WHERE FECHA='" + FechaTxt + "'").ObtenerUnicoCampo();
            horaInicio = (DateTime)new Query("SELECT TOP 1 COMIENZO FROM TERCER_IMPACTO.PROFESIONAL_DIA WHERE ID_PROF_ESP ='" + id_Prof_Especialidad + "' AND ID_DIA = '" + id_Dia + "'").ObtenerUnicoCampo();
            horaFin = (DateTime)new Query("SELECT TOP 1 FIN FROM TERCER_IMPACTO.PROFESIONAL_DIA WHERE ID_PROF_ESP ='" + id_Prof_Especialidad + "' AND ID_DIA = '" + id_Dia + "'").ObtenerUnicoCampo();
            llenarCmbHorario();
            btnConfirmarT.Visible = false;
        }
     
    }
}
