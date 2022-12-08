using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conjunto_Programas_Estructura_Datos
{
    class MiListaDoble
    {
        public string dato;
        public NodoListaDoble primero;
        public NodoListaDoble ultimo;
        public NodoListaDoble head;

        public String Dato
        {
            get { return dato; }
            set { dato = value; }
        }
        public NodoListaDoble Primero
        {
            get { return primero; }
            set { primero = value; }
        }
        public NodoListaDoble Ultimo
        {
            get { return ultimo; }
            set { ultimo = value; }
        }
        public NodoListaDoble Head
        {
            get { return head; }
            set { head = value; }
        }
        public MiListaDoble()
        {
            dato = "";
            primero = null;
            ultimo = null;
            head = null;
        }
        public void Insertar(string dato)
        {
            NodoListaDoble h = head;
            if (head == null)
            {
                NodoListaDoble n = new NodoListaDoble();
                primero = n;
                ultimo = primero;
            }
            else
            {
                NodoListaDoble n = new NodoListaDoble();
                ultimo.Siguiente = n;
                n.Anterior = ultimo;
                ultimo = n;
            }
        }
        public override string ToString()
        {
            NodoListaDoble h = head;
            if (head != null)
            {
                while (h.Siguiente != null)
                {
                    dato += h.ToString();
                }
            }
            return dato;
        }
        public void Borrar(string dato)
        {
            if (head != null)
            {
                if (head.Dato == dato)
                {
                    head = head.Siguiente;
                    return;
                }
                NodoListaDoble h = head;
                while (h.Siguiente != null)
                {
                    if (h.Siguiente.Dato == dato)
                    {
                        h.Siguiente = h.Siguiente.Siguiente;
                        return;
                    }
                    h = h.Siguiente;
                }
            }
        }
        //public bool Buscar(string dato)
        //{
        //    Nodo h = head;
        //    if (dato == head.Dato)
        //    {
        //        return true;
        //    }

        //    if (dato = h.Siguiente)
        //    {
        //        return true;
        //    }
        //    if (dato = h.Anterior)
        //    {
        //        return true;
        //    }
        //    return false;
        //}

    }
}
