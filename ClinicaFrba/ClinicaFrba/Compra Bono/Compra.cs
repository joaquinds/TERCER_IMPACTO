using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Compra_Bono
{
    public partial class Compra : Form
    {
        public Compra()
        {
            InitializeComponent();
        }


        private void Compra_Load(object sender, EventArgs e)
        {
            if (Globals.nombre_rol != "AFILIADO")
            {
                comboAfiliado.DataSource = new Query("SELECT ID_AFILIADO FROM TERCER_IMPACTO.AFILIADO").ObtenerDataTable();
                comboAfiliado.ValueMember = "ID_AFILIADO";
                comboAfiliado.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            else
            {
                afiLabel.Visible = false;
                comboAfiliado.Visible = false;

            }
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {   string cantidad=textCantidad.Text;
            int cant;
            if(!int.TryParse(cantidad, out cant) || cant<1){
                MessageBox.Show("Ingrese un numero entero positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal id_afiliado;
            if (Globals.nombre_rol != "AFILIADO")
            {
                id_afiliado = Convert.ToDecimal(comboAfiliado.Text);
            }
            else
            {
                id_afiliado = (decimal)new Query("SELECT ID_AFILIADO FROM TERCER_IMPACTO.AFILIADO " +
                    "WHERE USUARIO_ID='" + Globals.id_usuario + "'").ObtenerUnicoCampo(); 
            }
            bool habilitado = (bool)new Query("SELECT HABILITADO FROM TERCER_IMPACTO.AFILIADO WHERE ID_AFILIADO='" + id_afiliado + "'").ObtenerUnicoCampo();
            if (!habilitado){
                MessageBox.Show("El usuario no se encuentra habilitado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            decimal precio = (decimal)new Query("SELECT TERCER_IMPACTO.RETORNAR_PRECIO_BONOS ('" + id_afiliado + "','" + cant + "')").ObtenerUnicoCampo();

            Query qr1 = new Query("SELECT TERCER_IMPACTO.TIENE_FAMILIA('"+id_afiliado.ToString()+"')");
            bool tiene_familia = (bool)qr1.ObtenerUnicoCampo();

            if (!tiene_familia)
            {
                Query procedure = new Query("TERCER_IMPACTO.COMPRAR_BONOS");
                procedure.addParameter("@ID_AFIL", id_afiliado.ToString());
                procedure.addParameter("@CANT", cant.ToString());
                procedure.addParameter("@FECHA", Globals.fecha_sistema);
                procedure.Ejecutar();
            }
            else
            {
                decimal num_familia = (decimal)new Query("SELECT TOP 1 NUM_FAMILIA FROM TERCER_IMPACTO.AFILIADO WHERE ID_AFILIADO='" + id_afiliado.ToString() + "' ").ObtenerUnicoCampo();
                Query procedure = new Query("TERCER_IMPACTO.COMPRAR_BONOS_FAMILIA");
                procedure.addParameter("@ID_AFIL", id_afiliado.ToString());
                procedure.addParameter("@CANT", cant.ToString());
                procedure.addParameter("@FECHA", Globals.fecha_sistema);
                procedure.addParameter("@NUM_FAM", num_familia.ToString());
                procedure.Ejecutar();
            }


            MessageBox.Show("Compra realizada con exito, el precio es "+
            precio +" pesos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

         }

     
    }
}
