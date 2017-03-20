using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.Tests
{
    [TestFixture]
    public class NewtonMethodTests
    {
        [TestCase(2.12532, 3, 0.0001, ExpectedResult = 1.2857)]
        [TestCase(134.1324, 10, 0.000001, ExpectedResult = 1.632125)]
        [TestCase(-12345.42512, 5, 0.00001, ExpectedResult = -6.58114)]
        [TestCase(9, 3, 0.0001, ExpectedResult = 2.0801)]
        public double ComputeNthRoot_PassedValidArguments_ExpectedPositiveTest(double number, int power, double eps)
        {
            return NewtonMethod.ComputeNthRoot(number, power, eps);
        }

        [TestCase(81, 4, 2.0001)]
        [TestCase(-125, -3, 0.00001)]
        public void ComputeNthRoot_PassedIncorrectEpsilonOrNegativePower_ThrowsArgumentOutOfRangeException(double number, int power, double eps)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => NewtonMethod.ComputeNthRoot(number, power, eps));
        }

        [TestCase(-16, 4, 0.00001)]
        [TestCase(-25, 2, 0.00001)]
        public void ComputeNthRoot_PassedNegativeNumberWithEvenPower_ThrowsArgumentException(double number, int power, double eps)
        {
            Assert.Throws<ArgumentException>(() => NewtonMethod.ComputeNthRoot(number, power, eps));
        }
    }
}
