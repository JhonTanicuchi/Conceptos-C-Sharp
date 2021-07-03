namespace Test.Herencia
{
    class Rectangulo : Figura
    {
        public float Base { get; set; }
        public float Altura { get; set; }
        public override float Area()
        {
            return Base * Altura;
        }
    }
}