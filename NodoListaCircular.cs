using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conjunto_Programas_Estructura_Datos
{
    class NodoListaCircular
    {
        private int dato;//Los nodos almacenaran un valor entero, para este ejemplo sera datos
        private NodoListaCircular siguiente; //Declaramos el puntero al siguiente nodo

        public int Dato //Ahora pasamos al encapsulamiento, lo cual permite obtener y establecer los valores para los nodos
        {
            get { return dato; }
            set { dato = value; }
        }
        public NodoListaCircular Siguiente //puntero, referencia
        {
            get { return siguiente; }
            set { siguiente = value; }
        }

        public NodoListaCircular()
        {
            dato = 0;
            siguiente = this;
        }

        public NodoListaCircular(int dato, NodoListaCircular siguiente)
        {
            this.dato = dato;
            this.siguiente = siguiente;
        }

        public override string ToString()
        {
            return dato + "";
        }
    }
}
