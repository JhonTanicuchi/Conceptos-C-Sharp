using System;
using System.Collections.Generic;

namespace Arbol2
{
    class Nodo
    {
        private string _valor;


        public string Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }
        public Nodo Izquierdo { get; set; }
        public Nodo Derecho { get; set; }
        public List<Nodo> Nodos { get; internal set; } = new List<Nodo>();


        public Nodo() {}


        public Nodo(string valor)
        {
            Valor = valor;
        }      
    }
}