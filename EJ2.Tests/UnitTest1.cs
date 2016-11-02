using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EJ2;

namespace EJ2.Tests
{
    [TestClass]
    public class UnitMatematica
    {
        [TestMethod]
        public void TestDivisionPorCero()
        {
            Matematica mat = new Matematica();
            
            int div = 10;
            int num = 0;
            double resul = mat.Dividir(div, num);
            Assert.AreSame(new DivisionPorCeroExcepcion(), resul);
        }
    }
}
