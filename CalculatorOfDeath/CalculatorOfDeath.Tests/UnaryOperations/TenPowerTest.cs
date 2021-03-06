﻿using CalculatorOfDeath.UnaryOperations;
using NUnit.Framework;

namespace CalculatorOfDeath.Tests.UnaryOperations
{
    [TestFixture]
    public class TenPowerTests
    {
        [Test]
        public void TenPowerTest()
        {
            IUnaryCalculator calculator = UnaryOperationFactory.Create("TenPower");
            double result = calculator.Calculate(3);
            Assert.AreEqual(1000, result);
        }
    }
}
