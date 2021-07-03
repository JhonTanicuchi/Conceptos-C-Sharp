using System;
using System.IO;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string cabecera = "<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\" ?>";
            FileStream file = File.Create("E:\\DragonBall.xml");
            //file.Write(...);

            Heroe heroe = new Heroe();
            heroe.Nombre = "Goku";
            heroe.Ki = 1000000;

            Villano villano = new Villano();
            villano.Nombre = "Cell";
            villano.Ki = 900000;
        }
    } 
}
