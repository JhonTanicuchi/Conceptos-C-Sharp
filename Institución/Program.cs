using System;
using System.Collections.Generic;
using Ejercicio.Entidades;


namespace Torneo.Vista
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Hola Mundo!");

            Profesor quien = new Profesor
            {
                Nombre = "Alanis",
                Apellido = "Morison",
                Especialidad = "Inteligencia Artificial"
            };

            Console.WriteLine((quien).Saludar());

            var Asignatura = new Asignatura
            {
                Nombre = "Programacion Visual"
            };

            var Asignatura1 = new Asignatura
            {
                Nombre = "Diseño de interfaces"
            };

            var nivel = new Nivel
            {
                NameNivel = "1er semetre"

            };

            var nivel2 = new Nivel
            {
                NameNivel = "2do Semestres"

            };

            

            var curso = new Curso
            {
                Asignatura = Asignatura
            };
            var curso1 = new Curso
            {
                Asignatura = Asignatura1
            };
            var Cursos = new List<Curso>
                {
                    curso,
                    curso1
                };

          

            var estudiante = new Estudiante
            {
                Nombre = ".",
                Apellido = "Ruiz",
                Curso = Cursos
            };
            curso.Estudiantes = new List<Estudiante> { estudiante };
            curso.Estudiantes = new List<Estudiante> { estudiante };

            Tarea tarea1 = new Tarea()
            {
                Nombre = "Primer Programa",
                Descripcion = "Crear programa de consola"
            };
   
        }
    }
}