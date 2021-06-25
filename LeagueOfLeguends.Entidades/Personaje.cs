namespace LeagueOfLeguends.Entidades
{
    public abstract class Personaje
    {       
        public string Nombre { get; set; }
        public int Vida { get; set; }
        public double RegeneracionVida { get; set; }
        public double Armadura { get; set; }
        public double ResistenciaMagica { get; set; }
        public double DañoAtaque { get; set; }
        public double VelocidadAtaque { get; set; }
        public double VelocidadMovimiento { get; set; }
        public double Rango { get; set; }
        public double RecompensaOro { get; set; }
        public double RecompensaExperiencia { get; set; }
    }
}