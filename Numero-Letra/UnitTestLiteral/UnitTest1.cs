using Microsoft.VisualStudio.TestTools.UnitTesting;
using Numero_Letra.Controllers;
using System.Linq.Expressions;

namespace UnitTestLiteral
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int a = 4;
            string expected = "CUATRO PESOS 00 /100";

            //ACT
            LiteralController literalController = new LiteralController();
            string resultado = literalController.LiteralGet(a);

            //Assert
            Assert.AreEqual(expected, resultado);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            int a = 10;
            string expected = "DIEZ PESOS 00 /100";

            //ACT
            LiteralController literalController = new LiteralController();
            string resultado = literalController.LiteralGet(a);

            //Assert
            Assert.AreEqual(expected, resultado);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            int a = 100;
            string expected = "CIEN PESOS 00 /100";

            //ACT
            LiteralController literalController = new LiteralController();
            string resultado = literalController.LiteralGet(a);

            //Assert
            Assert.AreEqual(expected, resultado);
        }
    }
}
