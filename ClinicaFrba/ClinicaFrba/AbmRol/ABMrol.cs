using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.AbmRol
{
    public partial class ABMrol : Form
    {
        public ABMrol()
        {
            InitializeComponent();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            
            Alta frm = new Alta();
            frm.ShowDialog();
            
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
       
            Baja frm = new Baja();
            frm.ShowDialog();
           
        }

        private void btnModificacion_Click(object sender, EventArgs e)
        {
           
            Modificacion frm = new Modificacion();
            frm.ShowDialog();
            
        }
    }
}
