using System;
using System.Collections.Generic;

namespace Ejercicio.Entidades
{
    public class Curso
    {
        public int CursoId { get; set; }
        public Nivel Nivel { get; set; }
        public Asignatura Asignatura { get; set; }
        public Jornada Jornada { get; set; }
        public Paralelo Paralelo { get; set; }
        public Profesor Profesor { get; set; }
        public List<Estudiante> Estudiantes { get; set; }
    }
}