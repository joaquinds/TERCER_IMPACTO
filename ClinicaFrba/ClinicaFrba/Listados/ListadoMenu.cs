using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Listados
{
    public partial class ListadoMenu : Form
    {
        public ListadoMenu()
        {
            InitializeComponent();
        }

        private void btnconsulta_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["ListadoProfPlan"] as ListadoProfPlan ) == null)
            {
                var list = new ListadoProfPlan();
                list.Show();
            }

        }

        private void btnbonosutilizados_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["EspecialidadConMasBonosUtilizados"] as EspecialidadConMasBonosUtilizados) == null)
            {
                var list = new EspecialidadConMasBonosUtilizados();
                list.Show();
            }

        }

        private void btnbonoscomprados_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["AfiliadoConMasBonosComprados"] as AfiliadoConMasBonosComprados) == null)
            {
                var list = new AfiliadoConMasBonosComprados();
                list.Show();
            }

        }

        private void btnhoras_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["EspecialidadesConMenosHorasTrabajadas"] as EspecialidadesConMenosHorasTrabajadas) == null)
            {
                var list = new EspecialidadesConMenosHorasTrabajadas();
                list.Show();
            }

        }

        private void btncancelaciones_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["EspecialidadesQueMasRegistraronCancelaciones"] as EspecialidadesQueMasRegistraronCancelaciones) == null)
            {
                var list = new EspecialidadesQueMasRegistraronCancelaciones();
                list.Show();
            }

        }
    }
}
