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

    }
}
