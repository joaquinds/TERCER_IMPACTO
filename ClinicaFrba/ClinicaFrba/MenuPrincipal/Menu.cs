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
    public partial class Menus : Form
    {
        private bool abmRolVisible;
        private bool agendaVisible;
        private bool abmafiliadoVisible;
        private bool abmPedirTurnoVisible;
        private bool abmRegistrarVisible;
        private bool btnComprarVisible;


        public Menus()
        {
            abmRolVisible=false;
            agendaVisible = false;
            abmafiliadoVisible = false;
            abmPedirTurnoVisible = false;
            abmRegistrarVisible = false;
            btnComprarVisible = false;
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
            DataTable funcionalidades = new Query("SELECT DESCRIPCION FROM TERCER_IMPACTO.FUNCIONALIDAD JOIN " +
                "TERCER_IMPACTO.ROL_FUNCIONALIDAD ON ID_FUNC=FUNC_ID WHERE ROL_ID='" + Globals.id_rol + "'").ObtenerDataTable();

            foreach (DataRow fila in funcionalidades.Rows)
            {
                if ((string)fila["DESCRIPCION"] == "ABM ROL")  //asi para cada funcionalidad
                    abmRolVisible = true;

                if ((string)fila["DESCRIPCION"] == "REGISTRAR AGENDA")
                    agendaVisible = true;

                if ((string)fila["DESCRIPCION"] == "ABM AFILIADO")
                    abmafiliadoVisible = true;

                if ((string)fila["DESCRIPCION"] == "PEDIR TURNO")
                    abmPedirTurnoVisible = true;

                if ((string)fila["DESCRIPCION"] == "REGISTRAR LLEGADA")
                    abmRegistrarVisible = true;

                if ((string)fila["DESCRIPCION"] == "COMPRAR BONOS")
                    btnComprarVisible = true;


            }

            btnABMRol.Visible = abmRolVisible;
            btnAgenda.Visible = agendaVisible;
            btnafiliado.Visible = abmafiliadoVisible;
            btnPTurno.Visible = abmPedirTurnoVisible;
            btnRegistrar.Visible = abmRegistrarVisible;
            button1.Visible = btnComprarVisible;
        }

        private void btnABMRol_Click(object sender, EventArgs e)
        {
            AbmRol.ABMrol abm = new AbmRol.ABMrol();
            abm.ShowDialog();
        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            Registrar_Agenda_Medico.Agenda frm = new Registrar_Agenda_Medico.Agenda();
            frm.ShowDialog();
        }
  
      

        private void btnPTurno_Click_1(object sender, EventArgs e)
        {
            Pedir_Turno.Pedir_Turno abmPTurno = new Pedir_Turno.Pedir_Turno();
            abmPTurno.ShowDialog();
        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            Registro_Llegada.Registro_Llegada abmRegistro = new Registro_Llegada.Registro_Llegada();
            abmRegistro.ShowDialog();
        }

        private void btnafiliado_Click_1(object sender, EventArgs e)
        {
            Abm_Afiliado.ABMafiliado frm = new Abm_Afiliado.ABMafiliado();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Compra_Bono.Compra frm = new Compra_Bono.Compra();
            frm.ShowDialog();

        }


    }
}
