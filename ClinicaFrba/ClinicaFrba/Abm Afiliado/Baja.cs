using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Abm_Afiliado
{
    public partial class Baja : Form
    {
        
        public Baja()
        {
            InitializeComponent();
           
        }

        private void LlenarComboBox()
        {

            cmbafiliados.DataSource = new Query("select ID_AFILIADO,NOMBRE,APELLIDO from TERCER_IMPACTO.AFILIADO").ObtenerDataTable();
            cmbafiliados.ValueMember = "APELLIDO" + ',' + "NOMBRE";
            cmbafiliados.SelectedItem = null;
            cmbafiliados.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        

        private void btnVolver_Click(object sender, EventArgs e)
        {

            ABMafiliado volver = new ABMafiliado();
            this.Hide();
            volver.ShowDialog();
            volver = (ABMafiliado)this.ActiveMdiChild;

        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            cmbafiliados.Text = "";
            
        }
        private void btnBaja_Click(object sender, EventArgs e)
        {
            DateTime fechaDeBaja = DateTime.Now;

            if (cmbafiliados.Text != "")
            { //dar de baja afiliado

                string nombreAfiliado = cmbafiliados.Text.ToString();

                //Query qr = new Query("TERCER_IMPACTO.DESHABILITAR_ROL"); //no hace falta poner EXEC
                //qr.addParameter("@nombre", nombreRol); //se agrega nombre de parametro y valor del mismo
                //qr.Ejecutar();

                MessageBox.Show("Afiliado inhabilitado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Visible = false;
            }
            else
            {
                //seleccione un afiliado

                MessageBox.Show("Seleccione un afiliado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }




        }
        

    }
}
