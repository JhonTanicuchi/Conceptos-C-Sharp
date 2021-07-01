using System;
using System.Collections.Generic;
using System.Threading;
using Cerebro.Entidades;

namespace Cerebro.POO_Arbol_
{
    class Program
    {
        static void Main(string[] args)
        {
            var cerebro = new CerebroHumano
            {
                Hemisferios = new List<Hemisferio>
                {
                    new Hemisferio
                    {
                        Nombre = "Hemisferio Izquierdo",
                        Zonas = new List<Zona>
                        {
                            new Zona
                            {
                                Nombre = "Zona Vizual"
                            },
                            new Zona
                            {
                                Nombre = "Zona Senzorial"

                            },
                            new Zona
                            {
                                Nombre = "Zona Motora"

                            },
                            new Zona
                            {
                                Nombre = "Zona Lenguaje"

                            },
                            new Zona
                            {
                                Nombre = "Zona Asociativa"                           
                            }
                        }
                    },
                    new Hemisferio
                    {
                        Nombre = "Hemisferio Derecho",
                        Zonas = new List<Zona>
                        {
                            new Zona
                            {
                                Nombre = "Zona Vizual"
                            },
                            new Zona
                            {
                                Nombre = "Zona Senzorial"

                            },
                            new Zona
                            {
                                Nombre = "Zona Motora"

                            },
                            new Zona
                            {
                                Nombre = "Zona Asociativa"

                            }
                        }
                    }
                }
            };


            bool opcionCheck = true;
            do
            {
                Console.Clear();
                Console.WriteLine("CEREBRO");
                Console.WriteLine("SIMULACIÓN NEURONAL");
                Console.WriteLine("OPCIONES");
                Console.WriteLine("[1]Crear red neuronal");
                Console.WriteLine("[2]Simular Aprendizaje");
                Console.WriteLine("[3]Comprobar Aprendizaje");
                Console.WriteLine("[4]Salir");
                var opcion = Console.ReadLine();
                if (opcion == "1")
                {
                    Console.Clear();
                    Console.WriteLine(string.Format("{0}", "CREANDO RED NEURONAL...".PadLeft(30)));
                    Console.WriteLine("Tiempo estimado: 2 min");
                    cerebro.CrearRedNeuronal();
                    Console.Clear();
                    Console.WriteLine("RED NEURONAL CREADA CON EXITO!!");
                    Thread.Sleep(TimeSpan.FromSeconds(3));
                    Console.Clear();
                    Console.WriteLine(string.Format("{0}", "RED NEURONAL".PadLeft(25)));
                    cerebro.MostrarRedNeuronal();
                    Console.WriteLine("Presione una tecla para finalizar...");
                    Console.ReadLine();
                }
                else if (opcion == "2")
                {
                    bool aprendercheck = true;
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Para que el cerebro aprenda");
                        Console.WriteLine("Ingresa cualquier palabra, letra o numero, con su concepto. Ejemplo: [1 uno]");
                        string conocimiento = Console.ReadLine();
                        cerebro.Aprender(conocimiento);

                        Console.WriteLine("¿Decea ingresar otro concepto? s/n");
                        string s_n = Console.ReadLine();
                        if (s_n == "n")
                        {
                            aprendercheck = false;
                        }

                    } while (aprendercheck == true);
                }
                else if (opcion == "3")
                {
                    bool comprobarcheck = true;
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Comprobar Aprendizaje");
                        Console.WriteLine("Ingresa cualquier palabra, letra, numero o concepto. Para confirmar Algun Aprendizaje");
                        string recordar = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine(cerebro.Recordar(recordar));

                        Console.WriteLine("¿Decea comprobar otro concepto? s/n");
                        string s_n = Console.ReadLine();
                        if (s_n == "n")
                        {
                            comprobarcheck = false;
                        }
                    } while (comprobarcheck == true);
                }
                else if (opcion == "4")
                {
                    Console.Clear();
                    opcionCheck = false;
                }
                else
                {
                    Console.Clear();
                    opcionCheck = true;
                }
            }
            while (opcionCheck == true);
        }
    }
}
