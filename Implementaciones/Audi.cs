using Abstracciones;

namespace Implementaciones
{
    public class Audi : ICarro
    {
        private int millas = 0;

        public int Rodar()
        {
            return ++millas;
        }
    }
}
