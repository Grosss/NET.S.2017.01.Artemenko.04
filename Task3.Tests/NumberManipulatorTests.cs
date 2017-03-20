using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Tests
{
    [TestFixture]
    public class NumberManipulatorTests
    {
        [TestCase(12, ExpectedResult = 21)]
        [TestCase(513, ExpectedResult = 531)]
        [TestCase(2017, ExpectedResult = 2071)]
        [TestCase(414, ExpectedResult = 441)]
        [TestCase(144, ExpectedResult = 414)]
        [TestCase(1234321, ExpectedResult = 1241233)]
        [TestCase(1234126, ExpectedResult = 1234162)]
        [TestCase(3456432, ExpectedResult = 3462345)]
        [TestCase(10, ExpectedResult = -1)]
        [TestCase(20, ExpectedResult = -1)]
        public int MakeNumberBigger_PassedPositiveNumber_ExpectedPositiveTest(int number)
        {
            return NumberManipulator.MakeNumberBigger(number);
        }

        [TestCase(-1)]
        [TestCase(7)]
        public void MakeNumberBigger_PassedNegativeNumberOrDigit_ThrowsArgumentOutOfRangeException(int number)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => NumberManipulator.MakeNumberBigger(number));
        }
    }
}
