namespace LeagueOfLeguends.Entidades
{
    public class Habilidad
    {
        string tecla;
        string nombre;
        string descripcion;
        double daño;
        double rango;
        double radio;
        double costoMana;
        double enfriamiento;
        double velocidad;

        public string Tecla { get { return tecla; } set { tecla = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }
        public double Daño { get { return daño; } set { daño = value; } }
        public double Rango { get { return rango; } set { rango = value; } }
        public double Radio { get { return radio; } set { radio = value; } }
        public double CostoMana { get { return costoMana; } set { costoMana = value; } }
        public double Enfriamiento { get { return enfriamiento; } set { enfriamiento = value; } }
        public double Velocidad { get { return velocidad; } set { velocidad = value; } }
    }
}