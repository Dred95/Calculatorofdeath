﻿using CalculatorOfDeath.UnaryOperations;
using NUnit.Framework;

namespace CalculatorOfDeath.Tests.UnaryOperations
{
    [TestFixture]
    public class PiNTests
    {
        [Test]
        public void PiNTest()
        {
            IUnaryCalculator calculator = UnaryOperationFactory.Create("PiN");
            double result = calculator.Calculate(1);
            Assert.AreEqual(3.14159, result);
        }
    }
}
