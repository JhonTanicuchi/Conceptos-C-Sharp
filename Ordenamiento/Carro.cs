using System;
using System.Collections.Generic;

namespace Ordenamiento
{
    class Carro : IComparable
    {
        public int Precio { get; set; }
        public DateTime FechaEnsamblado { get; set; }

        public int CompareTo(object obj)
        {
            return this.Precio - ((Carro)obj).Precio;
        }

        public new string ToString()
        {
            return Precio.ToString();
        }
    }
}