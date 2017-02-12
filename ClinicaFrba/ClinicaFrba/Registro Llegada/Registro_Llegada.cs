using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Registro_Llegada
{
    public partial class Registro_Llegada : Form
    {
        private decimal id_Especialidad;
        private decimal id_Medico;
        private decimal id_Turno;
        private decimal id_Afiliado;
        private decimal prof_esp;
        private DateTime fechaTurno;
        private int cant_bonos;
        private decimal id_Consulta;

        public Registro_Llegada()
        {
            cant_bonos = 0;
            id_Especialidad = -1;
            id_Medico = -1;
            id_Turno = -1;
            id_Consulta = -1;
            id_Afiliado = -1;
            prof_esp = -1;
            InitializeComponent();
        }

        private void Registro_Llegada_Load(object sender, EventArgs e)
        {
            llenarEspecialidades();
            btnEfectivizar.Visible = false;
        }

        private void llenarEspecialidades()
        {
            cmbEspecialidad.DataSource = new Query("SELECT DESCRIPCION FROM TERCER_IMPACTO.ESPECIALIDAD").ObtenerDataTable();
            cmbEspecialidad.ValueMember = "DESCRIPCION";
            cmbEspecialidad.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void llenarProfesionales()
        {
            cmbProfesional.SelectedItem = null;
            cmbProfesional.DisplayMember = "APELLIDO";
            cmbProfesional.ValueMember = "APELLIDO";
           
            cmbProfesional.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProfesional.DataSource = new Query("SELECT NOMBRE, APELLIDO FROM TERCER_IMPACTO.PROFESIONAL " +
                "JOIN TERCER_IMPACTO.PROFESIONAL_ESPECIALIDAD ON ID_PROFESIONAL=MATRICULA " +
                " WHERE ID_ESPECIALIDAD='" + id_Especialidad + "'").ObtenerDataTable();
        }
        private void llenarTurnos()
        {
            //AND HABILITADO = 1"
            cmbTurno.SelectedItem = null;
            cmbTurno.DisplayMember = "FECHA";
            cmbTurno.ValueMember = "FECHA";      
            cmbTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            prof_esp = (decimal)new Query("SELECT ID_PROF_ESP FROM TERCER_IMPACTO.PROFESIONAL_ESPECIALIDAD " +
                "WHERE ID_PROFESIONAL='" + id_Medico.ToString() + "' AND ID_ESPECIALIDAD='" + id_Especialidad.ToString() + "'").ObtenerUnicoCampo();
            cmbTurno.DataSource = new Query("SELECT FECHA FROM TERCER_IMPACTO.TURNO " +
               " WHERE ID_MEDICO='" + prof_esp.ToString() + "' ").ObtenerDataTable();
        }
        private void obtenerCantBonos()
        {
            //agregar a la tabla Afiliado id_consulta
            cant_bonos = (int) new Query("SELECT COUNT(ID_BONO) FROM TERCER_IMPACTO.BONO " +
                 " WHERE ID_AFILIADO='" + id_Afiliado + "' and  ID_CONSULTA is null").ObtenerUnicoCampo();
            lblBonos.Text = Convert.ToString(cant_bonos);
            if (cant_bonos == 0)
             {
                MessageBox.Show("El usuario no tiene bonos disponibles", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }else
            {
                btnEfectivizar.Visible = true;
            }
        }


        private void btnEspecialidad_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbEspecialidad.Text))
            {
                MessageBox.Show("Seleccione una especialidad", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            id_Especialidad = (decimal)new Query("SELECT TOP 1 ID_ESPECIALIDAD FROM TERCER_IMPACTO.ESPECIALIDAD WHERE DESCRIPCION='" + cmbEspecialidad.Text + "'").ObtenerUnicoCampo();
            llenarProfesionales();
        }

        private void btnProfesional_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbProfesional.Text))
            {
                MessageBox.Show("Seleccione un Profesional", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            id_Medico = (decimal)new Query("SELECT TOP 1 MATRICULA FROM TERCER_IMPACTO.PROFESIONAL WHERE APELLIDO='" + cmbProfesional.Text + "'").ObtenerUnicoCampo();
           
            llenarTurnos();
        }

        private void btnTurno_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbTurno.Text))
            {
                MessageBox.Show("Seleccione un Turno", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //
            fechaTurno = Convert.ToDateTime(cmbTurno.Text);
            string format = "yyyy-MM-dd HH:mm:ss";
            string id_prof_esp = prof_esp.ToString();
            string hora = fechaTurno.ToString(format);

        
            id_Afiliado = (decimal)new Query("SELECT TOP 1 ID_AFILIADO FROM TERCER_IMPACTO.TURNO WHERE FECHA='" + hora + "' AND ID_MEDICO ='" + id_prof_esp + "' ").ObtenerUnicoCampo();
            id_Turno = (decimal)new Query("SELECT TOP 1 ID_TURNO FROM TERCER_IMPACTO.TURNO WHERE FECHA='" + hora + "' AND ID_MEDICO ='" + prof_esp.ToString() + "'AND ID_AFILIADO ='" + id_Afiliado.ToString() + "' ").ObtenerUnicoCampo();

            obtenerCantBonos();
        }

        private void btnEfectivizar_Click(object sender, EventArgs e)
        {
            string format = "yyyy-MM-dd HH:mm:ss";
            string hora = fechaTurno.ToString(format);
            bool existe=false;
            Query qr = new Query("SELECT TERCER_IMPACTO.EXISTE_CONSULTA('"+id_Turno.ToString()+"','"+hora+"')"); 
        
            existe = (bool)qr.ObtenerUnicoCampo();
            if (existe)
            {
                MessageBox.Show("La consulta ya existe.",
               "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbProfesional.DataSource = null;
                cmbTurno.DataSource = null;
                cmbTurno.Items.Clear();
                cmbProfesional.Items.Clear();
        
                btnEfectivizar.Visible = false;
                return;
            }
        
            new Query("INSERT INTO TERCER_IMPACTO.CONSULTA (ID_TURNO,FECHA) VALUES ('" + id_Turno + "','" + hora + "')").Ejecutar();
         

            qr = new Query("TERCER_IMPACTO.AGREGAR_ID_CONSULTA"); 
            qr.addParameter("@TURNO", id_Turno.ToString());
            qr.addParameter("@FECHA", hora);
            
            qr.Ejecutar();
            MessageBox.Show("La consulta se ha registrado exitosamente",
                "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmbProfesional.DataSource = null;
            cmbTurno.DataSource = null;
            cmbTurno.Items.Clear();
            cmbProfesional.Items.Clear();
            
            btnEfectivizar.Visible = false;
        }

        private void cmbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbProfesional.DataSource = null;
            cmbProfesional.Items.Clear();
            cmbTurno.DataSource = null;
            cmbTurno.Items.Clear();      
            btnEfectivizar.Visible = false;

        }

        private void cmbProfesional_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbTurno.DataSource = null;
            cmbTurno.Items.Clear();
            btnEfectivizar.Visible = false;
        }

        private void cmbTurno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
