﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantallas_de_Proyecto
{
    public partial class frmMenuBasesExternas : Form
    {
        public frmMenuBasesExternas()
        {
            InitializeComponent();
        }

        private void btnBasesExternas_Click(object sender, EventArgs e)
        {
            frmListasUsuarios frmLU = new frmListasUsuarios();
            frmLU.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmListaEmpresas frmLE = new frmListaEmpresas();
            frmLE.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmListaEmpresasADMIN frmLEA = new frmListaEmpresasADMIN();
            frmLEA.Show();
            this.Hide();
        }

        private void btnCancelarYSalir_Click(object sender, EventArgs e)
        {
            frmMenu frmM = new frmMenu();
            frmM.Show();
            this.Close();
        }
    }
}