using System;
using System.Collections.Generic;

namespace Ordenamiento
{
    public class Ordenador
    {
        public List<IComparable> Ordenar(List<IComparable> desordenados)
        {
            for (int i = 0; i < desordenados.Count - 1; i++)
            {
                var posicionMenor = i;
                posicionMenor = Menor(desordenados, posicionMenor);

                var intercambio = desordenados[posicionMenor];
                desordenados[posicionMenor] = desordenados[i];
                desordenados[i] = intercambio;                
            }
            return desordenados;
        }



        private int Menor(List<IComparable> desordenados , int posicionMenor)
        {           
            for (int i = posicionMenor; i < desordenados.Count - 1; i++)
            {
                if (desordenados[posicionMenor].CompareTo(desordenados[i]) > 0)
                {
                    posicionMenor = i;
                }
            }
            return posicionMenor;
        } 
    }
}