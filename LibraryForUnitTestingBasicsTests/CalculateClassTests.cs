using LibraryForUnitTestingBasics;
using NUnit.Framework;

namespace LibraryForUnitTestingBasicsTests
{
    [TestFixture]
    public class CalculateClassTests
    {
        [TestCase(10, 20, ExpectedResult = 30)]
        [TestCase(20, 20, ExpectedResult = 40)]
        [TestCase(30, 20, ExpectedResult = 50)]
        [TestCase(40, 20, ExpectedResult = 60)]
        public double SumTest(double x, double y)
        {
            return new CalculateClass().Sum(x, y);
        }


        [TestCase(10, 20, ExpectedResult = 0)]
        [TestCase(20, 20, ExpectedResult = 1)]
        [TestCase(30, 20, ExpectedResult = 1)]
        [TestCase(40, 20, ExpectedResult = 2)]
        public int DivTest(int x, int y)
        {
            return new CalculateClass().Div(x, y);
        }
    }
}