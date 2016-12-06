using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Cancelar_Atencion
{
    public partial class CancelarAtencionM : Form
    {
        public CancelarAtencionM()
        {
            InitializeComponent();
        }

        private void btnDia_Click(object sender, EventArgs e)
        {
            Cancelar_Atencion.CancelacionDia cancelarD = new Cancelar_Atencion.CancelacionDia();
            cancelarD.ShowDialog();
        }

        private void btnPeriodo_Click(object sender, EventArgs e)
        {
            Cancelar_Atencion.CancelacionPeriodo cancelarP = new Cancelar_Atencion.CancelacionPeriodo();
            cancelarP.ShowDialog();
        }
    }
}
