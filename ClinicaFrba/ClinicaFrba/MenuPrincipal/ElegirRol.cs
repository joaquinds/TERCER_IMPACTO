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
    public partial class ElegirRol : Form
    {
        DataTable roles;

        public ElegirRol(DataTable tabla)
        {
            roles = tabla;
            InitializeComponent();
        }

        private void ElegirRol_Load(object sender, EventArgs e)
        {
            comboRol.DataSource = roles;
            comboRol.ValueMember = "NOMBRE";
            comboRol.SelectedItem = null;
            comboRol.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnElegir_Click(object sender, EventArgs e)
        {
            string nombre = comboRol.Text;

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Seleccione un rol.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool anduvo = false;
            foreach (DataRow fila in roles.Rows){

                if ((string)fila["NOMBRE"] == nombre)
                {
                    Globals.nombre_rol = nombre;
                    Globals.id_rol = (decimal)fila["ID_ROL"];
                    anduvo = true;
                    break;
                }
            }

            if (anduvo)
            {
                MenuPrincipal.Menus menu = new MenuPrincipal.Menus();
                menu.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se encontro el rol.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
    }
}
