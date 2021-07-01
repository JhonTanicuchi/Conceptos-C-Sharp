using System;
using System.Collections;

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


            Nodo raiz1 = new Nodo()
            {
                Valor = "a",
                Hijos =
                {
                    new Nodo
                    {
                        Valor = "p1",
                        Hijos =
                        {
                            new Nodo
                            {
                                Valor = "h1"
                            },
                            new Nodo
                            {
                                Valor = "h2",
                                Hijos =
                                {
                                    new Nodo
                                    {
                                        Valor = "h1"
                                    },
                                    new Nodo
                                    {
                                        Valor = "h2"
                                    }
                                }
                            }
                        }
                    },
                    new Nodo
                    {
                        Valor = "p2"
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

            Console.WriteLine($"Número de hojas: {manejadorArbol.NumeroHojas(raiz1)}");
            Console.WriteLine($"Número de nodos: {manejadorArbol.NumeroNodos(raiz1)}");
            Console.WriteLine($"Número de niveles: {manejadorArbol.NumeroNiveles(raiz1)}");

            //NAVEGACION HORIZONTAL

            Console.WriteLine(manejadorArbol.NavegacionHorizontal(raiz, "3"));


            //Queue queue = new Queue();
            //queue.Enqueue(new Nodo());
            //Nodo nodo = (Nodo)queue.Dequeue(); //Coloca Atras
            //Nodo nodo1 = (Nodo)queue.Peek(); // Saca Adelante

            //1 7 15
            //7 15
        }
    }
}
