using Solution;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solution
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class SolutionTest
    {
        private ICalculate _calculate;

        [Test]
        public void StaticTests()
        {

            Assert.AreEqual(Program.basicOp('+', 4, 7), 11);
            Assert.AreEqual(Program.basicOp('-', 15, 18), -3);
            Assert.AreEqual(Program.basicOp('*', 5, 5), 25);
            Assert.AreEqual(Program.basicOp('/', 49, 7), 7);
        }

        [Test]
        public void AddTest()
        {
            _calculate = new Calculate();
            Assert.AreEqual(expected: _calculate.Add(4, 7), 11);
        }

        [Test]
        public void SubtractTest()
        {
            _calculate = new Calculate();
            Assert.AreEqual(expected: _calculate.Subtract(15, 18), -3);
        }

        [Test]
        public void MultiplyTest()
        {
            _calculate = new Calculate();
            Assert.AreEqual(expected: _calculate.Multiply(5, 5), 25);
        }

        [Test]
        public void DivideTest()
        {
            _calculate = new Calculate();
            Assert.AreEqual(expected: _calculate.Divide(49, 7), 7);
        }


    }
}