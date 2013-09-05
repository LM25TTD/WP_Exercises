using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WP_Trabalho_01.Questao01;

namespace Unit_Tests
{
    [TestClass]
    public class Questao_01_Bola_Test
    {
        [TestMethod]
        public void testColor_Bola()
        {
            Bola bola = new Bola();
            
            bola.trocaCor("Azul");
            Assert.AreEqual("Azul", bola.mostraCor());
            bola.trocaCor("Vermelho");
            Assert.AreEqual("Vermelho", bola.mostraCor());
         }
    }
}
