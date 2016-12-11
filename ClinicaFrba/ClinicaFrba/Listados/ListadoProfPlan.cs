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

        private void ListadoProfPlan_Load(object sender, EventArgs e)
        {
            cmbSemestre.SelectedItem = null;
            cmbSemestre.Items.Add(1);
            cmbSemestre.Items.Add(2);
            llenarComboPlan();

        }

        private void llenarComboPlan()
        {
            cmbPlan.DataSource = new Query("SELECT ID_PLAN FROM TERCER_IMPACTO.PLAN_MEDICO").ObtenerDataTable();
            cmbPlan.ValueMember = "ID_PLAN";
            cmbPlan.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void buscar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(cmbPlan.Text))
            {
                MessageBox.Show("Seleccione un horario", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrEmpty(cmbSemestre.Text))
            {
                MessageBox.Show("Seleccione un semestre", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrEmpty(txtAño.Text))
            {
                MessageBox.Show("Ingrese un año", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int mes_inicial;
            int mes_final;

            int semestre = int.Parse(cmbSemestre.SelectedItem.ToString());
            mes_inicial = mesInicial(semestre);
            mes_final = mesFinal(semestre);

            var tabla = new DataTable();
            Query qr = new Query("TERCER_IMPACTO.TOP5_PROF_PLAN");
            qr.addParameter("@ANIO", txtAño.Text);
            qr.addParameter("@MES_INICIAL", mes_inicial.ToString());
            qr.addParameter("@MES_FINAL", mes_final.ToString());
            qr.addParameter("@PLAN_COD", cmbPlan.SelectedItem.ToString());

            //como llenar la tabla con un query?
            tabla = armarTablaProfMasConsultados(qr);
            
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

        private void ProfMasConsultadosGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
