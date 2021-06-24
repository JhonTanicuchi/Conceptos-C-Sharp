using System;
using System.Collections.Generic;

namespace Arboles
{
    internal class Canton
    {
        public string Nombre { get; set; }
        public List<Parroquia> Parroquias { get; internal set; } = new List<Parroquia>();

        

        internal int ObtenerHabitantes()
        {
            var totalHabitantes = 0;
            foreach (Parroquia actual in Parroquias)
            {
                var habitantes = actual.Habitantes;
                totalHabitantes += habitantes;

            }
            return totalHabitantes;
        }
    }
}
