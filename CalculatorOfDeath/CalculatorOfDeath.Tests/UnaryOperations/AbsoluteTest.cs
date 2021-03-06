﻿using CalculatorOfDeath.UnaryOperations;
using NUnit.Framework;

namespace CalculatorOfDeath.Tests.UnaryOperations
{
    [TestFixture]
    public class AbsoluteTests
    {
        [Test]
        public void AbsoluteTest()
        {
            IUnaryCalculator calculator = UnaryOperationFactory.Create("Absolute");
            double result = calculator.Calculate(-2);
            Assert.AreEqual(2, result);
        }
    }

}
