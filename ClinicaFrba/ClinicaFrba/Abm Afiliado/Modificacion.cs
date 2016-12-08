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
    public partial class Modificacion : Form
    {
        private decimal plan_id;

        public Modificacion()
        {
            InitializeComponent();
        }

        private void Modificacion_Load(object sender, EventArgs e)
        {

            cmbId.ValueMember = "ID_AFILIADO";
            cmbId.DisplayMember = "ID_AFILIADO";
            cmbId.DataSource = new Query("SELECT ID_AFILIADO FROM TERCER_IMPACTO.AFILIADO WHERE HABILITADO=1").ObtenerDataTable();
            cmbId.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPlan.ValueMember = "DESCRIPCION";
            cmbPlan.DisplayMember = "DESCRIPCION";
            cmbPlan.DataSource = new Query("SELECT DESCRIPCION FROM TERCER_IMPACTO.PLAN_MEDICO").ObtenerDataTable();
            cmbPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.Items.Add("Soltero/a");
            cmbEstado.Items.Add("Casado/a");
            cmbEstado.Items.Add("Viudo/a");
            cmbEstado.Items.Add("Concubinato");
            cmbEstado.Items.Add("Divorciado/a");
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btn_sel_Click(object sender, EventArgs e)
        {
            string id_afil = cmbId.Text;
            string direccion =(string)new Query("SELECT ISNULL(DIRECCION,'') FROM TERCER_IMPACTO.AFILIADO WHERE ID_AFILIADO='" + id_afil + "'").ObtenerUnicoCampo();
            decimal telefono = (decimal)new Query("SELECT ISNULL(TELEFONO,0) FROM TERCER_IMPACTO.AFILIADO WHERE ID_AFILIADO='" + id_afil + "'").ObtenerUnicoCampo();
            string estado = (string)new Query("SELECT ISNULL(ESTADO_CIVIL,'') FROM TERCER_IMPACTO.AFILIADO WHERE ID_AFILIADO='" + id_afil + "'").ObtenerUnicoCampo();
            decimal cant_hijos=(decimal)new Query("SELECT ISNULL(CANT_HIJOS,0) FROM TERCER_IMPACTO.AFILIADO WHERE ID_AFILIADO='" + id_afil + "'").ObtenerUnicoCampo();
            string plan = (string)new Query("SELECT ISNULL(DESCRIPCION,'') FROM TERCER_IMPACTO.PLAN_MEDICO P JOIN TERCER_IMPACTO.AFILIADO A " +
                "ON P.ID_PLAN_MEDICO=A.ID_PLAN_MEDICO WHERE A.ID_AFILIADO='" + id_afil + "'").ObtenerUnicoCampo();
            plan_id=(decimal) new Query("SELECT ID_PLAN_MEDICO FROM TERCER_IMPACTO.AFILIADO WHERE ID_AFILIADO='"+id_afil+"'").ObtenerUnicoCampo();
            string mail= (string)new Query("SELECT ISNULL(MAIL,'') FROM TERCER_IMPACTO.AFILIADO WHERE ID_AFILIADO='" + id_afil + "'").ObtenerUnicoCampo();
            
            dirTxt.Text = direccion;
            telTxt.Text = telefono.ToString();
            mailTxt.Text = mail;
            cmbEstado.Text = estado;
            if (string.IsNullOrEmpty(estado))
                cmbEstado.SelectedItem = null;
            canTxt.Text = cant_hijos.ToString();
            cmbPlan.Text = plan;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(dirTxt.Text) || string.IsNullOrEmpty(telTxt.Text) ||
                string.IsNullOrEmpty(mailTxt.Text) || string.IsNullOrEmpty(cmbEstado.Text) ||
                cmbPlan.SelectedItem == null || string.IsNullOrEmpty(cmbPlan.Text) ||
                string.IsNullOrEmpty(canTxt.Text))
            {
                MessageBox.Show("Complete todos los campos por favor.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            
            
            if (!telTxt.Text.All(Char.IsDigit) || !canTxt.Text.All(Char.IsDigit))
            {
                MessageBox.Show("El teléfono y la cantidad de hijos deben ser números.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            decimal nuevo_plan_id = (decimal)new Query("SELECT TOP 1 ID_PLAN_MEDICO FROM TERCER_IMPACTO.PLAN_MEDICO WHERE DESCRIPCION='" + cmbPlan.Text + "'").ObtenerUnicoCampo();
            if (plan_id != nuevo_plan_id & string.IsNullOrEmpty(motivoTxt.Text))
            {
                MessageBox.Show("Debe dar un motivo para el cambio de plan.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string id_afil = cmbId.Text;
            string direccion = dirTxt.Text;
            string telefono = telTxt.Text;
            string estado = cmbEstado.Text;
            string cant_hijos = canTxt.Text;
            string mail=mailTxt.Text;
            string motivo=motivoTxt.Text;
            DateTime fecha=Convert.ToDateTime(Globals.fecha_sistema);
            string format = "yyyy-MM-dd hh:mm:ss";
            string fecha_sis = fecha.ToString(format);

            new Query("UPDATE TERCER_IMPACTO.AFILIADO SET DIRECCION='" + direccion + "' ,TELEFONO='" +
                telefono + "' ,ESTADO_CIVIL='" + estado + "' ,CANT_HIJOS='" + cant_hijos + "' ,MAIL='" + mail
                + "' ,ID_PLAN_MEDICO='" + nuevo_plan_id.ToString() + "' WHERE ID_AFILIADO='" + id_afil + "'").Ejecutar();
            if (plan_id != nuevo_plan_id & !string.IsNullOrEmpty(motivoTxt.Text))
            {
                new Query("INSERT INTO TERCER_IMPACTO.HISTORIAL_CAMBIO (ID_AFILIADO,ID_PLAN_ANTERIOR,FECHA_CAMBIO,MOTIVO) " +
                    "VALUES ('" + id_afil + "','" + plan_id.ToString() + "','" + fecha_sis + "','" + motivo + "')").Ejecutar();
            }

            plan_id = nuevo_plan_id;
            MessageBox.Show("Se actualizó correctamente el afiliado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
