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
    public partial class AltaFamiliar : Form
    {
        private decimal random;
        private decimal id_plan;
        private int menor_a_diez;

        public AltaFamiliar()
        {
            InitializeComponent();
        }

        public AltaFamiliar(decimal random, decimal id_plan)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.random = random+1;
            this.id_plan = id_plan;
            menor_a_diez = 2;
        }

        private void AltaFamiliar_Load(object sender, EventArgs e)
        {
            cmbSexoLoad();
            cmbEstadoLoad();
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

        private void btnAltaFamiliar_Click(object sender, EventArgs e)
        {
            if (menor_a_diez >= 10)
            {
                MessageBox.Show("No se pueden agregar más de 9 familiares.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            if (string.IsNullOrEmpty(nombreTxt.Text) || string.IsNullOrEmpty(apellidoTxt.Text) ||
                string.IsNullOrEmpty(tipoDocTxt.Text) || string.IsNullOrEmpty(nroDocTxt.Text) ||
                string.IsNullOrEmpty(direccionTxt.Text) || string.IsNullOrEmpty(telTxt.Text) ||
                string.IsNullOrEmpty(mailTxt.Text) || string.IsNullOrEmpty(cmbEstado.Text) ||
                string.IsNullOrEmpty(cmbSexo.Text) )
            {
                MessageBox.Show("Complete todos los campos por favor.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!nroDocTxt.Text.All(Char.IsDigit) || !telTxt.Text.All(Char.IsDigit))
            {
                MessageBox.Show("El nro. de documento y el telefono deben ser numéricos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

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
            string cant_hijos = cantHijos.Value.ToString();
            string id = random.ToString();
            
            string format = "yyyy-MM-dd hh:mm:ss";

            new Query("SET IDENTITY_INSERT TERCER_IMPACTO.AFILIADO ON; INSERT INTO TERCER_IMPACTO.AFILIADO (ID_AFILIADO,NOMBRE,APELLIDO,TIPO_DOC,NRO_DOC,DIRECCION,TELEFONO,"
                + "MAIL,FECHA_NAC,SEXO,ESTADO_CIVIL,CANT_HIJOS,ID_PLAN_MEDICO,HABILITADO) VALUES ('" + id + "','" + nombre + "','" + apellido + "','" +
                tipoDoc + "','" + nroDoc + "','" + direccion + "','" + tel + "','" + mail + "','" + fechaNacPicker.Value.ToString(format) + "','" + sexo + "','"
                + estado + "','" + cant_hijos + "','" + id_plan.ToString() + "','1'); SET IDENTITY_INSERT TERCER_IMPACTO.AFILIADO OFF; ").Ejecutar();


            MessageBox.Show("Se agregó el afiliado correctamente. El id es " + id + ".Agregue otro familiar o vuelva.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            random = random + 1;
            menor_a_diez++;
            nombreTxt.Text = "";
            apellidoTxt.Text = "";
            tipoDocTxt.Text = "";
            nroDocTxt.Text = "";
            direccionTxt.Text = "";
            telTxt.Text = "";
            mailTxt.Text = "";
            cmbEstado.Text = "";
            cmbSexo.Text = "";
            cmbEstado.SelectedItem = null;
            cmbSexo.SelectedItem = null;
            cantHijos.Value = 0;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
