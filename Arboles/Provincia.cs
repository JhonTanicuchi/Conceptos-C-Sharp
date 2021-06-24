using System;
using System.Collections.Generic;

namespace Arboles
{
    internal class Provincia
    {
        public string Nombre { get; set; }
        public List<Canton> Cantones { get; internal set; } = new List<Canton>();
        

        internal int ObtenerHabitantes()
        {
            var totalHabitantes = 0;
            foreach (Canton actual in Cantones)
            {
                var habitantes = actual.ObtenerHabitantes();
                totalHabitantes +=  habitantes;

            }
            return totalHabitantes;
        }
    }
}
