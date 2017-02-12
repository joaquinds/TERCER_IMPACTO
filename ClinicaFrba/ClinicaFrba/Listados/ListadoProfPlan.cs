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
    public partial class ListadoProfPlan : Form
    {
        public ListadoProfPlan()
        {
            InitializeComponent();
        }


        //se cargan los combobox
        private void ListadoProfPlan_Load(object sender, EventArgs e)
        {
            cmbsemestre.SelectedItem = null;
            cmbsemestre.Items.Add(1);
            cmbsemestre.Items.Add(2);
            llenarComboPlan();
        }

        //se llena el combo plan
        private void llenarComboPlan()
        {
            cmbplan.DataSource = new Query("SELECT ID_PLAN_MEDICO,DESCRIPCION FROM TERCER_IMPACTO.PLAN_MEDICO").ObtenerDataTable();
            cmbplan.ValueMember = "ID_PLAN_MEDICO";
            cmbplan.DisplayMember = "DESCRIPCION";
            cmbplan.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        //se llena la grilla con los datos y se validan los datos de entrada
        private void buscar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(cmbplan.Text))
            {
                MessageBox.Show("Seleccione un plan", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
         
            Query qr = new Query("SELECT * FROM TERCER_IMPACTO.TOP5_PROF_PLAN('" + txtanio.Text + "','" + mes_inicial.ToString() + "','" + mes_final.ToString() + "','"+cmbplan.SelectedValue.ToString()+"')");
     

          
            ProfMasConsultadosGridView.DataSource = qr.ObtenerDataTable();
        }



        public DataTable armarTablaProfMasConsultados(SqlCommand comando)
        {
            DataTable tabla = new DataTable();
            SqlDataReader reader;
            comando.CommandText = comando.CommandText + ")";
            tabla.Columns.Add("Codigo de profesional", typeof(Int32));
            tabla.Columns.Add("Nombre", typeof(string));
            tabla.Columns.Add("Apellido", typeof(string));
            tabla.Columns.Add("Especialidad", typeof(string));
            tabla.Columns.Add("Numero de consultas", typeof(Int32));
            using (comando)
            {
                reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    DataRow fila = tabla.NewRow();
                    fila["Codigo de profesional"] = (Int32)reader.GetValue(0);
                    fila["Nombre"] = (String)reader.GetValue(1);
                    fila["Apellido"] = (String)reader.GetValue(2);                   
                    fila["Especialidad"] = (String)reader.GetValue(3);
                    fila["Numero de consultas"] = (Int32)reader.GetValue(4);
                    tabla.Rows.Add(fila);
                }
            }
            return tabla;
        }


        //funciones auxiliares
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

      

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtanio.Text = "";
            cmbplan.SelectedItem = null;
            cmbsemestre.SelectedItem = null;
            ProfMasConsultadosGridView.Rows.Clear();
        }
    }
}
