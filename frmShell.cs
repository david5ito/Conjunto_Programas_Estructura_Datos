﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Conjunto_Programas_Estructura_Datos
{
    public partial class frmShell : Form
    {
        public frmShell()
        {
            InitializeComponent();
        }

        Random r = new Random();
        int[] arreglo;
        int tamaño;
        int minimo;
        int maximo;
        Stopwatch stopwatch = new Stopwatch();

        //boton regresar al menu
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();

            this.Close();
            menu.Show();
        }

        public void OrdenarArreglo(int[] arreglo)
        {
            stopwatch.Start();
            int salto = 0;
            int sw = 0;
            int auxiliar = 0;
            int e = 0;
            int pasadas = 0;
            int comparaciones = 0;
            int intercambios = 0;
            salto = arreglo.Length / 2;
            while (salto > 0)
            {

                sw = 1;
                while (sw != 0)
                {
                    sw = 0;
                    e = 1;
                    while (e <= (arreglo.Length - salto))
                    {

                        if (arreglo[e - 1] > arreglo[(e - 1) + salto])
                        {
                            auxiliar = arreglo[(e - 1) + salto];
                            arreglo[(e - 1) + salto] = arreglo[e - 1];
                            arreglo[e - 1] = auxiliar;
                            sw = 1;
                            comparaciones++;
                        }
                        e++;
                        intercambios++;
                    }
                    pasadas++;
                }
                salto = salto / 2;

            }

            stopwatch.Stop();
            string time = stopwatch.Elapsed.TotalMilliseconds + " ms";
            lblComparaciones.Text = comparaciones + "";
            lblIntercambios.Text = intercambios + "";
            lblIteraciones.Text = pasadas + "";
            lblTiempo.Text = time;
        }

        public void CrearArreglo(int tamaño, int minimo, int maximo)
        {
            arreglo = new int[tamaño];
            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = r.Next(minimo, maximo);
            }
        }

        public string ImprimirA(int[] arreglo)
        {
            string colaString = "";
            colaString += arreglo[0];
            for (int i = arreglo.Length; i > 0; i--)
            {
                colaString += "," + arreglo[i - 1];
            }
            return colaString;
        }

        public string ImprimirArreglo(int[] arreglo)
        {
            string colaString = "";
            colaString += arreglo[0];
            for (int i = 0; i < arreglo.Length - 1; i++)
            {
                colaString += "," + arreglo[i + 1];
            }
            return colaString;
        }

        private void btnAleatorio_Click(object sender, EventArgs e)
        {
            tamaño = r.Next(3, 20);
            minimo = r.Next(0, 5);
            maximo = r.Next(minimo, 25);
            CrearArreglo(tamaño, minimo, maximo);
            lblOriginal.Text = ImprimirArreglo(arreglo);
            OrdenarArreglo(arreglo);
            lblOrdenado.Text = ImprimirArreglo(arreglo);
            lblMayorMenor.Text = ImprimirA(arreglo);
            txtMax.Clear();
            txtMin.Clear();
            txtTamaño.Clear();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                maximo = int.Parse(txtMax.Text);
                minimo = int.Parse(txtMin.Text);
                tamaño = int.Parse(txtTamaño.Text);
                if (minimo < 0)
                {
                    MessageBox.Show("El minimo no puede ser menor que 0");
                    return;
                }
                if (tamaño < 0)
                {
                    MessageBox.Show("El tamaño no puede ser un numero negativo");
                    return;
                }
                if (maximo <= minimo)
                {
                    MessageBox.Show("El maximo debe de ser mayor que el minimo");
                    return;
                }
                txtMax.Clear();
                txtMin.Clear();
                txtTamaño.Clear();
                CrearArreglo(tamaño, minimo, maximo);
                lblOriginal.Text = ImprimirArreglo(arreglo);
                OrdenarArreglo(arreglo);
                lblOrdenado.Text = ImprimirArreglo(arreglo);
                lblMayorMenor.Text = ImprimirA(arreglo);

            }
            catch
            {
                MessageBox.Show("Introduza datos validos");
                txtMax.Clear();
                txtMin.Clear();
                txtTamaño.Clear();
            }
        }
    }
}
