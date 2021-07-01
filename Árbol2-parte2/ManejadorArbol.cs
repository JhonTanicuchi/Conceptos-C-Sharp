using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Árbol3
{
    class ManejadorArbol
    {
        //Método recursivo, porque se llama a si mismo
        internal string ImprimirArbolInfijo(Nodo nodo)
        {
            //Analiza el comportamiento de una hoja
            if (!nodo.Hijos.Any())
                return nodo.Valor;

            //Analizo cuando no soy hoja
           
            return $"({ImprimirArbolInfijo(nodo.Hijos[0])} {nodo.Valor} {ImprimirArbolInfijo(nodo.Hijos[1])})";
                               
        }

        //Método recursivo, porque se llama a si mismo
        internal string ImprimirArbolPrefijo(Nodo nodo)
        {
            //Analiza el comportamiento de una hoja
            if (!nodo.Hijos.Any())
                return nodo.Valor;

            //Analizo cuando no soy hoja

            return $"({nodo.Valor} {ImprimirArbolPrefijo(nodo.Hijos[0])} {ImprimirArbolPrefijo(nodo.Hijos[1])})";
        }

        //Método recursivo, porque se llama a si mismo
        internal string ImprimirArbolPotfijo(Nodo nodo)
        {
            //Analiza el comportamiento de una hoja
            if (!nodo.Hijos.Any())
                return nodo.Valor;

            //Analizo cuando no soy hoja

            return $"({ImprimirArbolPotfijo(nodo.Hijos[0])} {ImprimirArbolPotfijo(nodo.Hijos[1])} {nodo.Valor})";
        }

        internal string ImprimirArbol(Nodo nodo, Notacion notacion)
        {
            if (!nodo.Hijos.Any())
                return nodo.Valor;
            /*
            switch (notacion)
            {
                case Notacion.Infijo:
                    return $"({ImprimirArbol(nodo.Hijos[0], notacion)} {nodo.Valor} {ImprimirArbol(nodo.Hijos[1], notacion)})";
                case Notacion.Prefijo:
                    return $"({nodo.Valor} {ImprimirArbol(nodo.Hijos[0], notacion)} {ImprimirArbol(nodo.Hijos[1], notacion)})";
                case Notacion.Postfijo:
                    return $"({ImprimirArbol(nodo.Hijos[0], notacion)} {ImprimirArbol(nodo.Hijos[1], notacion)} {nodo.Valor})";
                default:
                    return "Tipo de notación no imprlementada";
            }
            */

            //Otra manera para simplificar codigo
            return notacion switch
            {
                Notacion.Infijo => $"({ImprimirArbol(nodo.Hijos[0], notacion)} {nodo.Valor} {ImprimirArbol(nodo.Hijos[1], notacion)})",
                Notacion.Prefijo => $"({nodo.Valor} {ImprimirArbol(nodo.Hijos[0], notacion)} {ImprimirArbol(nodo.Hijos[1], notacion)})",
                Notacion.Postfijo => $"({ImprimirArbol(nodo.Hijos[0], notacion)} {ImprimirArbol(nodo.Hijos[1], notacion)} {nodo.Valor})",
                _ => "Tipo de notación no imprlementada",
            };
        }

        internal int NumeroHojas(Nodo nodo)
        {
            if (SoyHoja(nodo))    
                return 1;

            int totalHojas = 0;
            foreach (var hijoActual in nodo.Hijos)
            {
                totalHojas += NumeroHojas(hijoActual);
            }
            return totalHojas;
        }

        internal int NumeroNodos(Nodo nodo)
        {
            if (SoyHoja(nodo))
                return 1;

            int totalNodos = 0;
            foreach (var nodoActual in nodo.Hijos)
            {
                totalNodos += NumeroNodos(nodoActual);
            }
            return totalNodos + 1;
        }

        internal int NumeroNiveles(Nodo nodo)
        {
            if (nodo == null)
                return 0;
            
            var nivel = 0;
            foreach (var nodoActual in nodo.Hijos)
            {
                var nivelActual = NumeroNiveles(nodoActual);
                if (nivel < nivelActual)
                    nivel = nivelActual;
            }
            return ++nivel;
        }

        private bool SoyHoja(Nodo nodo)
        {
            return !nodo.Hijos.Any();
        }


        public string NavegacionHorizontal(Nodo nodo, string valor) {
            Queue<Nodo> colaAuxiliar = new LinkedList<Nodo>();
            colaAuxiliar.Enqueue(new Nodo());          
            colaAuxiliar.add(nodo);

            while(colaAuxiliar.Count != 0) {
                nodo = colaAuxiliar.poll();
                Console.WriteLine("Valor del Nodo :" + nodo.Valor);
                if (nodo.Valor == valor)
                {
                    return nodo.Valor;
                }
                else
                {
                    colaAuxiliar.add(nodo.Hijos[0]);
                    colaAuxiliar.add(nodo.Hijos[1]);
                }
            }
            return "No existe";
        }
    }
}
