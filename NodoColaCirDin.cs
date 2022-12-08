using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conjunto_Programas_Estructura_Datos
{
    class NodoColaCirDin
    {
        private string dato;
        private NodoColaCirDin siguiente;
        public string Dato
        {
            get { return dato; }
            set { dato = value; }
        }
        public NodoColaCirDin Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
        public NodoColaCirDin()
        {
            dato = null;
            siguiente = null;
        }
        public override string ToString()
        {
            return dato;
        }
    }
}
