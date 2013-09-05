using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WP_Trabalho_01.Questao05;

namespace Unit_Tests
{
    [TestClass]
    public class Questao_05_Conta_Corrente_Test
    {
        [TestMethod]
        public void test_OptionalParamInConstructor_ContaCorrente()
        {
            ContaCorrente contaSemSaldo = new ContaCorrente(12345L, "Leandro");

            Assert.AreEqual(12345L, contaSemSaldo.numeroConta);
            Assert.AreEqual("Leandro", contaSemSaldo.nomeCorrentista);

            ContaCorrente contaComSaldo = new ContaCorrente(12345L, "Leandro",200000.0f);

            Assert.AreEqual(12345L, contaComSaldo.numeroConta);
            Assert.AreEqual("Leandro", contaComSaldo.nomeCorrentista);
            Assert.AreEqual(200000.0f, contaComSaldo.saldo);
        }
    }
}
