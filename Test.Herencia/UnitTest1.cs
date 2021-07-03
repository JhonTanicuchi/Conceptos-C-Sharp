using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Herencia
{
    [TestClass]
    public class CuandoHeredoCuadradoDeRectangulo
    {
        [TestMethod]
        public void EntoncesElAreaFunciona()
        {
            //Arrage
            var alturaRectangulo = 10f;
            var BaseRectangulo = 3f;
            var areaEsperada = 9;

            //Act
            var cuadrado = new Cuadrado()
            {
                Altura = alturaRectangulo,
                Base = BaseRectangulo
            };
            var areaActual = cuadrado.Area();

            //Assert
            Assert.AreEqual(areaEsperada, areaActual);
        }
    }
}
