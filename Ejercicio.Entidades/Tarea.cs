using System;
namespace Ejercicio.Entidades
{
    public class Tarea
    {
        public int Id { get; set; } = 1;
        //public Guid Id { get; set; } = new Guid("550e8400-e29b-41d4-a716-446655440000");
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime Entrega { get; set; }
        public string Observacion { get; set; }
    }
}
