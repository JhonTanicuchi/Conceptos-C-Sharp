using System;
using System.Collections.Generic;
using LeagueOfLeguends.Entidades;

namespace LeagueOfLeguends
{
    static class Programa
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


            var Habilidades = new List
                <(
                string tecla,
                string nombre,
                string descripcion,
                double daño,
                double rango,
                double radio,
                double costoMana,
                double enfriamiento,
                double velocidad
                )>
            {
                ("q","Concentración de la Guardabosques",
                "Ashe gana velocidad de ataque durante 4 segundos y hace que cada uno de sus ataques básicos dispare una ráfaga de cinco flechas."
                ,21,0,0,50,20,0), 
                ("w","Descarga","Ashe dispara flechas en forma de cono en la dirección del objetivo"
                ,22,1200,0,70,14,2000), 
                ("e","Tiro de Halcón",
                "Ashe envía un espíritu de halcón hacia la ubicación de destino, revelando el área a lo largo de su camino durante 2 segundos"
                ,0,1000,0,5,0,1400), 
                ("r","Flecha de Cristal Encantada",
                "Ashe dispara un Enchanted Crystal Arrow Minimap.png misil de hielo en la dirección del objetivo."
                ,200,0,1025,100,100,1600),     
            };

            var campeones = new List
                <(
                string Nombre, 
                string Genero, 
                string Rol, 
                string Posicion, 
                string Origen, 
                string Frase, 
                int Vida, 
                double RegeneracionVida, 
                double Armadura, 
                double ResistenciaMagica, 
                double DañoAtaque, 
                double DañoCritico, 
                double VelocidadAtaque, 
                double VelocidadMovimiento, 
                double Rango, 
                double RecompensaOro, 
                double RecompensaExperiencia, 
                double Mana, 
                double RegeneracionMana, 
                double Experiencia, 
                double Nivel
                )>
            {
                ("Ashe", "Femenino","Tirador","ADC","Demacia","Hola",570,3.5,26,30,59,100,0.658,325,600,0,0,280,6.972,1800,1),
                ("Garen", "Masulino","Luchador","TOP","Demacia","Hola",620,3.5,26,30,59,100,0.658,325,600,0,0,280,6.972,0,1),
                ("Lux", "Femenino","Mago","SUP,MID","Demacia","Hola",490,3.5,26,30,59,100,0.658,325,600,0,0,280,6.972,0,1),
                ("Rammus", "Masculino","Tanque","JG","Demacia","Hola",564,3.5,26,30,59,100,0.658,325,600,0,0,280,6.972,0,1),
                ("Tryndamere", "Masculino","Luchador","TOP,JG","Demacia","Hola",626,3.5,26,30,59,100,0.658,325,600,0,0,280,6.972,0,1),
                ("Warwick", "Masculino","Luchador","TOP,JG","Demacia","Hola",550,3.5,26,30,59,100,0.658,325,600,0,0,280,6.972,0,1),
            };

           

            
            Console.Clear();
            Console.WriteLine($"┌{new string('─', 60)}┐");
            Console.WriteLine($"│{new string(' ', 60)}│");
            Console.WriteLine($"│{new string(' ', 60)}│");
            Console.WriteLine($"│ {"".PadRight(23)} {"CAMPEONES".PadRight(34)} │");
            Console.WriteLine($"│{new string(' ', 60)}│");

            for (int i = 0; i < campeones.Count / 2; i++)
            {
                Console.WriteLine(string.Format("│ {0} {1} {2} │", " ".PadLeft(10), ("» " + campeones[i].Nombre + "[" + (i + 1) + "]").PadRight(23), ("» " + campeones[i + 3].Nombre + "[" + (i + 4) + "]").PadRight(23)));
            }

            Console.WriteLine($"│{new string(' ', 60)}│");
            Console.WriteLine($"│{new string(' ', 60)}│");
            Console.WriteLine($"└{new string('─', 60)}┘");


            Console.WriteLine("» Ingresa el índice del campeón que deceas elegir:");
            int IndiceCampeon = int.Parse(Console.ReadLine());

       
            while (IndiceCampeon > 6 || IndiceCampeon < 1)
            {               
                Console.WriteLine("Ingresa un indice correcto");
            }


            var mapa = new Mapa
            {
                Nombre = "Grieta del Invocador",
                Lineas = 3
            };


            var campeonElegido = new Campeon
            {
                Nombre = campeones[IndiceCampeon - 1].Nombre,
                Genero = campeones[IndiceCampeon - 1].Genero,
                Rol = campeones[IndiceCampeon - 1].Rol,
                Posicion = campeones[IndiceCampeon - 1].Posicion,
                Origen = campeones[IndiceCampeon - 1].Origen,
                Frase = campeones[IndiceCampeon - 1].Frase,
                Vida = campeones[IndiceCampeon - 1].Vida,
                RegeneracionVida = campeones[IndiceCampeon - 1].RegeneracionVida,
                Armadura = campeones[IndiceCampeon - 1].Armadura,
                ResistenciaMagica = campeones[IndiceCampeon - 1].ResistenciaMagica,
                DañoAtaque = campeones[IndiceCampeon - 1].DañoAtaque,
                DañoCritico = campeones[IndiceCampeon - 1].DañoCritico,
                VelocidadAtaque = campeones[IndiceCampeon - 1].VelocidadAtaque,
                VelocidadMovimiento = campeones[IndiceCampeon - 1].VelocidadMovimiento,
                Rango = campeones[IndiceCampeon - 1].Rango,
                RecompensaOro = campeones[IndiceCampeon - 1].RecompensaOro,
                RecompensaExperiencia = campeones[IndiceCampeon - 1].RecompensaExperiencia,
                Mana = campeones[IndiceCampeon - 1].Mana,
                RegeneracionMana = campeones[IndiceCampeon - 1].RegeneracionMana,
                Experiencia = campeones[IndiceCampeon - 1].Experiencia,
                Nivel = campeones[IndiceCampeon - 1].Nivel,

                Habilidades = new List<Habilidad>
                {
                   
                }
            };
        

            Random CampeonAleatorio = new Random();
            int campeonAleatorio = CampeonAleatorio.Next(1, campeones.Count);


            var campeonEnemigo = new Campeon
            {
                Nombre = campeones[campeonAleatorio].Nombre,
                Genero = campeones[campeonAleatorio].Genero,
                Rol = campeones[campeonAleatorio].Rol,
                Posicion = campeones[campeonAleatorio].Posicion,
                Origen = campeones[campeonAleatorio].Origen,
                Frase = campeones[campeonAleatorio].Frase,
                Vida = campeones[campeonAleatorio].Vida,
                RegeneracionVida = campeones[campeonAleatorio].RegeneracionVida,
                Armadura = campeones[campeonAleatorio].Armadura,
                ResistenciaMagica = campeones[campeonAleatorio].ResistenciaMagica,
                DañoAtaque = campeones[campeonAleatorio].DañoAtaque,
                DañoCritico = campeones[campeonAleatorio].DañoCritico,
                VelocidadAtaque = campeones[campeonAleatorio].VelocidadAtaque,
                VelocidadMovimiento = campeones[campeonAleatorio].VelocidadMovimiento,
                Rango = campeones[campeonAleatorio].Rango,
                RecompensaOro = campeones[campeonAleatorio].RecompensaOro,
                RecompensaExperiencia = campeones[campeonAleatorio].RecompensaExperiencia,
                Mana = campeones[campeonAleatorio].Mana,
                RegeneracionMana = campeones[campeonAleatorio].RegeneracionMana,
                Experiencia = campeones[campeonAleatorio].Experiencia,
                Nivel = campeones[campeonAleatorio].Nivel,

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
            Console.WriteLine($"│ {" ".PadLeft(5)} {campeonElegido.Posicion.PadRight(17)}  {"█ █ ▀▀█".PadRight(7)}{campeonEnemigo.Posicion.PadLeft(20)} {"│".PadLeft(7)}");
            Console.WriteLine($"│ {" ".PadLeft(5)} {campeonElegido.Rol.PadRight(17)} {" ▀▄▀ █▄█".PadRight(7)}{campeonEnemigo.Rol.PadLeft(20)} {"│".PadLeft(7)}");
            Console.WriteLine($"│ {" ".PadLeft(5)} {campeonElegido.Origen.PadRight(24)}  {campeonEnemigo.Origen.PadLeft(20)} {"│".PadLeft(7)}");
            Console.WriteLine($"│{new string(' ', 60)}│");
            Console.WriteLine($"│{new string(' ', 60)}│");
            Console.WriteLine($"└{new string('─', 60)}┘");



            Console.WriteLine(string.Format("┌{0}┐{1}┌{2}┐", new string('─', 18), " ".PadRight(22), new string('─', 18)));
            Console.WriteLine(string.Format("│{0}│{1}│{2}│", "  REGRESAR [ESC]".PadRight(18), " ".PadRight(22), "COMENZAR [ENTER] ".PadLeft(18)));
            Console.WriteLine(string.Format("└{0}┘{1}└{0}┘\n", new string('─', 18)," ".PadRight(22), new string('─', 18)));
            Console.ReadLine();



            Console.Clear();
            Console.WriteLine(string.Format("{0}", mapa.Nombre.ToUpper().PadLeft(39)));
            Console.WriteLine(string.Format("{0}\n", "(mapa)".PadLeft(32)));
            Console.WriteLine(string.Format("{0}vida", "vida".PadRight(53)));
            Console.WriteLine(string.Format("{0} {1}", new string('▓', 20) + " " + campeonElegido.Vida, (campeonEnemigo.Vida + " " + new string('▓', 20)).PadLeft(32)));
            Console.WriteLine(string.Format("\n{0} {1}", (campeonElegido.Nombre.ToUpper() + " (Tú)").PadRight(30), (campeonEnemigo.Nombre.ToUpper()).PadLeft(26)));
            Console.WriteLine(string.Format("{0} {1}", new string('─', 20), new string('─', 20).PadLeft(36)));
            Console.WriteLine(string.Format("{0}│ {1}{2}│ {3}", "Nivel:".PadRight(15), campeonElegido.Nivel.ToString().PadRight(20), "Nivel:".PadRight(15), campeonEnemigo.Nivel.ToString().PadRight(5)));
            Console.WriteLine(string.Format("{0}│ {1}{2}│ {3}", "Experiencia:".PadRight(15), campeonElegido.Experiencia.ToString().PadRight(20), "Experiencia:".PadRight(15), campeonEnemigo.Experiencia.ToString().PadRight(5)));
            Console.WriteLine(string.Format("{0}│ {1}{2}│ {3}", "Mana:".PadRight(15), campeonElegido.Mana.ToString().PadRight(20), "Mana:".PadRight(15), campeonEnemigo.Mana.ToString().PadRight(5)));
            Console.WriteLine(string.Format("{0} {1}", new string('─', 20), new string('─', 20).PadLeft(36)));
            Console.WriteLine(string.Format("\n{0} {1}", "Propiedades".PadRight(30), "Propiedades".PadLeft(26)));
            Console.WriteLine(string.Format("{0} {1}", new string('─', 20), new string('─', 20).PadLeft(36)));
            Console.WriteLine(string.Format("{0}│ {1}{2}│ {3}", "Armadura:".PadRight(15), campeonElegido.Armadura.ToString().PadRight(20), "Armadura:".PadRight(15), campeonEnemigo.Armadura.ToString().PadRight(5)));
            Console.WriteLine(string.Format("{0}│ {1}{2}│ {3}", "Resistencia M:".PadRight(15), campeonElegido.ResistenciaMagica.ToString().PadRight(20), "Resistencia M:".PadRight(15), campeonEnemigo.ResistenciaMagica.ToString().PadRight(5)));
            Console.WriteLine(string.Format("{0}│ {1}{2}│ {3}", "Daño Ataque:".PadRight(15), campeonElegido.DañoAtaque.ToString().PadRight(20), "Daño Ataque:".PadRight(15), campeonEnemigo.DañoAtaque.ToString().PadRight(5)));
            Console.WriteLine(string.Format("{0}│ {1}{2}│ {3}", "Daño Crítico:".PadRight(15), campeonElegido.DañoCritico.ToString().PadRight(20), "Daño Crítico:".PadRight(15), campeonEnemigo.DañoCritico.ToString().PadRight(5)));
            Console.WriteLine(string.Format("{0}│ {1}{2}│ {3}", "Velocidad Atq:".PadRight(15), campeonElegido.VelocidadAtaque.ToString().PadRight(20), "Velocidad Ata:".PadRight(15), campeonEnemigo.VelocidadAtaque.ToString().PadRight(5)));
            Console.WriteLine(string.Format("{0}│ {1}{2}│ {3}", "Velocidad Mov:".PadRight(15), campeonElegido.VelocidadMovimiento.ToString().PadRight(20), "Velocidad Mov:".PadRight(15), campeonEnemigo.VelocidadMovimiento.ToString().PadRight(5)));

            campeonElegido.SubirNivel();
            Console.ReadLine();
        }
    }
}
