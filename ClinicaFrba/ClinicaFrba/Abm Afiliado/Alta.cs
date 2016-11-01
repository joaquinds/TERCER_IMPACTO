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
    public partial class Alta : Form
    {
        public Alta()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtnombre.Text = "";
            txtapellido.Text = "";
            txtdireccion.Text = "";
            txttelefono.Text = "";
            txtmail.Text = "";
            txtdoc.Text = "";
            cmbestcivil.Text = "";
            cmbtipodoc.Text = "";
            dtpfechanac.Text = "";
            numfamiliares.Value = 0;
            rdbfemenino.Text = "";
            rdbmasculino.Text = "";
            txtafiliado.Text = "";
            txtplan.Text = "";


        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

            ABMafiliado volver = new ABMafiliado();
            this.Hide();
            volver.ShowDialog();
            volver = (ABMafiliado)this.ActiveMdiChild;

        }

        private void btnAlta_Click(object sender,EventArgs e)
        {
            string nombre = txtnombre.Text;
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Complete el nombre del afiliado para dar de alta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string apellido = txtapellido.Text;
            if (string.IsNullOrEmpty(apellido))
            {
                MessageBox.Show("Complete el apellido del afiliado para dar de alta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string tipo_doc = cmbtipodoc.Text;
            if (string.IsNullOrEmpty(tipo_doc))
            {
                MessageBox.Show("Ingrese el tipo de documento de identidad del afiliado para dar de alta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string nro_doc = txtdoc.Text;
            if (string.IsNullOrEmpty(nro_doc))
            {
                MessageBox.Show("Ingrese el documento de identidad del afiliado para dar de alta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string direccion = txtdireccion.Text;
            string telefono = txttelefono.Text;
            string mail = txtmail.Text;
            string estado_civil = cmbestcivil.Text; 
            DateTime fecha_nac = Convert.ToDateTime(dtpfechanac);
            char sexo;
            if (rdbfemenino.Checked == true)
            {
                sexo = 'F';
            }
            else
            {
                sexo = 'M';
            }
            int cant_hijos = Convert.ToInt32(numfamiliares);
            

            new Query("INSERT INTO TERCER_IMPACTO.AFILIADO (NOMBRE,APELLIDO,TIPO_DOC,NRO_DOC,DIRECCION,TELEFONO,MAIL,FECHA_NAC,SEXO,ESTADO_CIVIL,CANT_HIJOS) VALUES ('" + nombre + "','" + apellido + "','" + tipo_doc + "','" + nro_doc + "','" + direccion + "','" + telefono + "','" + mail + "','" + fecha_nac + "','" + sexo + "','" + estado_civil + "','" + cant_hijos + "')").Ejecutar();
            MessageBox.Show("Alta de afiliado procesada exitosamente.","Información", MessageBoxButtons.OK, MessageBoxIcon.Information);


 
            






        }

           
        
 
    }
}
