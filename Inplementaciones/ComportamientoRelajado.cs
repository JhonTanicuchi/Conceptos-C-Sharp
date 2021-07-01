using Abstracciones;

namespace Implementaciones
{
    public class ComportamientoRelajado : Comportamiento
    {
        public override string Caminar()
        {
            return "Estoy caminando Sabroso";
        }

        public override string Informar()
        {
            throw new System.NotImplementedException();
        }
    }
}