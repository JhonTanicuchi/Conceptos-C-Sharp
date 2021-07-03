using System.Collections.Generic;

namespace Interfaces
{
    public class Heroe :IToXml
    {
        public string Nombre { get; set; }
        public int Ki { get; set; }
        public Caracter Caracter { get; set; }
        public Fase Fase { get; set; }
        public Heroe Amigo { get; set; }
        public Villano Enemigo { get; set; }
        public Ubicacion Ubicacion { get; set; }

        public string ToXml()
        {
            return $"<heroe><nombre>{Nombre}</nombre><ki>{Ki}</ki><caracter>{Caracter}</caracter></heroe>";
        }


        //public List<Heroe> HijosLista { get; set; }
        //public Collection<Heroe> HijosLista { get; set; }
        //public Heroe[] HijosVector { get; set; }
    }
}
