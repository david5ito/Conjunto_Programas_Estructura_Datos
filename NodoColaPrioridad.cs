using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conjunto_Programas_Estructura_Datos
{
    class NodoColaPrioridad
    {
        private string dato;
        private NodoColaPrioridad siguiente;
        private int prioridad;
        public string Dato
        {
            get { return dato; }
            set { dato = value; }
        }
        public NodoColaPrioridad Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
        public int Prioridad
        {
            get { return prioridad; }
            set { prioridad = value; }
        }
        public NodoColaPrioridad()
        {
            dato = "";
            prioridad = 0;
            siguiente = null;
        }
        public override string ToString()
        {
            return dato;
        }
    }
}
