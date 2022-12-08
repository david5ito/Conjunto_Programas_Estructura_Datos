﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conjunto_Programas_Estructura_Datos
{
    public partial class frmColaDinamica : Form
    {
        public frmColaDinamica()
        {
            InitializeComponent();
        }

        ColaDinamica colaDinamica = new ColaDinamica();
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            this.Close();
            menu.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            colaDinamica.Agregar(txtDato.Text);
            txtCola.Text = colaDinamica.ToString();
            txtDato.Clear();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            colaDinamica.Eliminar();
            txtCola.Text = colaDinamica.ToString();
        }
    }
}
