using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace ClinicaFrba
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string usernameText = username.Text.Trim();
            string passwordText = pass.Text.Trim();

            if (string.IsNullOrEmpty(usernameText) || string.IsNullOrEmpty(passwordText))
            {
               MessageBox.Show("Los campos Username y Password son obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               return;
            }
            
            //Get user
            string consulta = "SELECT top 1 ID_USUARIO, PASS, INTENTOS_FALLIDOS FROM TERCER_IMPACTO.USUARIO "+
            "WHERE USERNAME ='" + usernameText + "'";
            Query qr = new Query(consulta);
            DataTable table = (DataTable)qr.ObtenerDataTable();
            int cant = table.Rows.Count;
            //Validate if  User exist
            if (cant ==1 )
            {

                DataRow user = table.Rows[0];
                int intentos = (int)user["INTENTOS_FALLIDOS"];
                if (intentos < 3)
                {
                    //Validate password
                    string password_db = (string)user["PASS"];
                    decimal codigo = (decimal)user["ID_USUARIO"]; //el numeric se castea a decimal
                    
                    bool bienPass = (bool)new Query("SELECT TERCER_IMPACTO.COMPARAR_HASH( '" + passwordText + "','" + password_db + "')").ObtenerUnicoCampo();
                    if (bienPass)
                    {
                     
                        string updateIntento = "update TERCER_IMPACTO.USUARIO set INTENTOS_FALLIDOS = '0' where ID_USUARIO ='" + codigo + "'";
                        new Query(updateIntento).Ejecutar();
                        //Validate cant de roles
                        string consulta2 = "select NOMBRE,ID_ROL from TERCER_IMPACTO.ROL join TERCER_IMPACTO.ROL_USUARIO on ROL_ID=ID_ROL where USUARIO_ID='" + codigo + "'";
                        Query qr2 = new Query(consulta2);
                        DataTable tableRoles = (DataTable)qr2.ObtenerDataTable();
                        this.Visible = false;
                        if (tableRoles.Rows.Count > 1)
                        {
                            MessageBox.Show("entraste", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            // Home.MultiRolHome frm = new Home.MultiRolHome();
                            //frm.ShowDialog();
                        }
                        else if (tableRoles.Rows.Count == 0)
                        {
                            MessageBox.Show("No tiene un rol asignado");
                        }
                        else
                        {
                           
                            DataRow rolRow = tableRoles.Rows[0];
                            string rol = (string)rolRow["NOMBRE"];
                            Globals.id_rol = (decimal)rolRow["ID_ROL"];
                            Globals.id_usuario = codigo;
                            Globals.nombre_rol = rol;
                            //Rol unico Admin
                            if (rol == "ADMINISTRATIVO")
                            {
                                
                                MenuPrincipal.Menu menu = new MenuPrincipal.Menu();
                                menu.ShowDialog();
                            }
                            //Rol unico Cliente
                            else
                            {
                                //Home.ClientHome frm = new Home.ClientHome();
                                // frm.ShowDialog();
                            }
                        }
                    }
                    else
                    {
                        //Intentos +1
                        string updateIntento = "update TERCER_IMPACTO.USUARIO set INTENTOS_FALLIDOS ='" + (intentos + 1) + "' where ID_USUARIO ='" + codigo + "'";
                        new Query(updateIntento).Ejecutar();
                        MessageBox.Show("Password incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("El usuario ingresado se encuentra inhabilitado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("El usuario ingresado no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            

        }




    }
}
