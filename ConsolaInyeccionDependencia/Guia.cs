using Abstracciones;
using System;

namespace ConsolaInyeccionDependencia
{
    internal class Guia
    {
       public Guia(Comportamiento comportamiento)
        {
            Comportamiento = comportamiento;
        }
        public Comportamiento Comportamiento { get; set; }

        internal string Caminar()
        {
            return Comportamiento.Caminar();
        }

        internal string Informar()
        {
            return Comportamiento.Informar();

        }
    }
}