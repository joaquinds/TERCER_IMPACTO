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
    public partial class Alta : Form
    {
        public Alta()
        {
            InitializeComponent();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            string rol = rolNuevo.Text;
            if (string.IsNullOrEmpty(rol))
            {
                MessageBox.Show("Ingrese un nombre de rol para dar de alta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            new Query("INSERT INTO TERCER_IMPACTO.ROL (NOMBRE) VALUES ('" + rol + "')").Ejecutar();
            MessageBox.Show("Rol habilitado exitosamente, dirigirse a modificacion para agregar funciones.", 
                "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
