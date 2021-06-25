using System;
using System.Collections.Generic;

namespace LeagueOfLeguends.Entidades
{
    public class Campeon : Personaje
    {    
        public string Raza { get; set; }
        public string Origen { get; set; }
        public string Genero { get; set; }
        public string Rol { get; set; }
        public string Posicion { get; set; }
        public string Frase { get; set; }
        public int Mana { get; set; }
        public double RegeneracionMana { get; set; }
        public double DañoCritico { get; set; }

        public double Experiencia { get; set; }
        public double Nivel { get; set; }

        public List<Habilidad> Habilidades { get; set; }


        public int xp = 280;
        public int patron = 380;

        public void Presentacion()
        {
            var saludo = $"Hola!! mi nombre es {Nombre}";                             
        }


        public void SubirNivel()
        {           
            while (Experiencia >= xp && Nivel >= 1 && Nivel <= 18)
            {               
                Nivel += 1;
                Vida += 50;
                if (Mana != 0)
                    Mana += 100;                   
                Armadura += 5;
                ResistenciaMagica += 1;
                DañoAtaque += 3;                                        

                xp += patron;
                patron += 100;
            }          
        }
    }
}