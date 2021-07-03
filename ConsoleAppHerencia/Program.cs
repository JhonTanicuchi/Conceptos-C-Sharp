using System;

namespace ConsoleAppHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Herencia POO");

            Rectangulo rectangulo = new Rectangulo();
            rectangulo.Altura = 10f;
            rectangulo.Base = 3f;
            var area = rectangulo.Area();
            Console.WriteLine($"El área del rectangulo es: {area}");

            var cuadrado = new Cuadrado();
            cuadrado.Altura = 10f;
            cuadrado.Base = 3f;
            var areaCuadrado = cuadrado.Area();
            Console.WriteLine($"El área del cuadrado es: {areaCuadrado}");
        }
    }
}