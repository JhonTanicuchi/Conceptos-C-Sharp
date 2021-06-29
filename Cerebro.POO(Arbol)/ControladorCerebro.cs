using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Cerebro.Entidades;


namespace Cerebro.POO_Arbol_
{
    class ControladorCerebro
    {
        /*
        internal int NumeroNodos(Nodo nodo)
        {
            if (SoyHoja(nodo))
                return 1;
            int totalHojas = 0;
            foreach (Nodo hijoActual in nodo.Hijos)
            {
                totalHojas += NumeroHojas(hijoActual);
            }
        }


        internal int NumeroNodos(Nodo nodo)
        {
            if (SoyHoja(nodo))
                return 1;
            int totalNodos = 0;
            foreach (Nodo nodoActual in nodo.Hijos)
            {
                totalNodos += NumeroNodos(nodoActual);
            }
            return totalNodos + 1;
        }


        internal int NumeroNiveles(Nodo nodo, int nivel)
        {
            if (nodo == null)
                return 0;

            if (SoyHoja(nodo))
                return ++nivel;

            foreach (var nodoActual in nodo.Hijos)
            {
                var nivelActual = NumeroNiveles(nodoActual, nivel);
                if (nivel < nivelActual)
                    nivel = nivelActual;
            }
            return ++nivel;
        }


        private bool SoyHoja(Nodo nodo)
        {
            return !nodo.Hijos.Any();
        }
        */
    }
}
