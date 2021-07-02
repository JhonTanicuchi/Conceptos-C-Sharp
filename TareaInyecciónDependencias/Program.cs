using Abstracciones;
using Implementaciones;
using Unity;

namespace TareaInyecciónDependencias
{
    static class Program
    {
        static void Main(string[] args)
        {
            var container = new UnityContainer();
            container.RegisterType<ICarro, BMW>();

            var conducir = container.Resolve<Conducir>();
            conducir.RodarCarro();
        }
    }
}
