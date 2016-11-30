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



namespace ClinicaFrba.Abm_Afiliado
{
    public partial class ABMafiliado : Form
    {
        public ABMafiliado()
        {
            InitializeComponent();
        }
        private void btnAlta_Click(object sender, EventArgs e)
        {
            Alta frm = new Alta();
            frm.ShowDialog();
            this.Hide();

        }
        private void btnBaja_Click(object sender, EventArgs e)
        {
            Baja frm = new Baja();
            frm.ShowDialog();
            this.Hide();
        }
        private void btnModificacion_Click(object sender, EventArgs e)
        {
            Modificacion frm = new Modificacion();
            frm.ShowDialog();
            this.Hide();
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            Menus frm = new Menus();
            this.Hide();
            frm.ShowDialog();
            frm = (Menus)this.ActiveMdiChild;

        }

        private void ABMafiliado_Load(object sender, EventArgs e)
        {
        }
       
    }
}
