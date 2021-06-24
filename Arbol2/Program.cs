using System;
using System.Collections.Generic;

namespace Arbol2
{
    class Program
    {
        static void Main(string[] args)
        {
            var raiz = new Nodo
            {
                Valor = "*",
                Izquierdo = new Nodo()
                {
                    Valor = "+",
                    Izquierdo = new Nodo("5"),
                    Derecho = new Nodo("3")
                },

                Derecho = new Nodo()
                {
                    Valor = "+",
                    Izquierdo = new Nodo("7"),
                    Derecho = new Nodo("4")
                }
            };
           

            raiz.OperacionNodo(raiz);         
        }
    }
}