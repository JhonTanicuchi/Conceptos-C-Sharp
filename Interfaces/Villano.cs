using System;

namespace Interfaces
{
    public class Villano : IToXml
    {
        public string Nombre { get; set; }
        public int Ki { get; set; }     

        string IToXml.ToXml()
        {
            return $"<villano><nombre>{Nombre}</nombre><ki>{Ki}</ki></villano>";
        }
    }
}
