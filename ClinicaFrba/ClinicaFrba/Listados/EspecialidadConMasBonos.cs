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
    public partial class EspecialidadConMasBonos : Form
    {
        public EspecialidadConMasBonos()
        {
            InitializeComponent();
        }

        private void EspecialidadConMasBonos_Load(object sender, EventArgs e)
        {
            cmbSemestre.SelectedItem = null;
            cmbSemestre.Items.Add(1);
            cmbSemestre.Items.Add(2);
            
        }

        private void buscar_Click(object sender, EventArgs e)
        {
          
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
            Query qr = new Query("TERCER_IMPACTO.TOP5_ESP_BONO");
            qr.addParameter("@ANIO", txtAño.Text);
            qr.addParameter("@MES_INICIAL", mes_inicial.ToString());
            qr.addParameter("@MES_FINAL", mes_final.ToString());

            //como llenar la tabla con un query?
            tabla = armarTablaEspBonos(qr);
            return tabla;
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
        }

 

    }

