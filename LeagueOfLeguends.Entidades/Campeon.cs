﻿using System;
using System.Collections.Generic;

namespace LeagueOfLeguends.Entidades
{
    public class Campeon : Personaje
    {    
        string genero;
        string rol;
        string posicion;
        string origen;
        string frase;     
        double mana;
        double regeneracionMana;     
        double dañoCritico;
        double experiencia;
        double nivel;


        public int xp = 280;
        public int patron = 380;

        public string Origen { get { return origen; } set { origen = value; } }
        public string Genero { get { return genero; } set { genero = value; } }
        public string Rol { get { return rol; } set { rol = value; } }
        public string Posicion { get { return posicion; } set { posicion = value; } }
        public string Frase { get { return frase; } set { frase = value; } }
        public double Mana { get { return mana; } set { mana = value; } }
        public double RegeneracionMana { get { return regeneracionMana; } set { regeneracionMana = value; } }
        public double DañoCritico { get { return dañoCritico; } set { dañoCritico = value; } }

        public double Experiencia { get { return experiencia; } set { experiencia = value; } }
        public double Nivel { get { return nivel; } set { nivel = value; } }

        public List<Habilidad> Habilidades { get; set; }




        public void Presentacion()
        {
            var saludo = $"Hola!! mi nombre es {Nombre}";                             
        }



        public void SubirNivel()
        {           
            while (Experiencia >= xp && Nivel >= 1 && Nivel <= 18)
            {               
                Nivel = Nivel + 1;
                xp += patron;
                patron += 100;               
            }          
        }
    }
}