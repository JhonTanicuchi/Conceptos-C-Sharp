using System;
using System.Collections.Generic;

namespace Arboles
{
    class Program
    {
        static void Main(string[] args)
        {
            var pais = new Pais
            {
                Nombre = "Ecuador",
                Descripcion = "El Pais mas feliz del mundo"
            };
            pais.Provincias.Add(new Provincia { Nombre = "Pichincha" });
            pais.Provincias.Add
                (
                    new Provincia
                    {
                        Nombre = "Carchi",
                        Cantones = new List<Canton>
                        {
                            new Canton
                            {
                                Nombre = "Montúfar",
                                Parroquias = new List<Parroquia>
                                {
                                    new Parroquia
                                    {
                                        Nombre = "Gonzáles Suáres",
                                        Habitantes =2500
                                    },
                                    new Parroquia
                                    {
                                        Nombre = "San José",
                                        Habitantes =1500
                                    },
                                     new Parroquia
                                    {
                                        Nombre = "San Gabriel",
                                        Habitantes =2500
                                    },
                                    new Parroquia
                                    {
                                        Nombre = "Cristóbal Colón",
                                        Habitantes =1500
                                    }
                                }
                            },
                            new Canton
                            {
                                Nombre = "Túlcan",
                                Parroquias = new List<Parroquia>
                                {
                                    new Parroquia
                                    {
                                        Nombre = "Gonzáles Suáres",
                                        Habitantes =2500
                                    },
                                    new Parroquia
                                    {
                                        Nombre = "Tulcán",
                                        Habitantes =1500
                                    },
                                     new Parroquia
                                    {
                                        Nombre = "Huaca",
                                        Habitantes =2500
                                    },
                                    new Parroquia
                                    {
                                        Nombre = "El Ángel",
                                        Habitantes =1500
                                    }
                                }
                            }
                        }
                    }
                );
            pais.Provincias.Add
                (
                    new Provincia
                    {
                        Nombre = "Pichincha",
                        Cantones = new List<Canton>
                        {
                            new Canton
                            {
                                Nombre = "Quito",
                                Parroquias = new List<Parroquia>
                                {
                                    new Parroquia
                                    {
                                        Nombre = "Carcelén",
                                        Habitantes =2500
                                    },
                                    new Parroquia
                                    {
                                        Nombre = "Calderón",
                                        Habitantes =1500
                                    },
                                     new Parroquia
                                    {
                                        Nombre = "Cumbayá",
                                        Habitantes =2500
                                    },
                                    new Parroquia
                                    {
                                        Nombre = "Quitumbre",
                                        Habitantes =1500
                                    }
                                }
                            },
                            new Canton
                            {
                                Nombre = "Cayambe",
                                Parroquias = new List<Parroquia>
                                {
                                    new Parroquia
                                    {
                                        Nombre = "Cayambe",
                                        Habitantes =2500
                                    },
                                    new Parroquia
                                    {
                                        Nombre = "Juan Montalvo",
                                        Habitantes =1500
                                    },
                                     new Parroquia
                                    {
                                        Nombre = "Olmedo",
                                        Habitantes =2500
                                    },
                                    new Parroquia
                                    {
                                        Nombre = "Ayora",
                                        Habitantes =1500
                                    }
                                }
                            }
                        }
                    }
                );
            
                
                Console.WriteLine(value: $"La cantidad total de habitantes de {pais.Nombre} es: {pais.ObtenerHabitantes()}");

            
        }
    }
}
