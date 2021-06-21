namespace GameLeagueOfLeguends
{
    public class Habilidad
    {
        string tecla;
        string descripcion;
        decimal daño;
        decimal enfriamiento;

        internal string Tecla { get { return tecla; } set { tecla = value; } }
        internal string Descripcion { get { return descripcion; } set { descripcion = value; } }
        internal decimal Daño { get { return daño; } set { daño = value; } }
        internal decimal Enfriamiento { get { return enfriamiento; } set { enfriamiento = value; } }
    }
}