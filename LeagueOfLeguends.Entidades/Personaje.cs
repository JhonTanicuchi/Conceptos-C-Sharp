namespace LeagueOfLeguends.Entidades
{
    public abstract class Personaje
    {
        string nombre;
        int vida;

        double regeneracionVida;
        double armadura;
        double resistenciaMagica;
        double dañoAtaque;
        double velocidadAtaque;
        double velocidadMovimiento;
        double rango;
        double recompensaOro;
        double recompensaExperiencia;

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public int Vida { get => vida; set => vida = value; }

        public double RegeneracionVida { get { return regeneracionVida; } set { regeneracionVida = value; } }
        public double Armadura { get { return armadura; } set { armadura = value; } }
        public double ResistenciaMagica { get { return resistenciaMagica; } set { resistenciaMagica = value; } }
        public double DañoAtaque { get { return dañoAtaque; } set { dañoAtaque = value; } }
        public double VelocidadAtaque { get { return velocidadAtaque; } set { velocidadAtaque = value; } }
        public double VelocidadMovimiento { get { return velocidadMovimiento; } set { velocidadMovimiento = value; } }
        public double Rango { get { return rango; } set { rango = value; } }
        public double RecompensaOro { get { return recompensaOro; } set { recompensaOro = value; } }
        public double RecompensaExperiencia { get { return recompensaExperiencia; } set { recompensaExperiencia = value; } }

    }
}