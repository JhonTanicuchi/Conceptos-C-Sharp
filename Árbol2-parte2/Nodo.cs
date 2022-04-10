using System;
using System.Collections.Generic;

namespace Árbol3
{
    public class Nodo
    {
        public int Id { get; set; }
        public string Valor { get; set; }
        public List<Nodo> Hijos { get; internal set; } = new List<Nodo>();

        public string NavegacionH()
        {
            var numeros = "";
            numeros += Valor;

            for (int i = 0; i < Hijos.Count; i++)
            {
                numeros += Hijos[i].Valor;
            }

            foreach (var item in Hijos)
            {                
                for (int i = 0; i < Hijos.Count; i++)
                {
                    numeros += item.Hijos[i].Valor;
                }
            }

            foreach (var item in Hijos)
            {
                foreach (var nodo in item.Hijos)
                {
                    if (nodo.Hijos.Count != 0)
                    {
                        numeros += nodo.Hijos[0].Valor;

                    }
                }                                              
            }      
            return numeros;
        }
    }
}
