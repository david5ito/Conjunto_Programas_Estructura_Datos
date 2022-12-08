using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conjunto_Programas_Estructura_Datos
{
    class NodoListaDoble
    {
        private string dato;

        public string Dato
        {
            get { return dato; }
            set { dato = value; }
        }
        private NodoListaDoble siguiente;

        public NodoListaDoble Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
        private NodoListaDoble anterior;

        public NodoListaDoble Anterior
        {
            get { return anterior; }
            set { anterior = value; }
        }
        public NodoListaDoble()
        {
            dato = "";
            siguiente = null;
            anterior = null;
        }
        public NodoListaDoble(string dato, NodoListaDoble siguiente, NodoListaDoble anterior)
        {
            this.dato = dato;
            this.siguiente = siguiente;
            this.anterior = anterior;
        }
        public override string ToString()
        {
            return Dato.ToString();
        }
    }
}
