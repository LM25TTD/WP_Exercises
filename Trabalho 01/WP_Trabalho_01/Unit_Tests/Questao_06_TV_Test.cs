using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WP_Trabalho_01.Questao06;

namespace Unit_Tests
{
    [TestClass]
    public class Questao_06_TV_Test
    {
        [TestMethod]
        public void testVolume_TV()
        {
            TV tv = new TV();
            tv.canal = 50;
            tv.volume = 50;
            Assert.AreEqual(50, tv.canal);
            Assert.AreEqual(50, tv.volume);

            tv.canal = -1;
            tv.volume = -1;
            Assert.AreEqual(1, tv.canal);
            Assert.AreEqual(0, tv.volume);

            tv.canal = 1002;
            tv.volume = 102;
            Assert.AreEqual(1000, tv.canal);
            Assert.AreEqual(100, tv.volume);

        }
    }
}
