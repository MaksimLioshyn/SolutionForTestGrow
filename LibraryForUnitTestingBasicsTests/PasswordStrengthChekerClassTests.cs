using LibraryForUnitTestingBasics;
using NUnit.Framework;

namespace LibraryForUnitTestingBasicsTests
{
    [TestFixture]
    public class PasswordStrengthChekerClassTests
    {
        [TestCase("P2ssw0rd#", ExpectedResult = 5)]
        [TestCase("Password", ExpectedResult = 3)]
        [TestCase("Passw0rd", ExpectedResult = 4)]
        [TestCase("Passw0rd@", ExpectedResult = 5)]
        public int GetPasswordStrengthTest(string password)
        {
            return PasswordStrengthChekerClass.GetPasswordStrength(password);
        }
    }
}