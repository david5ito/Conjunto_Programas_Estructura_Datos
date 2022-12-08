using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conjunto_Programas_Estructura_Datos
{
    class NodoColaDinamica
    {
        private string dato;
        private NodoColaDinamica siguiente;
        public string Dato
        {
            get { return dato; }
            set { dato = value; }
        }
        public NodoColaDinamica Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
        public NodoColaDinamica()
        {
            dato = null;
            siguiente = null;
        }

        public NodoColaDinamica(string dato, NodoColaDinamica siguiente)
        {
            this.dato = dato;
            this.siguiente = siguiente;
        }

        public override string ToString()
        {
            return dato;
        }
    }
}
