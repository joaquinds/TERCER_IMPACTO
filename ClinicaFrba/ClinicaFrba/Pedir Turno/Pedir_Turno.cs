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
            //cmbElegirProf = new System.Windows.Forms.ComboBox();
            cmbElegirProf.SelectedItem = null;
            cmbElegirProf.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbElegirProf.DisplayMember = "APELLIDO";
            cmbElegirProf.ValueMember = "APELLIDO";
            cmbElegirProf.DataSource = new Query("SELECT APELLIDO FROM TERCER_IMPACTO.PROFESIONAL " +
             "JOIN TERCER_IMPACTO.PROFESIONAL_ESPECIALIDAD ON ID_PROFESIONAL=MATRICULA " +
             " WHERE ID_ESPECIALIDAD='" + id_Especialidad + "'").ObtenerDataTable();
            
        }

        private void llenarCmbFecha()
        {
            DateTime fechaSistema=Convert.ToDateTime(Globals.fecha_sistema);
            cmbElegirFecha.DisplayMember = "FECHA";
            cmbElegirFecha.ValueMember = "FECHA";
            cmbElegirFecha.DataSource = new Query("SELECT DISTINCT FECHA FROM TERCER_IMPACTO.DIA D1, TERCER_IMPACTO.PROFESIONAL_DIA P1" +
              
                " WHERE P1.ID_PROF_ESP='" + id_Prof_Especialidad + "' AND D1.ID_DIA = P1.ID_DIA "+
                "AND ((YEAR(FECHA)>'" + fechaSistema.Year.ToString() + "') OR (YEAR(FECHA)='"+
                fechaSistema.Year.ToString()+"' AND MONTH(FECHA)>'" + fechaSistema.Month.ToString() +
                "') OR (YEAR(FECHA)='"+ fechaSistema.Year.ToString()+"' AND MONTH(FECHA)='"+fechaSistema.Month.ToString()+
                "' AND DAY(FECHA)>'" + fechaSistema.Day.ToString()+"'))").ObtenerDataTable();
            
            cmbElegirFecha.SelectedItem = null;
            cmbElegirFecha.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void llenarCmbHorario(TimeSpan ini,TimeSpan fin)

        {
            DateTime tiempo= new DateTime();

            //hay que completar con los horarios disponibles cada media hora, desde horaInicio, hasta horaFin
            
            for (DateTime tm = tiempo.AddHours(ini.Hours); tm < tiempo.AddHours(fin.Hours); tm = tm.AddMinutes(30))
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

        private void llenarComboAfiliado()
        {
            comboAfiliado.DataSource = new Query("SELECT ID_AFILIADO FROM TERCER_IMPACTO.AFILIADO").ObtenerDataTable();
            comboAfiliado.ValueMember = "ID_AFILIADO";
            comboAfiliado.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Pedir_Turno_Load(object sender, EventArgs e)
        {
            llenarEspecialidades();
            btnConfirmarT.Visible = false;
            labelAdmin.Visible = false;
            comboAfiliado.Visible = false;
            if (Globals.nombre_rol == "ADMINISTRATIVO")
            {
                labelAdmin.Visible = true;
                comboAfiliado.Visible = true;
                llenarComboAfiliado();
            }

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
            if (string.IsNullOrEmpty(cmbElegirHorario.Text))
            {
                MessageBox.Show("Seleccione un horario", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
                

            if (Globals.nombre_rol == "AFILIADO")

                id_afiliado = (decimal)new Query("SELECT TOP 1 ID_AFILIADO FROM TERCER_IMPACTO.AFILIADO WHERE USUARIO_ID='" + Globals.id_usuario + "'").ObtenerUnicoCampo();

            else
            {
                if (string.IsNullOrEmpty(comboAfiliado.Text))
                    return;
                id_afiliado = decimal.Parse(comboAfiliado.Text);
            }

            bool ya_existe_turno=false;

            
            string f = cmbElegirFecha.Text;
            DateTime hora = Convert.ToDateTime(cmbElegirHorario.Text);
            DateTime fecha = Convert.ToDateTime(f);
            TimeSpan tiempo = new TimeSpan(0, hora.Hour, hora.Minute, 0);
            fecha=fecha.Add(tiempo);



            Query qr1 = new Query("SELECT TERCER_IMPACTO.EXISTE_TURNO('"+id_Prof_Especialidad+"','"+fecha.Year+"','"+fecha.Month+"','"+
                fecha.Day+"','"+fecha.Hour+"','"+fecha.Minute+"')");
            ya_existe_turno = (bool)qr1.ObtenerUnicoCampo();
         
            if (!ya_existe_turno)
            { 
               
                Query qr = new Query("TERCER_IMPACTO.SACAR_TURNO");
                qr.addParameter("@ID_MED", id_Prof_Especialidad.ToString());
                qr.addParameter("@ID_AFIL", id_afiliado.ToString());
                qr.addParameter("@FECHA", fecha);
                qr.Ejecutar();
                MessageBox.Show("El turno se ha registrado exitosamente , la fecha es: " +fecha.ToString(),
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
            id_Prof_Especialidad = (decimal)new Query("SELECT TOP 1 ID_PROF_ESP FROM TERCER_IMPACTO.PROFESIONAL_ESPECIALIDAD WHERE ID_PROFESIONAL='" + id_Medico + "'AND ID_ESPECIALIDAD='" + id_Especialidad + "'").ObtenerUnicoCampo();
            llenarCmbFecha();

        }

        private void btnElegirFecha_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbElegirFecha.Text))
            {
                MessageBox.Show("Seleccione una Fecha", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
           
            DateTime fecha = Convert.ToDateTime(cmbElegirFecha.Text);
            
            id_Dia = (decimal)new Query("SELECT TOP 1 ID_DIA FROM TERCER_IMPACTO.DIA WHERE "+
                "YEAR(FECHA)='" + fecha.Year + "' AND MONTH(FECHA)='"+ fecha.Month + "' AND "+
                "DAY(FECHA)='"+fecha.Day+"'").ObtenerUnicoCampo();
            TimeSpan horaIni;
            TimeSpan horaFin;
            horaIni = (TimeSpan)new Query("SELECT TOP 1 COMIENZO FROM TERCER_IMPACTO.PROFESIONAL_DIA WHERE ID_PROF_ESP ='" + id_Prof_Especialidad + "' AND ID_DIA = '" + id_Dia + "'").ObtenerUnicoCampo();
            horaFin = (TimeSpan)new Query("SELECT TOP 1 FIN FROM TERCER_IMPACTO.PROFESIONAL_DIA WHERE ID_PROF_ESP ='" + id_Prof_Especialidad + "' AND ID_DIA = '" + id_Dia + "'").ObtenerUnicoCampo();
            llenarCmbHorario(horaIni,horaFin);
            btnConfirmarT.Visible = true;
        }

        private void comboAfiliado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbElegirProf_SelectedIndexChanged(object sender, EventArgs e)
        {
           
         
          //Cuando reinicia los combobox no t lo vuelve a llenar bien
            cmbElegirFecha.DataSource = null;
            cmbElegirHorario.DataSource = null;
            cmbElegirHorario.Items.Clear();
            cmbElegirFecha.Items.Clear();
            btnConfirmarT.Visible = false;
           // 
        }

        private void cmbElegirEsp_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Cuando reinicia los combobox no t lo vuelve a llenar bien

          /*  cmbElegirFecha = new System.Windows.Forms.ComboBox();
            cmbElegirHorario = new System.Windows.Forms.ComboBox(); */


            
            cmbElegirProf.DataSource = null;
            cmbElegirFecha.DataSource = null;
            cmbElegirHorario.DataSource = null;
            cmbElegirHorario.Items.Clear();
            cmbElegirProf.Items.Clear();
            cmbElegirFecha.Items.Clear();
            btnConfirmarT.Visible = false;

            
        }

        private void cmbElegirFecha_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Cuando reinicia los combobox no t lo vuelve a llenar bien
            cmbElegirHorario.DataSource = null;
            cmbElegirHorario.Items.Clear();
            btnConfirmarT.Visible = false;
            
        }
     
    }
}
