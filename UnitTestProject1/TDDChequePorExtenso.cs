using System;
using Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class TDDChequePorExtenso
    {
        [TestMethod]
        public void Ler0PorExtenso()
        {
            var cheque = new ChequePorExtenso();
            String resultado = cheque.lerPorExtenso(0);
            Assert.AreEqual("Valor inválido!", resultado);
        }

        [TestMethod]
        public void LerNegativo()
        {
            var cheque = new ChequePorExtenso();
            String resultado = cheque.lerPorExtenso(-100.10);
            Assert.AreEqual("Valor inválido!", resultado);
        }

        [TestMethod]
        public void Ler5Centavos()
        {
            var cheque = new ChequePorExtenso();
            String resultado = cheque.lerPorExtenso(0.05);
            Assert.AreEqual("Cinco Centavos", resultado);
        }

        [TestMethod]
        public void Ler1RealE10Centavos()
        {
            var cheque = new ChequePorExtenso();
            String resultado = cheque.lerPorExtenso(1.10);
            Assert.AreEqual("Um Real e Dez Centavos", resultado);
        }

        [TestMethod]
        public void Ler23ReaisE50Centavos()
        {
            var cheque = new ChequePorExtenso();
            String resultado = cheque.lerPorExtenso(23.50);
            Assert.AreEqual("Vinte e Três Reais e Cinquenta Centavos", resultado);
        }

        [TestMethod]
        public void Ler333ReaisE75Centavos()
        {
            var cheque = new ChequePorExtenso();
            String resultado = cheque.lerPorExtenso(333.75);
            Assert.AreEqual("Trezentos e Trinta e Três Reais e Setenta e Cinco Centavos", resultado);
        }

        [TestMethod]
        public void Ler1MilhãoEMeio()
        {
            var cheque = new ChequePorExtenso();
            String resultado = cheque.lerPorExtenso(1500000);
            Assert.AreEqual("Um Milhão e Quinhentos Mil Reais", resultado);
        }

        [TestMethod]
        public void Ler550Bilhões323Milhões500MilE70Centavos()
        {
            var cheque = new ChequePorExtenso();
            String resultado = cheque.lerPorExtenso(550323500000.70);
            Assert.AreEqual("Quinhentos e Cinquenta Bilhões e Trezentos e Vinte e Três Milhões e Quinhentos Mil Reais e Setenta Centavos", resultado);
        }
    }
}