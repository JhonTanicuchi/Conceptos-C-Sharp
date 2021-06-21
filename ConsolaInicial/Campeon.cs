using System;
using System.Collections.Generic;

namespace GameLeagueOfLeguends
{
    class Campeon
    {
        string nombre;
        string genero;
        string rol;
        string origen;
        string frase;
        decimal daño;
        decimal velocidadAtaque;
        internal List<Habilidad> Habilidades;

        internal string Nombre { get { return nombre; } set { nombre = value; } }
        internal string Origen { get { return origen; } set { origen = value; } }
        internal string Genero { get { return genero; } set { genero = value; } }
        internal string Rol { get { return rol; } set { rol = value; } }
        internal string Frase { get { return frase; } set { frase = value; } }
        internal decimal Daño { get { return daño; } set { daño = value; } }
        internal decimal VelocidadAtaque { get { return velocidadAtaque; } set { velocidadAtaque = value; } }


        public void Presentacion()
        {
            var saludo = $"Hola!! mi nombre es {Nombre}";          
            Console.WriteLine(Origen);
            Console.WriteLine(Rol);
            Console.WriteLine(Frase);
            Console.WriteLine(Daño);
            Console.WriteLine(VelocidadAtaque);          
        }
    }
}