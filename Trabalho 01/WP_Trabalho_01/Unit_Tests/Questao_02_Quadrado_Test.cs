using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WP_Trabalho_01.Questao02;

namespace Unit_Tests
{
    [TestClass]
    public class Questao_02_Quadrado_Test
    {
        [TestMethod]
        public void testaGetSet()
        {
            Quadrado quadrado = new Quadrado();
            Assert.AreEqual(0.0f, quadrado.retornaValorLado());

            quadrado.mudarValorLado(2.0f);
            Assert.AreEqual(2.0f, quadrado.retornaValorLado());
        }

        [TestMethod]
        public void testAreaQuadrado()
        {
            Quadrado quadrado = new Quadrado();
            quadrado.mudarValorLado(3.0f);
            Assert.AreEqual(9.0f, quadrado.calculaArea());
        }
    }
}
