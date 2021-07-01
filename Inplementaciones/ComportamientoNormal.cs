using Abstracciones;

namespace Implementaciones
{
    public class ComportamientoNormal : Comportamiento
    {
        public override string Caminar()
        {
            return "Estoy caminando";         
        }

        public override string Informar()
        {
            return "";
        }
    }
}