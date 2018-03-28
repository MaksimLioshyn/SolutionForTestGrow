using System;
using LibraryForUnitTestingBasics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibraryForUnitTestingBasicsTestsMSTest
{
    [TestClass()]
    public class UserManagerClassTests
    {
        public TestContext TestContext { get; set; }
        private UserManagerClass _manager = new UserManagerClass();

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "testData.xml",
            "User",
            DataAccessMethod.Sequential)]
        [TestMethod]
        public void UserManager_Add_FromXML()
        {
            string userId = Convert.ToString(TestContext.DataRow["userid"]);
            string telephone = Convert.ToString(TestContext.DataRow["telephone"]);
            string email = Convert.ToString(TestContext.DataRow["email"]);

            bool result = _manager.Add(userId, telephone, email);

            Assert.IsTrue(result, "Пользователь не может быть создан");
        }
    }
}