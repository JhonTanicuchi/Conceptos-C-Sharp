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


        public Nodo() { }


        public Nodo(string valor)
        {
            Valor = valor;
        }


        public string valoresNodos;
        public string OperacionNodo(Nodo nodo)
        {
            if (nodo == null)
                return "Null";

            OperacionNodo(nodo.Izquierdo);
            valoresNodos += nodo.Valor;
            OperacionNodo(nodo.Derecho);

            return nodo.valoresNodos;
        }
    }
}