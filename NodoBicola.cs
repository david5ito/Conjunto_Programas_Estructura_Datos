using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conjunto_Programas_Estructura_Datos
{
    class NodoBicola
    {
        private string dato;
        private NodoBicola siguiente;
        private NodoBicola anterior;
        public string Dato
        {
            get { return dato; }
            set { dato = value; }
        }
        public NodoBicola Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
        public NodoBicola Anterior
        {
            get { return anterior; }
            set { anterior = value; }
        }
        public NodoBicola()
        {
            dato = "";
            siguiente = null;
            anterior = null;
        }
        public override string ToString()
        {
            return dato;
        }
    }
}
