namespace Test.Herencia
{
    class Cuadrado1 : Figura
    {
        public float Lado { get; set; }

        public override float Area()
        {
            return Lado * Lado;
        }
    }
}