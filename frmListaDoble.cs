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
    public partial class frmListaDoble : Form
    {
        public frmListaDoble()
        {
            InitializeComponent();
        }

        MiListaDoble lista = new MiListaDoble();

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            NodoListaDoble n = new NodoListaDoble();
            n.Dato = txtDato.Text;
            lista.Insertar(n.Dato);
            MessageBox.Show(txtDato + lista.ToString());
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            //Nodo h = head;
            lista.head = lista.primero;
            while (lista.head != null)
            {
                //MessageBox.Show(lista.head.Dato);
                lista.head = lista.head.Siguiente;
                lbxDato.Items.Add(Convert.ToString(lista.head.Dato));
            }
            lista.head = lista.ultimo;
            while (lista.head != null)
            {
                //MessageBox.Show(lista.head.Dato);
                lista.head = lista.head.Anterior;
                lbxDato.Items.Add(Convert.ToString(lista.head.Dato));
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            this.Close();
            menu.Show();
        }
    }
}
