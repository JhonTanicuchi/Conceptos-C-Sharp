using Abstracciones;


namespace Implementaciones
{
    public class Ford : ICarro
    {
        private int millas = 0;

        public int Rodar()
        {
            return ++millas;
        }
    }
}
