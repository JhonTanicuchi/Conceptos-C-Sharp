using System;
using System.Collections.Generic;

namespace GameLeagueOfLeguends
{
    class Programa
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"┌{new string('─', 60)}┐");
            Console.WriteLine($"│{new string(' ', 60)}│");
            Console.WriteLine($"│{new string(' ', 60)}│");

            Console.WriteLine($"│ {"".PadRight(18)} {"╔══╗   ╔═════╗ ╔══╗  ".PadRight(39)} │");
            Console.WriteLine($"│ {"".PadRight(18)} {"║  ║   ║     ║ ║  ║  ".PadRight(39)} │");
            Console.WriteLine($"│ {"".PadRight(18)} {"║  ║   ║  ║  ║ ║  ║  ".PadRight(39)} │");
            Console.WriteLine($"│ {"".PadRight(18)} {"║  ╚═╗ ║  ║  ║ ║  ╚═╗".PadRight(39)} │");
            Console.WriteLine($"│ {"".PadRight(18)} {"║    ║ ║     ║ ║    ║".PadRight(39)} │");
            Console.WriteLine($"│ {"".PadRight(18)} {"╚════╝ ╚═════╝ ╚════╝".PadRight(39)} │");
            Console.WriteLine($"│{new string(' ', 60)}│");
            Console.WriteLine($"│ {"".PadRight(15)} {"League Of Legueds «CONSOLE»".PadRight(42)} │");
            Console.WriteLine($"│{new string(' ', 60)}│");
            Console.WriteLine($"│ {"".PadRight(21)} {"» Jugar [ENTER]".PadRight(36)} │");
            Console.WriteLine($"│ {"".PadRight(21)} {"» Salir [ESC]".PadRight(36)} │");
            Console.WriteLine($"│{new string(' ', 60)}│");
            Console.WriteLine($"│{new string(' ', 60)}│");
            Console.WriteLine($"└{new string('─', 60)}┘");


            if (Console.ReadKey().Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }


            Console.Clear();
            Console.WriteLine($"┌{new string('─', 60)}┐");
            Console.WriteLine($"│{new string(' ', 60)}│");
            Console.WriteLine($"│{new string(' ', 60)}│");
            Console.WriteLine($"│ {"".PadRight(23)} {"CAMPEONES".PadRight(34)} │");
            Console.WriteLine($"│{new string(' ', 60)}│");
            Console.WriteLine($"│ {" ".PadLeft(10)} {"» Ashe [1]".PadRight(20)}  {"» Rammus [4]".PadRight(25)} │");
            Console.WriteLine($"│ {" ".PadLeft(10)} {"» Garen [2]".PadRight(20)}  {"» Tryndamere [5]".PadRight(25)} │");
            Console.WriteLine($"│ {" ".PadLeft(10)} {"» Lux [3]".PadRight(20)}  {"» Warwick [6]".PadRight(25)} │");
            Console.WriteLine($"│{new string(' ', 60)}│");
            Console.WriteLine($"│{new string(' ', 60)}│");
            Console.WriteLine($"└{new string('─', 60)}┘");


            var campeones = new List<(string Nombre, string Genero, string Rol, string Origen, string Frase, int Daño)>
            {
                ("Ashe", "Femenino","Tirador","Demacia","Hola",50),
                ("Garen", "Masculino","Luchaodr","Demacia","Hola",50),
                ("Lux", "Femenino","Mago","Demacia","Hola",20),
                ("Rammus", "Masculino","Tanque","Demacia","Hola",30),
                ("Tryndamere", "Masculino","Luchador","Demacia","Hola",60),
                ("Warwick", "Msculino","Luchador","Demacia","Hola",50),

            };


            Console.WriteLine("» Ingresa el índice del campeón que deceas elegir:");
            int IndiceCampeon = int.Parse(Console.ReadLine());
            while (IndiceCampeon > 6 && IndiceCampeon < 1)
            {
                Console.WriteLine("Ingresa un indice correcto");
            }


            var campeonElegido = new Campeon
            {
                Nombre = campeones[IndiceCampeon - 1].Nombre,
                Genero = campeones[IndiceCampeon - 1].Genero,
                Rol = campeones[IndiceCampeon - 1].Rol,
                Origen = campeones[IndiceCampeon - 1].Origen,
                Frase = campeones[IndiceCampeon - 1].Frase,
                Daño = campeones[IndiceCampeon - 1].Daño,
                Habilidades = new List<Habilidad>
                {

                }
            };
        

            Random CampeonAleatorio = new Random();

            int campeonAleatorio = CampeonAleatorio.Next(1, 6);
            Console.WriteLine(campeonAleatorio);

            var campeonEnemigo = new Campeon
            {
                Nombre = campeones[campeonAleatorio].Nombre,
                Genero = campeones[campeonAleatorio].Genero,
                Rol = campeones[campeonAleatorio].Rol,
                Origen = campeones[campeonAleatorio].Origen,
                Frase = campeones[campeonAleatorio].Frase,
                Daño = campeones[campeonAleatorio].Daño,
                Habilidades = new List<Habilidad>
                {

                }
            };


            Console.Clear();
            Console.WriteLine($"┌{new string('─', 60)}┐");
            Console.WriteLine($"│{new string(' ', 60)}│");
            Console.WriteLine($"│{new string(' ', 60)}│");
            Console.WriteLine($"│ {"".PadRight(21)} {"ENFRENTAMIENTO".PadRight(36)} │");
            Console.WriteLine($"│{new string(' ', 60)}│");
            Console.WriteLine($"│ {" ".PadLeft(5)} {(campeonElegido.Nombre.ToUpper() + " (Tú)").PadRight(24)}  {(campeonEnemigo.Nombre.ToUpper()).PadLeft(20)} {"│".PadLeft(7)}");
            Console.WriteLine($"│ {" ".PadLeft(5)} {new string('─', 10).PadRight(17)}  {"█ █ █▀▀".PadRight(7)}{new string('─', 10).PadLeft(20)} {"│".PadLeft(7)}");
            Console.WriteLine($"│ {" ".PadLeft(5)} {campeonElegido.Genero.PadRight(17)}  {"█ █ ▀▀█".PadRight(7)}{campeonEnemigo.Genero.PadLeft(20)} {"│".PadLeft(7)}");
            Console.WriteLine($"│ {" ".PadLeft(5)} {campeonElegido.Rol.PadRight(17)} {" ▀▄▀ █▄█".PadRight(7)}{campeonEnemigo.Rol.PadLeft(20)} {"│".PadLeft(7)}");
            Console.WriteLine($"│ {" ".PadLeft(5)} {campeonElegido.Origen.PadRight(24)}  {campeonEnemigo.Origen.PadLeft(20)} {"│".PadLeft(7)}");
            Console.WriteLine($"│{new string(' ', 60)}│");
            Console.WriteLine($"│{new string(' ', 60)}│");
            Console.WriteLine($"└{new string('─', 60)}┘");
           

 



            Console.WriteLine($"┌{new string('─', 60)}┐");
            Console.WriteLine($"REGRESAR EMPEZAR");
            Console.WriteLine($"└{new string('─', 60)}┘\n");
            Console.ReadLine();


            Console.Clear();

            var vida = 100;
            Console.WriteLine($"{new string('▓', vida / 5) + " " + vida + "%"} {(vida + "% " + new string('▓', vida / 5)).PadLeft(31)}");
            Console.WriteLine($"{(campeonElegido.Nombre.ToUpper() + " (Tú)").PadRight(30)} {(campeonEnemigo.Nombre.ToUpper()).PadLeft(26)}");
            Console.ReadLine();

        }
    }
}
