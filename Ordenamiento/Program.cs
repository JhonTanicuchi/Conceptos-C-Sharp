using System;
using System.Collections.Generic;

namespace Ordenamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ordenamiento");

            Ordenador ordenador = new Ordenador();
            var desordenadosCarros = new List<IComparable>
            {
                new Carro{ Precio = 10},
                new Carro{ Precio = 8},
                new Carro{ Precio = 42},
                new Carro{ Precio = 5},
                new Carro{ Precio = 13}

            };
            var ordenadosCarros = ordenador.Ordenar(desordenadosCarros);
            foreach (Carro carro in desordenadosCarros)
                Console.WriteLine(carro.ToString());


            var puestoTrabajo = new List<IComparable>
            {
                new PuestoTrabajo{ Posicion = 10},
                new PuestoTrabajo{ Posicion = 20},
                new PuestoTrabajo{ Posicion = 1},
                new PuestoTrabajo{ Posicion = 14},
                new PuestoTrabajo{ Posicion = 17},
            };

            var PuestosTrabajoOrdenados = ordenador.Ordenar(puestoTrabajo);
            foreach (PuestoTrabajo actual in PuestosTrabajoOrdenados)
                Console.WriteLine(actual.Posicion);

        }
    }
}
