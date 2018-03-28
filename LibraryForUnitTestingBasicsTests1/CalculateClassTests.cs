using LibraryForUnitTestingBasics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibraryForUnitTestingBasicsTests1
{
    [TestClass()]
    public class CalculateClassTests
    {
        [TestMethod()]
        public void SumTest()
        {
            // arrange
            double x = 10;
            double y = 20;
            double expected = 30;

            // act
            double actual = CalculateClass.Sum(x, y);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}