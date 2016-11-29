using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaFrba.MenuPrincipal;

namespace ClinicaFrba.Listados
{
    public partial class ListadoEstadistico : Form
    {
        public ListadoEstadistico()
        {
            InitializeComponent();
        }

        private void FrmListadoEstadistico_Load(object sender, EventArgs e)
        {

            txtanio.Focus();
            
            //CARGA COMBOBOX SEMESTRE
            cmbsemestre.Items.Add("1S");
            cmbsemestre.Items.Add("2S");
            
            //CARGA COMBOBOX MES
            cmbmes.Items.Add("Mes 1");
            cmbmes.Items.Add("Mes 2");
            cmbmes.Items.Add("Mes 3");
            cmbmes.Items.Add("Mes 4");
            cmbmes.Items.Add("Mes 5");
            cmbmes.Items.Add("Mes 6");

            //ESCONDER BOTONES
            this.btnbonoconsulta.Enabled = false;
            this.btnbonos.Enabled = false;
            this.btncancelaciones.Enabled = false;
            this.btnconsultados.Enabled = false;
            this.btnhoras.Enabled = false;


        }



        private void txtAnio_TextChanged(object sender, EventArgs e)
        {

            if (txtanio.Text.Trim() != "" && cmbsemestre.Text != "" && txtanio.Text.Length == 4 && cmbmes.Text != "")
            {
                if (Convert.ToInt32(txtanio.Text) > 1900 && Convert.ToInt32(txtanio.Text) < 2016)
                {
                    this.btnbonoconsulta.Enabled = true;
                    this.btnbonos.Enabled = true;
                    this.btncancelaciones.Enabled = true;
                    this.btnconsultados.Enabled = true;
                    this.btnhoras.Enabled = true;

                }
                else
                {
                    MessageBox.Show("Se debe ingresar un año correcto entre 1900 y 2016", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtanio.Text = "";
                }

            }


        }

        private void comboBoxTrimestre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtanio.Text.Trim() != "" && cmbsemestre.Text != "" && cmbmes.Text != "")
            {
                this.btnbonoconsulta.Enabled = true;
                this.btnbonos.Enabled = true;
                this.btncancelaciones.Enabled = true;
                this.btnconsultados.Enabled = true;
                this.btnhoras.Enabled = true;
            }

        }

        private void bnVolver_Click(object sender, EventArgs e)
        {
            Menus frm = new Menus();
            this.Hide();
            frm.ShowDialog();
            frm = (Menus)this.ActiveMdiChild;

        }


        private void btnbonoconsultas_Click(object sender, EventArgs e)
        {
            //Top 5 de las especialidades de médicos con más bonos de consultas utilizados.	
            string listado = "";
            Query qry = new Query(listado);
            dgvestadisticas.DataSource = qry.ObtenerDataTable(); 
        }






        private void btnbonos_Click(object sender, EventArgs e)
        {
            //Top 5 de los afiliados con mayor cantidad de bonos comprados, detallando si pertenece a un grupo familiar.	
            string listado = "";
            Query qry = new Query(listado);
            dgvestadisticas.DataSource = qry.ObtenerDataTable();
        }







        private void btncancelaciones_Click(object sender, EventArgs e)
        {
            //Top 5 de las especialidades que más se registraron cancelaciones, tanto de afiliados como de profesionales.		
            string listado = "";
				                           
            Query qry = new Query(listado);
            dgvestadisticas.DataSource = qry.ObtenerDataTable();
        }





        private void btnconsultados_Click(object sender, EventArgs e)
        {
            //Top 5 de los profesionales más consultados por Plan, detallando también bajo que Especialidad.	
            string listado = "";
            Query qry = new Query(listado);
            dgvestadisticas.DataSource = qry.ObtenerDataTable();
        }






        private void btnhoras_Click(object sender, EventArgs e)
        {
            //Top 5 de los profesionales con menos horas trabajadas filtrando por Plan y Especialidad.		
            string listado = "";
            Query qry = new Query(listado);
            dgvestadisticas.DataSource = qry.ObtenerDataTable();
        }






        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtanio.Text = "";
            cmbsemestre.Text = "";
            cmbmes.Text = "";
            dgvestadisticas.Rows.Clear();

        }
    }
}

