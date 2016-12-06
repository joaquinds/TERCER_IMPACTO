using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.ABM_Afiliado2
{
    public partial class Baja : Form
    {
        public Baja()
        {
            InitializeComponent();
        }

        private void btn_baja_Click(object sender, EventArgs e)
        {
            DateTime fecha=Convert.ToDateTime(Globals.fecha_sistema);
            string format = "yyyy-MM-dd hh:mm:ss";
            string fecha_sis = fecha.ToString(format);
            string id=cmbId.Text;
            new Query("UPDATE TERCER_IMPACTO.AFILIADO SET HABILITADO='0',FECHA_BAJA='" + fecha_sis + "'" +
                " WHERE ID_AFILIADO='" + id + "'").Ejecutar();
            new Query("UPDATE TERCER_IMPACTO.TURNO SET HABILITADO='0' WHERE ID_AFILIADO='" + id + "'"+
                " AND FECHA>'"+fecha_sis+"'").Ejecutar();
            new Query("INSERT INTO TERCER_IMPACTO.CANCELACION (ID_TURNO,TIPO,EXPLICACION) " +
                "SELECT ID_TURNO,'AFILIADO','SE DIO DE BAJA AFILIADO' FROM TERCER_IMPACTO.TURNO " +
                "WHERE ID_AFILIADO='" + id + "' AND FECHA>'"+fecha_sis+"'").Ejecutar();

            MessageBox.Show("Se dio de baja el afiliado de id: " + id , "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Baja_Load(sender,e);
        }

        private void Baja_Load(object sender, EventArgs e)
        {
            cmbId.ValueMember = "ID_AFILIADO";
            cmbId.DisplayMember = "ID_AFILIADO";
            cmbId.DataSource = new Query("SELECT ID_AFILIADO FROM TERCER_IMPACTO.AFILIADO WHERE HABILITADO=1").ObtenerDataTable();
            cmbId.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
