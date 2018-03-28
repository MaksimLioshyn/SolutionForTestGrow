using Microsoft.VisualStudio.TestTools.UnitTesting;
using StubClassLibrary;
using StubClassLibrary.DataObjects;

namespace StubClassLibraryTests
{
    [TestClass()]
    public class FileManagerTests
    {
        [TestMethod]
        public void FileManager_FindFileLogByName()
        {
            IDataAccessObject accessObject = new StubFileDataObject();
            FileManager fileManager = new FileManager(accessObject);
            string fileName = "main.log";

            bool exists = fileManager.FindLogFile(fileName);

            Assert.IsTrue(exists, "File {0} was not found.", fileName);
        }
    }
}