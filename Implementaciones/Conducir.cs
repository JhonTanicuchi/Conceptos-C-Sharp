using Abstracciones;
using System;
using System.Threading;

namespace Implementaciones
{
    public class Conducir
    {
        private ICarro carro = null;

        public Conducir(ICarro car)
        {
            carro = car;
        }

        public void RodarCarro()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Clear();
                Console.WriteLine("Rodando {0} - Millas: {1} ", carro.GetType().Name, carro.Rodar());
                Thread.Sleep(TimeSpan.FromSeconds(.5));
            }
        }
    }
}
