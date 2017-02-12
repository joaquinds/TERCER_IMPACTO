using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ClinicaFrba.Listados
{
    public partial class EspecialidadesConMenosHorasTrabajadas : Form
    {
        public EspecialidadesConMenosHorasTrabajadas()
        {
            InitializeComponent();
            cmbsemestre.SelectedItem = null;
            cmbsemestre.Items.Add(1);
            cmbsemestre.Items.Add(2);
            llenarComboPlan();
            llenarComboEspecialidad();
        }

        private void EspecialidadesConMenosHorasTrabajadas_Load(object sender, EventArgs e)
        {
  
        }

        //se llena el combo plan
        private void llenarComboPlan()
        {
            cmbplan.DataSource = new Query("SELECT ID_PLAN_MEDICO ,DESCRIPCION FROM TERCER_IMPACTO.PLAN_MEDICO").ObtenerDataTable();
            cmbplan.ValueMember = "ID_PLAN_MEDICO";
            cmbplan.DisplayMember = "DESCRIPCION";
            cmbplan.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        //se llena el combo especialidad
        private void llenarComboEspecialidad()
        {
            cmbespecialidad.DataSource = new Query("SELECT ID_ESPECIALIDAD, DESCRIPCION FROM TERCER_IMPACTO.ESPECIALIDAD").ObtenerDataTable();
            cmbespecialidad.ValueMember = "ID_ESPECIALIDAD";
            cmbespecialidad.DisplayMember = "DESCRIPCION";
            cmbespecialidad.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtanio.Text = "";
            cmbespecialidad.SelectedItem = null;
            cmbplan.SelectedItem = null;
            cmbsemestre.SelectedItem = null;
            dataGridView1.Rows.Clear();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbplan.Text))
            {
                MessageBox.Show("Seleccione un plan", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrEmpty(cmbespecialidad.Text))
            {
                MessageBox.Show("Seleccione una especialidad", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrEmpty(cmbsemestre.Text))
            {
                MessageBox.Show("Seleccione un semestre", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrEmpty(txtanio.Text) || Convert.ToInt32(txtanio.Text) < 1950 || Convert.ToInt32(txtanio.Text) > 2016)
            {
                MessageBox.Show("Ingrese un año entre 1950 y 2016", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            int mes_inicial;
            int mes_final;

            int semestre = int.Parse(cmbsemestre.SelectedItem.ToString());
            mes_inicial = mesInicial(semestre);
            mes_final = mesFinal(semestre);


            var tabla = new DataTable();

            decimal id_plan = decimal.Parse(cmbplan.SelectedValue.ToString());

            Query qr = new Query("SELECT * FROM TERCER_IMPACTO.PROFESIONALES_CON_MENOS_HORAS('" + id_plan.ToString() + "','" + cmbespecialidad.SelectedValue.ToString() + "','" + txtanio.Text + "','" + mes_inicial.ToString() + "','" + mes_final.ToString() + "')");
           


            dataGridView1.DataSource = qr.ObtenerDataTable();

        }

   

        public int mesInicial(int semestre)
        {
            int mes;
            if (semestre == 1)
            {
                mes = 1;
            }
            else
            {
                mes = 6;
            }
            return mes;
        }

        public int mesFinal(int semestre)
        {
            int mes;
            if (semestre == 1)
            {
                mes = 6;
            }
            else
            {
                mes = 12;
            }
            return mes;
        }
    }


}
