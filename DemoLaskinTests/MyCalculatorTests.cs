using Microsoft.VisualStudio.TestTools.UnitTesting;
using JAMK.IT.Laskin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT.Laskin.Tests
{
    [TestClass()]
    public class MyCalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            int i = 10;
            int j = 12;
            int tulos = 22;
            MyCalculator laskin = new MyCalculator();
            int summa = laskin.Add(i, j);
            Assert.AreEqual(tulos, summa);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            int i = 10;
            int j = 12;
            int tulos = 120;
            MyCalculator laskin = new MyCalculator();
            int summa = laskin.Multiply(i, j);
            Assert.AreEqual(tulos, summa);
        }
    }
}