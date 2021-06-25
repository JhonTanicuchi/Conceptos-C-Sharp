using System;
using System.Collections.Generic;

namespace Ejercicio.Entidades
{
    public class Profesor : Persona
    {
        //SOBRECARGA

        public Profesor(): base("Julio","Torres")
        {

        }
        //SOBRECARGA

        public Profesor(string nombre, string apellido) : base (nombre, apellido)
        {

        }
        //SOBRECARGA

        public Profesor(string nombre, string apellido, string especialidad) : base(nombre, apellido)
        {
            this.Especialidad = especialidad;
        }
        //SOBRECARGA

        public Profesor(string nombre) : base(nombre,"Torres")
        {

        }
        /*
        public Profesor(string apellido) : base("Julio", apellido)
        {

        }*/
        public int ProfesorId { get; set; }
        public string Especialidad { get; set; }

        //SOBREESCRITURA
        public new string Saludar()
        {
            return "¿Cómo esta usted?";
            //return $" {base.Saludar()} y tambien desde el decendiente";
        }

        public override string Despedir()
        {
            return "¿Cómo esta usted?";
            //return $" {base.Saludar()} y tambien desde el decendiente";
        }
    }
}
