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
    public partial class frmListaCircularSimple : Form
    {
        public frmListaCircularSimple()
        {
            InitializeComponent();
            MiLista = new ListaCircular();
        }


        NodoListaCircular n;
        private ListaCircular MiLista;

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (MiLista == null)
            {
                MiLista = new ListaCircular();
            }
            try
            {
                if (!MiLista.BuscarDato(int.Parse(txtNodo.Text)))
                {
                    n = new NodoListaCircular();
                    n.Dato = int.Parse(txtNodo.Text);
                    MiLista.Agregar(n);
                    lblLista.Text = MiLista.ToString();
                    txtNodo.Clear();
                }
                else
                {
                    MessageBox.Show("El dato ya existe en la lista.");
                    txtNodo.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Ingresa un número válido.");
            }
        }

        private void btnEliminarNodo_Click(object sender, EventArgs e)
        {
            if (MiLista == null)
            {
                return;
            }
            try
            {
                int dato = int.Parse(txtEliminar.Text);

                if (!MiLista.BuscarDato(dato))
                {
                    MessageBox.Show("Dato no encontrado");
                    lblLista.Text = MiLista.ToString();
                    txtNodo.Clear();
                    return;
                }
                MiLista.Borrar(dato);
                lblLista.Text = MiLista.ToString();
                txtEliminar.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Introduzca un número válido.");
            }
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            if (MiLista == null)
            {
                return;
            }
            MessageBox.Show("Número de nodos en la lista:" + MiLista.ContarNodos());
        }

        private void btnVaciarLista_Click(object sender, EventArgs e)
        {
            MiLista = null;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();

            this.Close();
            menu.Show();
        }
    }
}
