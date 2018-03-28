using System;
using LibraryForUnitTestingBasics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibraryForUnitTestingBasicsTestsMSTest
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
            double actual = new CalculateClass().Sum(x, y);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Add_2_3_Returns_5()
        {
            // arrange
            double x = 2;
            double y = 3;
            double expected = 5;

            // act
            double actual = new CalculateClass().Sum(x, y);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Div_10_2_Returns_5()
        {
            // arrange
            int x = 10;
            int y = 2;
            int expected = 5;

            // act
            int actual = new CalculateClass().Div(x, y);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Div_10_0_ExceptionExpected()
        {
            // arrange
            int x = 10;
            int y = 0;

            // act
            int actual = new CalculateClass().Div(x, y);
        }
    }
}