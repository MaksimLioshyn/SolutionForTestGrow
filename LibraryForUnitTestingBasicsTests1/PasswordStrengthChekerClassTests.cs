using LibraryForUnitTestingBasics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibraryForUnitTestingBasicsTests1
{
    [TestClass]
    public class PasswordStrengthChekerClassTests
    {
        [TestMethod]
        public void GetPasswordStrength_AllCahrs_5Points()
        {
            // arrange
            string password = "P2ssw0rd#";
            int expected = 5;

            // act
            int actual = PasswordStrengthChekerClass.GetPasswordStrength(password);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetPasswordStrength_UpperCase_3Points()
        {
            // Arrange
            string password = "Password";
            int expected = 3; 

            // Act
            int actual = PasswordStrengthChekerClass.GetPasswordStrength(password);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetPasswordStrength_ConteinsNumber_4Points()
        {
            // Arrange
            string password = "Passw1rd";
            int expected = 4;

            // Act
            int actual = PasswordStrengthChekerClass.GetPasswordStrength(password);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetPasswordStrength_ContainsSpecialChar_at_5Points()
        {
            // Arrange
            string password = "Passw0rd@";
            int expected = 5;

            // Act
            int actual = PasswordStrengthChekerClass.GetPasswordStrength(password);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetPasswordStrength_ContainsSpecialChar_5Points()
        {
            // Arrange
            string password = "Passw0rd$";
            int expected = 5;

            // Act
            int actual = PasswordStrengthChekerClass.GetPasswordStrength(password);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}