using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WP_Trabalho_01.Questao04;

namespace Unit_Tests
{
    [TestClass]
    public class Questao_04_Pessoa_Test
    {
        [TestMethod]
        public void testCrescimento_Pessoa()
        {
            Pessoa joao = new Pessoa("Joao", 15, 60.0f, 165.0f);
            joao.envelhecer();

            Assert.AreEqual(165.5f, joao.altura);
            Assert.AreEqual(16, joao.idade);

            joao.envelhecer(); //166.0
            joao.envelhecer(); //166.5
            joao.envelhecer(); //167.0
            joao.envelhecer(); //167.5
            joao.envelhecer(); //168.0 

            Assert.AreEqual(168.0f, joao.altura);
            Assert.AreEqual(21, joao.idade);

            joao.envelhecer(); //168.0 
            joao.envelhecer(); //168.0 

            Assert.AreEqual(168.0f, joao.altura);
            Assert.AreEqual(23, joao.idade);

        }
    }
}
