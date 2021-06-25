using System;
using System.Collections.Generic;

namespace Ejercicio.Entidades
{
    public abstract class Persona
    {      
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string NombreCompleto { get { return $"{Nombre} {Apellido}"; } }


        public Persona(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = nombre;
        }

        public string Saludar()
        {
            return $"Hola, me llamo {Nombre}, espero te encuentres bien";
        }

        public string Saludar(string nombreAmigo)
        {
            return $"Que mas ve, {nombreAmigo}, que te cuentas";
        }

        public abstract string Despedir();

    }
}
