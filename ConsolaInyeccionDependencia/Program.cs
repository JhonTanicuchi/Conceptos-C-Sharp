using Abstracciones;
using Implementaciones;
using System;

namespace ConsolaInyeccionDependencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Comportamiento comportamiento = new ComportamientoNormal();
            Guia guia = new Guia(comportamiento); // Inyección por el constructor

            Console.WriteLine("En Quito");
            Console.WriteLine(guia.Caminar());

            Console.WriteLine("En una jungla africana(Leones, selva de la Asia(Tigres)");
            guia.Comportamiento = new ComportamientoCauteloso(); //Inyección por propoiedad
            Console.WriteLine(guia.Caminar());

            Console.WriteLine("En Pedernales");
            guia.Comportamiento = new ComportamientoRelajado();
            Console.WriteLine(guia.Caminar());

        }
    }
}
