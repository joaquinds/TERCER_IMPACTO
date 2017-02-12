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
    public partial class EspecialidadConMasBonosUtilizados : Form
    {
        public EspecialidadConMasBonosUtilizados()
        {
            InitializeComponent();
        }

        private void EspecialidadConMasBonosUtilizados_Load(object sender, EventArgs e)
        {
            cmbsemestre.SelectedItem = null;
            cmbsemestre.Items.Add(1);
            cmbsemestre.Items.Add(2);
        }

        private void buscar_Click(object sender, EventArgs e)
        {

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
   
            Query qr = new Query("SELECT * FROM TERCER_IMPACTO.TOP5_ESP_BONOS('" + txtanio.Text + "','" + mes_inicial.ToString() + "','" + mes_final.ToString() + "')");
       

            EspecMasBonosGridView.DataSource = qr.ObtenerDataTable();
        }



        public DataTable armarTablaEspBonos(SqlCommand comando)
        {
            DataTable tabla = new DataTable();
            SqlDataReader reader;
            comando.CommandText = comando.CommandText + ")";
            tabla.Columns.Add("Especialidad", typeof(Int32));
        
            using (comando)
            {
                reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    DataRow fila = tabla.NewRow();
                    fila["Especialidad"] = (Int32)reader.GetValue(0);
                 
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

        private void limpiar_Click(object sender, EventArgs e)
        {
            txtanio.Text = "";
            cmbsemestre.SelectedItem = null;
            EspecMasBonosGridView.Rows.Clear();

        }

        private void EspecMasBonosGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        }

 

    }

