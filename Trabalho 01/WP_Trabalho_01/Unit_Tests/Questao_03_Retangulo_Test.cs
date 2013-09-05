using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WP_Trabalho_01.Questao03;

namespace Unit_Tests
{
    [TestClass]
    public class Questao_03_Retangulo_Test
    {
        [TestMethod]
        public void testEmpty_Retangulo()
        {
            Retangulo retangulo = new Retangulo();
            Assert.AreEqual(0.0f, retangulo.calculaArea());
            Assert.AreEqual(0.0f, retangulo.calculaPerimetro());
        }

        [TestMethod]
        public void testConstructor_Retangulo()
        {
            Retangulo retangulo = new Retangulo(2.0f, 8.0f);
            Assert.AreEqual(16.0f, retangulo.calculaArea());
            Assert.AreEqual(20.0f, retangulo.calculaPerimetro());
        }


    }
}
