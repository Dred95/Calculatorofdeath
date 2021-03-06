﻿using CalculatorOfDeath.BinaryOperations;
using NUnit.Framework;

namespace CalculatorOfDeath.Tests.BinaryOperations
{
    [TestFixture] 
    public class AdderTests
    {
        [Test]
        public void AddTest()
        {
            IBinaryCalculator calculator = BinaryOperationFactory.Create("Adder");
            double result = calculator.Calculate(3, 7);
            Assert.AreEqual(10, result);
        }
    }

}
