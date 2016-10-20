using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.MenuPrincipal
{
    public partial class Menu : Form
    {
        private bool abmRolVisible;

        public Menu()
        {
            abmRolVisible=false;
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            DataTable funcionalidades = new Query("SELECT DESCRIPCION FROM TERCER_IMPACTO.FUNCIONALIDAD JOIN " +
                "TERCER_IMPACTO.ROL_FUNCIONALIDAD ON ID_FUNC=FUNC_ID WHERE ROL_ID='" + Globals.id_rol + "'").ObtenerDataTable();

            foreach (DataRow fila in funcionalidades.Rows)
            {
                if ((string)fila["DESCRIPCION"] == "ABM ROL")  //asi para cada funcionalidad
                    abmRolVisible = true;



            }

            btnABMRol.Visible = abmRolVisible;
        }

        private void btnABMRol_Click(object sender, EventArgs e)
        {
            AbmRol.ABMrol abm = new AbmRol.ABMrol();
            abm.ShowDialog();
        }
    }
}
