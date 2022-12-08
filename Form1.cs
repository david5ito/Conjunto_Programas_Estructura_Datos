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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnMezcla_Click(object sender, EventArgs e)
        {
            FrmMezcla mezcla = new FrmMezcla();

            this.Hide();
            mezcla.Show();
        }

        private void btnSelection_Click(object sender, EventArgs e)
        {
            FrmSelection selection = new FrmSelection();

            this.Hide();
            selection.Show();
        }

        private void btnCounting_Click(object sender, EventArgs e)
        {
            frmCounting counting = new frmCounting();

            this.Hide();
            counting.Show();
        }

        private void btnQuick_Click(object sender, EventArgs e)
        {
            frmQuick quick = new frmQuick();

            this.Hide();
            quick.Show();
        }

        private void btnBurbuja_Click(object sender, EventArgs e)
        {
            frmBubble bubble = new frmBubble();

            this.Hide();
            bubble.Show();
        }

        private void btnABB_Click(object sender, EventArgs e)
        {
            frmABB Abb = new frmABB();

            this.Hide();
            Abb.Show();
        }

        private void btnShellSort_Click(object sender, EventArgs e)
        {
            frmShell shell = new frmShell();

            this.Hide();
            shell.Show();
        }

        private void btnRadix_Click(object sender, EventArgs e)
        {
            frmRadix radix = new frmRadix();

            this.Hide();
            radix.Show();
        }

        private void btnInsertionSort_Click(object sender, EventArgs e)
        {
            frmInsertion insertion = new frmInsertion();

            this.Hide();
            insertion.Show();
        }

        private void btnGrafos_Click(object sender, EventArgs e)
        {
            frmGrafo grafo = new frmGrafo();

            this.Hide();
            grafo.Show();
        }

        private void btnLCircularSimple_Click(object sender, EventArgs e)
        {
            frmListaCircularSimple LCS = new frmListaCircularSimple();

            this.Hide();
            LCS.Show();
        }

        private void btnLCircularDinamica_Click(object sender, EventArgs e)
        {
            frmColaCircularDinamica form = new frmColaCircularDinamica();

            this.Hide();
            form.Show();
        }

        private void btnLDoble_Click(object sender, EventArgs e)
        {
            frmListaDoble form = new frmListaDoble();
            this.Hide();
            form.Show();
        }

        private void btnBicolaDinamica_Click(object sender, EventArgs e)
        {
            frmBicola form = new frmBicola();
            this.Hide();
            form.Show();
        }

        private void btnColaPrioridad_Click(object sender, EventArgs e)
        {
            frmColaPrioridad form = new frmColaPrioridad();
            this.Hide();
            form.Show();
        }

        private void btnColaDinamica_Click(object sender, EventArgs e)
        {
            frmColaDinamica form = new frmColaDinamica();
            this.Hide();
            form.Show();
        }
    }
}
