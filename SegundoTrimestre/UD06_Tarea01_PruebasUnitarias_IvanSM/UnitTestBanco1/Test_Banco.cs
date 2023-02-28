using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UD06_Tarea01_PruebasUnitarias_IvanSM;

namespace UnitTestBanco1
{
    [TestClass]
    public class Test_Banco
    {
        [TestMethod]
        public void Test_IngresoSaldo()
        {
            // Arrange: Inicializa las variables
            double saldoInicial = 1500;
            double saldoEsperado = 1500;
            Cliente c = new Cliente("Amelio");

            // Act: Llamamos a los metodos para calcular
            c.ingresarSaldo(saldoInicial);

            // Assert: Comprobamos los resultados
            double actual = c.saldoTotal;
            Assert.AreEqual(saldoEsperado, actual);
        }

        [TestMethod]
        public void Test_RetirarSaldo()
        {
            // Arrange: Inicializa las variables
            double saldoInicial = 1500;
            double saldoRetirar = 500;
            double saldoEsperado = 1000;
            Cliente c = new Cliente("Sesilia");

            // Act: Llamamos a los metodos para calcular
            c.ingresarSaldo(saldoInicial);
            c.retirarSaldo(saldoRetirar);

            // Assert: Comprobamos los resultados
            double actual = c.saldoTotal;
            Assert.AreEqual(saldoEsperado, actual);
        }

        [TestMethod]
        public void Test_RetirarMasSaldoPermitido()
        {
            // Arrange: Inicializa las variables
            double saldoInicial = 1500;
            double saldoRetirar = 3000;
            double saldoEsperado = 0;
            Cliente c = new Cliente("Rogelio");

            // Act: Llamamos a los metodos para calcular
            c.ingresarSaldo(saldoInicial);
            c.retirarSaldo(saldoRetirar);

            // Assert: Comprobamos los resultados
            double actual = c.saldoTotal;
            Assert.AreEqual(saldoEsperado, actual);
        }

    }
}
