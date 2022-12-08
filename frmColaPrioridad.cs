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
    public partial class frmColaPrioridad : Form
    {
        public frmColaPrioridad()
        {
            InitializeComponent();
        }
        Cola prio = new Cola();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //El metodo Falla
            NodoColaPrioridad nuevo = new NodoColaPrioridad();
            nuevo.Dato = txtDato.Text;
            nuevo.Prioridad = int.Parse(txtPri.Text);
            //prio.Agregar(nuevo);
            txtDato.Text = "";
            txtPri.Text = "";
            txtCola.Text = prio.ToString();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            prio.Eliminar();
            txtCola.Text = prio.ToString();
        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            this.Close();
            menu.Show();
        }

        private void frmColaPrioridad_Load(object sender, EventArgs e)
        {
            //grbFirst.Visible = true;
            //grbSec.Visible = false;
        }
    }
}
