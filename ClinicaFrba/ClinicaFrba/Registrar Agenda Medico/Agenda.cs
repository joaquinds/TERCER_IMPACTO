using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Registrar_Agenda_Medico
{
    public partial class Agenda : Form
    {
        private decimal id_profesional;
        private Dictionary<string,FranjaHoraria> dia_hora;

        public Agenda()
        {
            InitializeComponent();
            id_profesional = -1;
            dia_hora = new Dictionary<string, FranjaHoraria>();

        }

        private void Agenda_Load(object sender, EventArgs e)
        {
            DateTime time= new DateTime();
            for (DateTime tm = time.AddHours(7); tm <= time.AddHours(20); tm = tm.AddMinutes(30))
            {
                LunesDesde.Items.Add(tm.ToShortTimeString());
                LunesHasta.Items.Add(tm.ToShortTimeString());
                MartesDesde.Items.Add(tm.ToShortTimeString());
                MartesHasta.Items.Add(tm.ToShortTimeString());
                MiercolesDesde.Items.Add(tm.ToShortTimeString());
                MiercolesHasta.Items.Add(tm.ToShortTimeString());
                JuevesDesde.Items.Add(tm.ToShortTimeString());
                JuevesHasta.Items.Add(tm.ToShortTimeString());
                ViernesDesde.Items.Add(tm.ToShortTimeString());
                ViernesHasta.Items.Add(tm.ToShortTimeString());

            }

            for (DateTime tm = time.AddHours(10); tm <= time.AddHours(15); tm = tm.AddMinutes(30))
            {
                SabadoDesde.Items.Add(tm.ToShortTimeString());
                SabadoHasta.Items.Add(tm.ToShortTimeString());


            }

            LunesDesde.DropDownStyle = ComboBoxStyle.DropDownList;
            LunesHasta.DropDownStyle = ComboBoxStyle.DropDownList;
            MartesDesde.DropDownStyle = ComboBoxStyle.DropDownList;
            MartesHasta.DropDownStyle = ComboBoxStyle.DropDownList;
            MiercolesDesde.DropDownStyle = ComboBoxStyle.DropDownList;
            MiercolesHasta.DropDownStyle = ComboBoxStyle.DropDownList;
            JuevesDesde.DropDownStyle = ComboBoxStyle.DropDownList;
            JuevesHasta.DropDownStyle = ComboBoxStyle.DropDownList;
            ViernesDesde.DropDownStyle = ComboBoxStyle.DropDownList;
            ViernesHasta.DropDownStyle = ComboBoxStyle.DropDownList;
            SabadoDesde.DropDownStyle = ComboBoxStyle.DropDownList;
            SabadoHasta.DropDownStyle = ComboBoxStyle.DropDownList;
            comboProf.DropDownStyle = ComboBoxStyle.DropDownList;
            comboEsp.DropDownStyle = ComboBoxStyle.DropDownList;

            dateTimePickerDesde.Value = Convert.ToDateTime(Globals.fecha_sistema);
            dateTimePickerHasta.Value = Convert.ToDateTime(Globals.fecha_sistema);

            
            dateTimePickerDesde.MinDate = Convert.ToDateTime(Globals.fecha_sistema).AddDays(1);
            dateTimePickerHasta.MinDate = Convert.ToDateTime(Globals.fecha_sistema).AddDays(1);

            

            if (Globals.nombre_rol == "PROFESIONAL")
            {
                comboProf.Visible = false;
                btnElegirMed.Visible = false;
                id_profesional = (decimal)new Query("SELECT TOP 1 MATRICULA FROM TERCER_IMPACTO.PROFESIONAL WHERE USUARIO_ID='" + Globals.id_usuario + "'").ObtenerUnicoCampo();
                comboEsp.DataSource = new Query("SELECT DESCRIPCION FROM TERCER_IMPACTO.ESPECIALIDAD E JOIN TERCER_IMPACTO.PROFESIONAL_ESPECIALIDAD P ON" +
                    " E.ID_ESPECIALIDAD=P.ID_ESPECIALIDAD WHERE P.ID_PROFESIONAL='" + id_profesional + "'").ObtenerDataTable();
                comboEsp.ValueMember = "DESCRIPCION";
            }
            else
            {
                comboProf.DataSource = new Query("SELECT NOMBRE+' '+APELLIDO AS 'NAME' FROM TERCER_IMPACTO.PROFESIONAL").ObtenerDataTable();
                comboProf.ValueMember = "NAME";

            }

        }

  

        private void btnElegirMed_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboProf.Text)){
                MessageBox.Show("Seleccione un Profesional", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string nombre=comboProf.Text;

            id_profesional = (decimal)new Query("SELECT TOP 1 MATRICULA FROM TERCER_IMPACTO.PROFESIONAL WHERE " +
                "NOMBRE+' '+APELLIDO='" + nombre + "'").ObtenerUnicoCampo();
            comboEsp.DataSource = new Query("SELECT DESCRIPCION FROM TERCER_IMPACTO.ESPECIALIDAD E JOIN TERCER_IMPACTO.PROFESIONAL_ESPECIALIDAD P ON" +
                    " E.ID_ESPECIALIDAD=P.ID_ESPECIALIDAD WHERE P.ID_PROFESIONAL='" + id_profesional + "'").ObtenerDataTable();
            comboEsp.ValueMember = "DESCRIPCION";

        }

        private bool chequearBoton(CheckBox boton, ComboBox desde, ComboBox hasta, string dia)
        {
            if (boton.Checked)
            {
                string d = desde.Text;
                string h = hasta.Text;

                if (string.IsNullOrEmpty(d) || string.IsNullOrEmpty(h))
                {
                    MessageBox.Show("Ingrese franja horaria.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (Convert.ToDateTime(d) >= Convert.ToDateTime(h))
                {
                    MessageBox.Show("La hora desde debe ser menor a la hora hasta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                dia_hora.Add(dia, new FranjaHoraria(Convert.ToDateTime(d), Convert.ToDateTime(h)));
                

            }
            return true;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if(!chequearBoton(LunesCHB, LunesDesde, LunesHasta, "Monday"))
                return;
            if (!chequearBoton(MartesCHB, MartesDesde, MartesHasta, "Tuesday"))
                return;
            if (!chequearBoton(MiercolesCHB, MiercolesDesde, MiercolesHasta, "Wednesday"))
                return;
            if(!chequearBoton(JuevesCHB, JuevesDesde, JuevesHasta, "Thursday"))
                return;
            if (!chequearBoton(ViernesCHB, ViernesDesde, ViernesHasta, "Friday"))
                return;
            if (!chequearBoton(SabadoCHB, SabadoDesde, SabadoHasta, "Saturday"))
                return;

            DateTime desde=Convert.ToDateTime(dateTimePickerDesde.Text);
            DateTime hasta=Convert.ToDateTime(dateTimePickerHasta.Text);

            if (desde > hasta)
            {
                MessageBox.Show("La fecha desde debe ser menor o igual a la fecha hasta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(comboEsp.Text))
            {
                MessageBox.Show("Seleccione una Especialidad", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string descripcion = comboEsp.Text;

            decimal id_especialidad = (decimal)new Query("SELECT TOP 1 ID_ESPECIALIDAD FROM TERCER_IMPACTO.ESPECIALIDAD WHERE " +
                "DESCRIPCION='" + descripcion + "'").ObtenerUnicoCampo();


            for (DateTime dia = desde; dia <= hasta; dia = dia.AddDays(1))
            {
                if (dia_hora.Keys.Contains(dia.DayOfWeek.ToString()))
                {
                    Query qr = new Query("TERCER_IMPACTO.AGREGAR_DIA");
                    qr.addParameter("@PROF_ID", id_profesional.ToString());
                    qr.addParameter("@ESP_ID", id_especialidad.ToString());
                    qr.addParameter("@FECHA", dia);
                    qr.addParameter("@COMIENZO", dia_hora[dia.DayOfWeek.ToString()].desde);
                    qr.addParameter("@FIN", dia_hora[dia.DayOfWeek.ToString()].hasta);
                    qr.Ejecutar(); 
                }
            }

            MessageBox.Show("Se agrego correctamente a la agenda.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dateTimePickerDesde_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
