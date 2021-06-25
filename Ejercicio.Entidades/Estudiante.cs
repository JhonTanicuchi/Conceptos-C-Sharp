using System;
using System.Collections.Generic;

namespace Ejercicio.Entidades
{
    public class Estudiante : Persona
    {
        public Estudiante() : base("Jorge", "Lopez")
        {
        }

        public Estudiante(string nombre) : base(nombre, "Lopez")
        {
        }
        public int EstudianteId { get; set; }
        public List<Curso> Curso { get; set; }

        public override string Despedir()
        {
            throw new NotImplementedException();
        }
    }
}