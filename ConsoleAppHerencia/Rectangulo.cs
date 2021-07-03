namespace ConsoleAppHerencia
{
    class Rectangulo
    {
        public float Base { get; set; }
        public float Altura { get; set; }
        public float Area()
        {
            return Base * Altura;
        }
    }
}