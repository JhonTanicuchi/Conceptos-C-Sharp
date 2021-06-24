namespace LeagueOfLeguends.Entidades
{
    public class Subdito : Personaje
    {
        string tipo;
        double tiempoRegeneracion;
        double tiempoInicial;

        public string Tipo { get { return tipo; } set { tipo = value; } }
        public double TiempoRegeneracion { get { return tiempoRegeneracion; } set { tiempoRegeneracion = value; } }
        public double TiempoInicial { get { return tiempoInicial; } set { tiempoInicial = value; } }
    }
}