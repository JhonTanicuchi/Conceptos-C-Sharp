namespace LeagueOfLeguends.Entidades
{
    public class Mapa
    {
        string nombre;
        int lineas;
        Estructura estructuras;


        public string Nombre { get { return nombre; } set { nombre = value; } }
        public int Lineas { get { return lineas; } set { lineas = value; } }
        public Estructura Estructuras { get { return estructuras; } set { estructuras = value; } }
    }
}