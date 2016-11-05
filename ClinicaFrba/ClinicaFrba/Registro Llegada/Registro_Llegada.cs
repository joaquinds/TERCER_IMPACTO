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
        private DateTime fechaTurno;
        private decimal cant_bonos;

        public Registro_Llegada()
        {
            cant_bonos = 0;
            id_Especialidad = -1;
            id_Medico = -1;
            id_Turno = -1;
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
            cmbProfesional.DataSource = new Query("SELECT NOMBRE, APELLIDO FROM TERCER_IMPACTO.PROFESIONAL " +
                "JOIN TERCER_IMPACTO.PROFESIONAL_ESPECIALIDAD ON ID_PROFESIONAL=MATRICULA " +
                " WHERE ID_ESPECIALIDAD='" + id_Especialidad + "'").ObtenerDataTable();
            cmbProfesional.ValueMember = "APELLIDO";
            cmbProfesional.SelectedItem = null;
            cmbProfesional.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void llenarTurnos()
        {
            cmbTurno.DataSource = new Query("SELECT FECHA FROM TERCER_IMPACTO.TURNO " +
                " WHERE ID_MEDICO='" + id_Medico + "'").ObtenerDataTable();
            cmbTurno.ValueMember = "FECHA";
            cmbTurno.SelectedItem = null;
            cmbTurno.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void obtenerCantBonos()
        {
            //agregar a la tabla Afiliado un atributo CantBonos, que sea un count de todos los bonos con mismo id_afiliado
            cant_bonos = (decimal) new Query("SELECT CANT_BONOS FROM TERCER_IMPACTO.AFILIADO " +
                 " WHERE ID_AFILIADO='" + id_Afiliado + "'").ObtenerUnicoCampo();
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
            fechaTurno = Convert.ToDateTime(cmbTurno.Text);
            id_Afiliado = (decimal)new Query("SELECT TOP 1 ID_AFILIADO FROM TERCER_IMPACTO.TURNO WHERE FECHA='" + fechaTurno + "' AND ID_MEDICO ='" + id_Medico + "' ").ObtenerUnicoCampo();
            id_Turno = (decimal)new Query("SELECT TOP 1 ID_TURNO FROM TERCER_IMPACTO.TURNO WHERE FECHA='" + Convert.ToDateTime(cmbTurno.Text) + "' AND ID_MEDICO ='" + id_Medico + "'AND ID_AFILIADO ='" + id_Afiliado + "' ").ObtenerUnicoCampo();

            obtenerCantBonos();
        }

        private void btnEfectivizar_Click(object sender, EventArgs e)
        {
            new Query("INSERT INTO TERCER_IMPACTO.CONSULTA (ID_TURNO,FECHA) VALUES ('" + id_Turno + "','" + fechaTurno +"')").Ejecutar();
            MessageBox.Show("La consulta se ha registrado exitosamente",
                "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
