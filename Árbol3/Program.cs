using System;

namespace Árbol3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola!");
            Nodo raiz = new Nodo()
            {
                Valor = "*",
                Hijos =
                {
                    new Nodo
                    {
                        Valor = "+",
                        Hijos =
                        {
                            new Nodo
                            {
                                Valor = "8"
                            },
                            new Nodo
                            {
                                Valor = "5"
                            }
                        }
                    },
                    new Nodo
                    {
                        Valor = "-",
                        Hijos =
                        {
                            new Nodo
                            {
                                Valor = "7"
                            },
                            new Nodo
                            {
                                Valor = "4"
                            }
                        }
                    }
                }
            };

            //Resultado esperado
            //=> (8 + 5) * (7 - 4) = 39 notación infija
            //=> * (+ 8 5) (- 7 4) = 39 notación prefija
            //=> (8 5 +) (7 4 -) * = 39 notación postfijo

            //=> (8 + (5 * 7)) - 4 = 39 

            ManejadorArbol manejadorArbol = new ManejadorArbol();
            Console.WriteLine(manejadorArbol.ImprimirArbolInfijo(raiz));
            Console.WriteLine(manejadorArbol.ImprimirArbolPrefijo(raiz));
            Console.WriteLine(manejadorArbol.ImprimirArbolPotfijo(raiz));

            Console.WriteLine(manejadorArbol.ImprimirArbol(raiz, Notacion.Infijo));
            Console.WriteLine(manejadorArbol.ImprimirArbol(raiz, Notacion.Prefijo));
            Console.WriteLine(manejadorArbol.ImprimirArbol(raiz, Notacion.Postfijo));
        }
    }
}
