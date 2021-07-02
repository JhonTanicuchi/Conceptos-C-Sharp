using Abstracciones;

namespace Implementaciones
{
    public class BMW : ICarro
    {
        private int millas = 0;

        public int Rodar()
        {
            return ++millas;
        }
    }  
}
