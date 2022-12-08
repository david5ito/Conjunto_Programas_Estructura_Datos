using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conjunto_Programas_Estructura_Datos
{
    class ColaPrioridad
    {
        private NodoColaPrioridad[] prioridades;
        private int frente;
        private int final;
        public ColaPrioridad()
        {
            prioridades = null;
            frente = -1;
            final = -1;
        }
        public void CrearArreglo(int num)
        {
            prioridades = new NodoColaPrioridad[num];
        }
        public void Agregar(NodoColaPrioridad nuevo)
        {
            if (frente == -1)
            {
                frente = 0;
                final = 0;
                prioridades[0] = nuevo;
                return;
            }
            if (prioridades[nuevo.Prioridad] == null)
            {
                final = nuevo.Prioridad;
                prioridades[nuevo.Prioridad] = nuevo;
                return;
            }
            NodoColaPrioridad h = prioridades[nuevo.Prioridad];
            while (h.Siguiente != null)
            {
                h = h.Siguiente;
            }
            h.Siguiente = nuevo;
        }
        public void Eliminar()
        {
            if (frente == -1)
            {
                return;
            }
            if (frente == final)
            {
                if (prioridades[frente].Siguiente == null)
                {
                    prioridades[frente] = null;
                    frente = -1;
                    final = -1;
                }
                else
                {
                    prioridades[frente] = prioridades[frente].Siguiente;
                }
                return;
            }
            if (prioridades[frente].Siguiente != null)
            {
                prioridades[frente] = prioridades[frente].Siguiente;
                return;
            }
            if (prioridades[frente].Siguiente == null)
            {
                if (frente == prioridades.Length - 1)
                {
                    prioridades[frente] = null;
                    frente = 0;
                }
                else
                {
                    prioridades[frente] = null;
                    frente++;
                }
                return;
            }
        }
        public override string ToString()
        {
            string cadena = "";
            //if (frente != -1)
            //{

            //for (int i = frente; i != final + 1; i++)
            //{
            //    if (prioridades[i] == null)
            //    {
            //        return cadena += "";
            //    }
            //    cadena += prioridades[i].ToString();
            //    Nodo h = prioridades[i];
            //    if (h == null)
            //    {
            //        cadena += "";
            //    }
            //    else
            //    {
            //        while (h.Siguiente != null)
            //        {
            //            cadena += ", " + h.Siguiente.ToString();
            //            h = h.Siguiente;
            //        }
            //    }
            //    cadena += "\r\n";
            //    if(i == prioridades.Length - 1)
            //    {
            //        i = -1;
            //    }
            //}
            //    return cadena;
            //}
            //else
            //{
            //    return "Cadena vacía";
            //}
            if (frente != -1)
            {
                for (int i = frente; i < prioridades.Length; i++)
                {
                    if (prioridades[i] == null)
                    {
                        return cadena += "";
                    }
                    cadena += prioridades[i].ToString();
                    NodoColaPrioridad h = prioridades[i];
                    if (h == null)
                    {
                        cadena += "";
                    }
                    else
                    {
                        while (h.Siguiente != null)
                        {
                            cadena += ", " + h.Siguiente.ToString();
                            h = h.Siguiente;
                        }
                    }
                    cadena += "\r\n";
                }
                return cadena;
            }
            else
            {
                return "Cola vacía";
            }
        }
    }
}
