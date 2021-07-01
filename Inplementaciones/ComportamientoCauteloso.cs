using Abstracciones;

namespace Implementaciones
{
    public class ComportamientoCauteloso : Comportamiento
    {
        public override string Caminar()
        {
            return "Estoy caminando con cuidado";
        }

        public override string Informar()
        {
            return "Informo bajando la voz";
        }
    }
}