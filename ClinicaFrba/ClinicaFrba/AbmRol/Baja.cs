using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClinicaFrba.AbmRol
{
    public partial class Baja : Form
    {
        public Baja()
        {
            InitializeComponent();
        }

   

        private  void LlenarComboBox()
        {
            
            comboRol.DataSource = new Query("select NOMBRE from TERCER_IMPACTO.ROL where HABILITADO = 1").ObtenerDataTable();
            comboRol.ValueMember = "NOMBRE";
            comboRol.SelectedItem = null;
            comboRol.DropDownStyle = ComboBoxStyle.DropDownList;
        
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            if (comboRol.Text != "")
            { //dar de baja rol

                string nombreRol = comboRol.Text.ToString();

                Query qr= new Query("TERCER_IMPACTO.DESHABILITAR_ROL"); //no hace falta poner EXEC
                qr.addParameter("@nombre", nombreRol); //se agrega nombre de parametro y valor del mismo
                qr.Ejecutar();

                MessageBox.Show("Rol inhabilitado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Visible = false;
            }
            else
            {
                //seleccione un rol

                MessageBox.Show("Seleccione un Rol", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void Baja_Load(object sender, EventArgs e)
        {
            LlenarComboBox();
            comboRol.Text = null;

            comboRol.DropDownStyle = ComboBoxStyle.DropDownList;
        }

    
    }
}
