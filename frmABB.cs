using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Conjunto_Programas_Estructura_Datos
{
    public partial class frmABB : Form
    {
        public frmABB()
        {
            InitializeComponent();
        }

        ABB arbol;


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            tbInorden.Text = arbol.Inorden();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbInsertar.Text) == false)
            {
                //arbol.Eliminar(tbInsertar.Text);

                tbInorden.Text = arbol.Inorden();
                tbPreorden.Text = arbol.Preorden();
                tbPostorden.Text = arbol.Postorden();

                string ruta = arbol.Graficar();

                System.Threading.Thread.Sleep(1000);

                FileStream file = new FileStream(ruta, FileMode.Open);
                Image img = Image.FromStream(file);
                pictureBox1.Image = img;
                file.Close();
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            arbol.limpiar();

            tbInorden.Text = arbol.Inorden();
            tbPreorden.Text = arbol.Preorden();
            tbPostorden.Text = arbol.Postorden();

            string ruta = arbol.Graficar();

            System.Threading.Thread.Sleep(1000);

            FileStream file = new FileStream(ruta, FileMode.Open);
            Image img = Image.FromStream(file);
            pictureBox1.Image = img;
            file.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbInsertar.Text) == false)
            {
                int[] datos = new int[int.Parse(tbInsertar.Text)];
                Random r = new Random();
                for (int i = 0; i < datos.Length; i++)
                {
                    datos[i] = r.Next(0, 10);
                }
                double tiempoInicial = double.Parse(DateTime.Now.Ticks.ToString());
                for (int i = 0; i < datos.Length; i++)
                {
                    arbol.Insertar(datos[i]);
                }
                double tiempoFinal = double.Parse(DateTime.Now.Ticks.ToString());

                tbInorden.Text = arbol.Inorden();
                tbPreorden.Text = arbol.Preorden();
                tbPostorden.Text = arbol.Postorden();

                string ruta = arbol.Graficar();

                System.Threading.Thread.Sleep(1000);
                FileStream file = new FileStream(ruta, FileMode.Open);
                Image img = Image.FromStream(file);
                pictureBox1.Image = img;
                file.Close();
                MessageBox.Show("El tiempo total en milisegundos fue: " + ((tiempoFinal - tiempoInicial) / 10000));
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
