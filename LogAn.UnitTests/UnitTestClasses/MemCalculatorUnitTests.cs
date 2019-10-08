using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Unit_Testing_With_NUnit.Classes;

namespace LogAn.UnitTests.UnitTestClasses
{
    [TestFixture]
    public class MemCalculatorUnitTests
    {
        [Test]
        public void Sum_ByDefault_ReturnsZero()
        {
            MemCalculator calc = new MemCalculator();

            int lastSum = calc.Sum();

            Assert.AreEqual(0,lastSum);
        }

        [Test]
        public void Add_WhenCalled_ChangesSum()
        {
            MemCalculator calc = MakeCalc();

            calc.Add(1);
            int sum = calc.Sum();

            Assert.AreEqual(1,sum);
        }

        private static MemCalculator MakeCalc()
        {
            return new MemCalculator();
        }
    }
}
