﻿using System;
using NUnit.Framework;
using ooh_calc.OneArgument;

namespace ooh_calc.Tests.OneArgument
{
    [TestFixture]
    public class SqrtTest
    {
        [TestCase(121,11)]
        [TestCase(4, 2)]
        public void BasicTestSqrt(double first, double expected)
        {
            ISingleCalculator calculator = new Sqrt();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected,result);
        }

        [Test]
        public void ExceptionTest()
        {
            ISingleCalculator calculator = new Sqrt();
            Assert.Throws<ArgumentException>(() => calculator.Calculate(-10));
        }
    }
}