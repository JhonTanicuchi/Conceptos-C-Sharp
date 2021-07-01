using System;
using System.Collections.Generic;

namespace Árbol3
{
    class Nodo
    {
        public int Id { get; set; }
        public string Valor { get; set; }
        public List<Nodo> Hijos { get; internal set; } = new List<Nodo>();
    }
}
