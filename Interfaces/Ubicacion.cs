using System;

namespace Interfaces
{
    public class Ubicacion : IToXml
    {
        public int PosicionX { get; set; }
        public int PosicionY { get; set; }
        public int PosicionZ { get; set; }
        public DateTime PosicionTiempo { get; set; }

        public string ToXml()
        {
            return $"<ubicacion><posicionX>{PosicionX}</poicionX></ubicacion>";
        }
    }
}
