using System;
using System.Collections.Generic;
using Cerebro.Entidades;

namespace Cerebro.POO_Arbol_
{
    class Program
    {
        static void Main(string[] args)
        {
            var cerebro = new CerebroHumano
            {
                HemisferioIzquierdo = new Hemisferio
                {
                    Zonas = new List<Zona>
                    {
                        new Zona
                        {
                            Nombre = "ZonaVizual"                                                  
                        },
                        new Zona
                        {
                            Nombre = "ZonaSenzorial"

                        },
                        new Zona
                        {
                            Nombre = "ZonaMotora"

                        },
                        new Zona
                        {
                            Nombre = "ZonaLenguaje"

                        },
                        new Zona
                        {
                            Nombre = "ZonaAsociativa",
                            Neuronas = new List<Neurona>
                            {
                                new Neurona
                                {
                                    Dendritas = new List<Dendrita>
                                    {
                                        new Dendrita
                                        {
                                            VesiculasSinapticas = new List<VesiculaSinaptica>
                                            {
                                                new VesiculaSinaptica
                                                {
                                                    Neurotransmisores = new List<Neurotransmisor>
                                                    {
                                                        new Neurotransmisor
                                                        {
                                                            Informacion = "1",
                                                            Propiedades = new List<Propiedad>
                                                            {
                                                                new Propiedad
                                                                {
                                                                    Nombre = "uno"
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                },
                                new Neurona
                                {
                                    Dendritas = new List<Dendrita>
                                    {
                                        new Dendrita
                                        {
                                            VesiculasSinapticas = new List<VesiculaSinaptica>
                                            {
                                                new VesiculaSinaptica
                                                {
                                                    Neurotransmisores = new List<Neurotransmisor>
                                                    {
                                                        new Neurotransmisor
                                                        {
                                                            Informacion = "2",
                                                            Propiedades = new List<Propiedad>
                                                            {
                                                                new Propiedad
                                                                {
                                                                    Nombre = "dos"
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                },
                HemisferioDerecho = new Hemisferio
                {
                    Zonas = new List<Zona>
                    {
                        new Zona
                        {
                            Nombre = "ZonaVizual"
                        },
                        new Zona
                        {
                            Nombre = "ZonaSenzorial"

                        },
                        new Zona
                        {
                            Nombre = "ZonaMotora"

                        },                                            
                        new Zona
                        {
                            Nombre = "ZonaAsociativa"

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
                Console.WriteLine("[1]Crear red neuronal => Tiempo estimado 5min");
                Console.WriteLine("[2]Simular Aprendizaje");
                Console.WriteLine("[3]Comprobar Aprendizaje");
                Console.WriteLine("[4]Salir");
                int opcion = int.Parse(Console.ReadLine());
                if (opcion == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Creando red neuronal...");
                    cerebro.CrearRedNeuronal();
                    cerebro.MostrarRedNeuronal();
                }
                else if (opcion == 2)
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
                else if (opcion == 3)
                {
                    bool comprobarcheck = true;
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Comprobar Aprendizaje");
                        Console.WriteLine("Ingresa cualquier palabra, letra o numero, con su concepto. Ejemplo: [1 uno]");
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
                else if (opcion == 4)
                {
                    Console.Clear();
                    opcionCheck = false;
                }
            }
            while (opcionCheck == true);
        }
    }
}
