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
                    Derecho = new Nodo("5")                    
                }
            };

            var suma1 = int.Parse(raiz.Izquierdo.Izquierdo.Valor) + int.Parse(raiz.Izquierdo.Derecho.Valor);
            var suma2 = int.Parse(raiz.Derecho.Izquierdo.Valor) + int.Parse(raiz.Derecho.Derecho.Valor);
            var multiplicacion = suma1 * suma2;
            Console.WriteLine(multiplicacion);
        }
    }
}