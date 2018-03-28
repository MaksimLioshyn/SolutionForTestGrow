using LibraryForUnitTestingBasics;
using NUnit.Framework;

namespace LibraryForUnitTestingBasicsTests
{
    [TestFixture]
    public class CalculateClassTests
    {
        [TestCase(10, 20, ExpectedResult = 30)]
        public double SumTest(double x, double y)
        {
            return CalculateClass.Sum(x, y);
        }
    }
}