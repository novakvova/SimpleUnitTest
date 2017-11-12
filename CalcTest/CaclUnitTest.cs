using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace CalcTest
{
    [TestClass]
    public class CaclUnitTest
    {
        [TestMethod]
        public void TestAdd()
        {
            Calculation calc = new Calculation();
            int result = Calculation.Add(23,0);
            Assert.AreEqual(result, 23);
            result = Calculation.Add(34, 23);
            Assert.AreEqual(result, 57);
        }
    }
}
