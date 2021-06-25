using System;
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
    }
}
