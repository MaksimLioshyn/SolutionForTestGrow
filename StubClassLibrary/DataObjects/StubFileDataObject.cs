using System.Collections.Generic;

namespace StubClassLibrary.DataObjects
{
    public class StubFileDataObject : IDataAccessObject
    {
        public List<string> GetFiles()
        {
            List<string> list = new List<string> {"file1.txt", "file2.log", "file3.exe", "main.log"};

            return list;
        }
    }
}
