using System;
using System.Collections.Generic;

namespace Arboles
{
    internal class Pais
    {
        public string Nombre { get; internal set; }
        public string Descripcion { get; internal set; }
        public List<Provincia> Provincias { get; internal set; } = new List<Provincia>();

        internal int ObtenerHabitantes()
        {
            var totalHabitantes = 0;
            foreach (Provincia actual in Provincias)
            {
                var habitantes = actual.ObtenerHabitantes();
                totalHabitantes += habitantes;

            }
            return totalHabitantes;
        }
    }
}
