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
    public partial class Alta : Form
    {
        decimal random;
        public Alta()
        {
            InitializeComponent();
            random = -1;
            
        }

        private void Alta_Load(object sender, EventArgs e)
        {
            cmbSexoLoad();
            cmbEstadoLoad();
            cmbPlanLoad();
        }

        private void cmbPlanLoad()
        {
            cmbPlan.ValueMember = "ID_PLAN_MEDICO";
            cmbPlan.DisplayMember = "DESCRIPCION";
            
            cmbPlan.DataSource = new Query("SELECT ID_PLAN_MEDICO,DESCRIPCION FROM TERCER_IMPACTO.PLAN_MEDICO").ObtenerDataTable();
            cmbPlan.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cmbSexoLoad()
        {
            cmbSexo.Items.Add("M");
            cmbSexo.Items.Add("F");
            cmbSexo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cmbEstadoLoad()
        {
            cmbEstado.Items.Add("Soltero/a");
            cmbEstado.Items.Add("Casado/a");
            cmbEstado.Items.Add("Viudo/a");
            cmbEstado.Items.Add("Concubinato");
            cmbEstado.Items.Add("Divorciado/a");
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btn_Alta_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(nombreTxt.Text) || string.IsNullOrEmpty(apellidoTxt.Text) ||
                string.IsNullOrEmpty(tipoDocTxt.Text) || string.IsNullOrEmpty(nroDocTxt.Text) ||
                string.IsNullOrEmpty(direccionTxt.Text) || string.IsNullOrEmpty(telTxt.Text) ||
                string.IsNullOrEmpty(mailTxt.Text) || string.IsNullOrEmpty(cmbEstado.Text) ||
                string.IsNullOrEmpty(cmbSexo.Text) || cmbPlan.SelectedItem == null ||string.IsNullOrEmpty(cmbPlan.Text))
            {
                MessageBox.Show("Complete todos los campos por favor.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!nroDocTxt.Text.All(Char.IsDigit) || !telTxt.Text.All(Char.IsDigit))
            {
                MessageBox.Show("El nro. de documento y el telefono deben ser numéricos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            
            Query rand = new Query("SELECT convert(numeric(18,0),RAND()*9999999999999999)");
            random =(decimal) rand.ObtenerUnicoCampo();
            Query existe = new Query("SELECT TERCER_IMPACTO.NRO_UTILIZADO('" + random.ToString() + "')");
            bool existeNro = (bool)existe.ObtenerUnicoCampo();

            while (existeNro)
            {
                rand = new Query("SELECT convert(numeric(18,0),RAND()*9999999999999999)");
                random = (decimal)rand.ObtenerUnicoCampo();
                existe = new Query("SELECT TERCER_IMPACTO.NRO_UTILIZADO('" + random.ToString() + "')");
                existeNro = (bool)existe.ObtenerUnicoCampo();
            }

            //MessageBox.Show("El nro elegido es "+random.ToString(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string nombre = nombreTxt.Text;
            string apellido = apellidoTxt.Text;
            string tipoDoc = tipoDocTxt.Text;
            string nroDoc = nroDocTxt.Text;
            string direccion = direccionTxt.Text;
            string tel = telTxt.Text;
            string mail = mailTxt.Text;
            string estado = cmbEstado.Text;
            string sexo = cmbSexo.Text;
            //string id_plan = cmbPlan.SelectedItem.ToString();
            string cant_hijos=numericUpDown1.Value.ToString();
            random=random*100+1;
            string id=random.ToString();
            string format = "yyyy-MM-dd HH:mm:ss";

            decimal id_plan = (decimal)new Query("SELECT TOP 1 ID_PLAN_MEDICO FROM TERCER_IMPACTO.PLAN_MEDICO WHERE DESCRIPCION='" + cmbPlan.Text + "'").ObtenerUnicoCampo();

      
            new Query("SET IDENTITY_INSERT TERCER_IMPACTO.AFILIADO ON; INSERT INTO TERCER_IMPACTO.AFILIADO (ID_AFILIADO,NOMBRE,APELLIDO,TIPO_DOC,NRO_DOC,DIRECCION,TELEFONO,"
                + "MAIL,FECHA_NAC,SEXO,ESTADO_CIVIL,CANT_HIJOS,ID_PLAN_MEDICO,HABILITADO) VALUES ('" + id + "','" + nombre + "','" + apellido + "','" +
                tipoDoc + "','" + nroDoc + "','" + direccion + "','" + tel + "','" + mail + "','" + dateTimePicker1.Value.ToString(format) + "','" + sexo + "','"
                + estado + "','" + cant_hijos + "','" + id_plan.ToString() + "','1'); SET IDENTITY_INSERT TERCER_IMPACTO.AFILIADO OFF; ").Ejecutar();


             MessageBox.Show("Se agregó el afiliado correctamente. El id es "+id+".Agregue un familiar o vuelva." , "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

             nombreTxt.Text="";
             apellidoTxt.Text="";
             tipoDocTxt.Text="";
             nroDocTxt.Text="";
             direccionTxt.Text="";
             telTxt.Text="";
             mailTxt.Text="";
             cmbEstado.Text="";
             cmbSexo.Text="";
             cmbPlan.SelectedItem = null;
             cmbEstado.SelectedItem = null;
             cmbSexo.SelectedItem = null;
             numericUpDown1.Value = 0;
          

             AltaFamiliar frm = new AltaFamiliar(random,id_plan);
             frm.ShowDialog();
        }
    }
}
