﻿using System;
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
    public partial class ABMAfiliado : Form
    {
        public ABMAfiliado()
        {
            InitializeComponent();
        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            Alta frm = new Alta();
            frm.ShowDialog();
        }

        private void btn_baja_Click(object sender, EventArgs e)
        {
            Baja frm = new Baja();
            frm.ShowDialog();
        }

        private void btn_mod_Click(object sender, EventArgs e)
        {
            Modificacion frm = new Modificacion();
            frm.ShowDialog();
        }
    }
}
