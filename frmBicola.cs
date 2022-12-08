using System;
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
    public partial class frmBicola : Form
    {
        public frmBicola()
        {
            InitializeComponent();
        }

        Bicola cola = new Bicola();

        private void btnAddH_Click(object sender, EventArgs e)
        {
            cola.AgregarFrente(txtDato.Text);
            txtDato.Clear();
            txtCola.Text = cola.ToString();
        }

        private void btnAddT_Click(object sender, EventArgs e)
        {
            cola.AgregarFinal(txtDato.Text);
            txtDato.Clear();
            txtCola.Text = cola.ToString();
        }

        private void btnDelH_Click(object sender, EventArgs e)
        {
            cola.EliminarFrente();
            txtCola.Text = cola.ToString();
        }

        private void btnDelT_Click(object sender, EventArgs e)
        {
            cola.EliminarFinal();
            txtCola.Text = cola.ToString();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            this.Close();
            menu.Show();
        }
    }
}
