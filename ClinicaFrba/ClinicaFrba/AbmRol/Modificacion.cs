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
    public partial class Modificacion : Form
    {
        private decimal id_rol;
        public Modificacion()
        {
            InitializeComponent();
            id_rol=-1;
        }

        private void Modificacion_Load(object sender, EventArgs e)
        {
            .llenarRoles();
            btnHabilitar.Visible = false;
        }

        private void llenarRoles()
        {
            comboRoles.DataSource = new Query("SELECT DISTINCT NOMBRE FROM TERCER_IMPACTO.ROL").ObtenerDataTable();
            comboRoles.ValueMember = "NOMBRE";
            comboRoles.DropDownStyle = ComboBoxStyle.DropDownList;


        }

        private void btnElegir_Click(object sender, EventArgs e)
        {   if (string.IsNullOrEmpty(comboRoles.Text)){
                MessageBox.Show("Seleccione un Rol", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            id_rol=(decimal)new Query("SELECT TOP 1 ID_ROL FROM TERCER_IMPACTO.ROL WHERE NOMBRE='"+comboRoles.Text+"'").ObtenerUnicoCampo();
            bool habilitado = (bool)new Query("SELECT TOP 1 HABILITADO FROM TERCER_IMPACTO.ROL WHERE NOMBRE='" + comboRoles.Text + "'").ObtenerUnicoCampo();
            llenarComboFunc();

            btnHabilitar.Visible = !habilitado;
            //MessageBox.Show("Rol seleccionado correctamente,prosiga. ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
        }

        private void llenarComboFunc()
        {
            comboFuncRol.DataSource = new Query("SELECT DISTINCT DESCRIPCION FROM TERCER_IMPACTO.FUNCIONALIDAD " +
            "JOIN TERCER_IMPACTO.ROL_FUNCIONALIDAD ON FUNC_ID=ID_FUNC WHERE HABILITADO=1 AND ROL_ID='" + id_rol + "'").ObtenerDataTable();
            comboFuncRol.ValueMember = "DESCRIPCION";
            comboFuncRol.SelectedItem = null;
            comboFuncRol.DropDownStyle = ComboBoxStyle.DropDownList;

            comboFuncNoRol.DataSource = new Query("SELECT DISTINCT DESCRIPCION FROM TERCER_IMPACTO.FUNCIONALIDAD " +
                "JOIN TERCER_IMPACTO.ROL_FUNCIONALIDAD ON FUNC_ID=ID_FUNC " +
                " WHERE DESCRIPCION NOT IN (SELECT DESCRIPCION FROM TERCER_IMPACTO.FUNCIONALIDAD JOIN " +
                "TERCER_IMPACTO.ROL_FUNCIONALIDAD ON FUNC_ID=ID_FUNC WHERE HABILITADO=1 AND ROL_ID='" + id_rol + "')").ObtenerDataTable();
            comboFuncNoRol.ValueMember = "DESCRIPCION";
            comboFuncNoRol.SelectedItem = null;
            comboFuncNoRol.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {   
            string descripcion=comboFuncRol.Text;

            if (string.IsNullOrEmpty(descripcion) || id_rol==-1){
                MessageBox.Show("Seleccione un rol y funcionalidad.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            new Query("UPDATE TERCER_IMPACTO.ROL_FUNCIONALIDAD SET HABILITADO=0 WHERE ROL_ID='"+id_rol+"' "+
                "AND FUNC_ID=(SELECT ID_FUNC FROM TERCER_IMPACTO.FUNCIONALIDAD WHERE DESCRIPCION='"+descripcion+"')").Ejecutar();

            MessageBox.Show("Funcionalidad removida con exito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            llenarComboFunc();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string descripcion = comboFuncNoRol.Text;
            if (string.IsNullOrEmpty(descripcion) || id_rol == -1)
            {
                MessageBox.Show("Seleccione un rol y funcionalidad.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Query qr=new Query("TERCER_IMPACTO.AGREGAR_FUNCIONALIDAD");
            qr.addParameter("@DESCRIPCION", descripcion);
            qr.addParameter("@ID_ROL", id_rol.ToString());
            qr.Ejecutar();

            MessageBox.Show("Funcionalidad agregada con exito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            llenarComboFunc();
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboRoles.Text) || id_rol == -1)
            {
                MessageBox.Show("Seleccione un rol.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            new Query("UPDATE TERCER_IMPACTO.ROL SET HABILITADO=1 WHERE ID_ROL='" + id_rol + "'").Ejecutar();
            MessageBox.Show("Rol habilitado con exito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Modificacion_Load(sender, e);

        }

        
    }
}
