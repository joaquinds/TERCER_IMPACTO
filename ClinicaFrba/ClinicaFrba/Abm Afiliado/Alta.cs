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

        private void btnAlta_Click(object sender,EventArgs e)
        {
            string nombre = txtnombre.Text;
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Complete el/los nombres del afiliado para dar de alta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string apellido = txtapellido.Text;
            if (string.IsNullOrEmpty(apellido))
            {
                MessageBox.Show("Complete el/los apellidos del afiliado para dar de alta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string tipodoc = cmbtipodoc.Text;
            if (string.IsNullOrEmpty(tipodoc))
            {
                MessageBox.Show("Ingrese el tipo de documento de identidad del afiliado para dar de alta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string doc = txtdoc.Text;
            if (string.IsNullOrEmpty(doc))
            {
                MessageBox.Show("Ingrese el documento de identidad del afiliado para dar de alta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string direccion = txtdireccion.Text;
            string telefono = txttelefono.Text;
            string mail = txtmail.Text;
            string estcivil = cmbestcivil.Text;
            DateTime fechanac = Convert.ToDateTime(dtpfechanac);
            if (rdbfemenino.Checked == true)
            {
                string sexo = Convert.ToString(rdbfemenino);
            }
            else
            {
                string sexo = Convert.ToString(rdbmasculino);
            }
            int famacargo = Convert.ToInt32(numfamiliares);


 
            






        }

           
        
 
    }
}
