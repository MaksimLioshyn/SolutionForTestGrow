using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace StubClassLibrary.DataObjects
{
    public class FileDataObject : IDataAccessObject
    {
        public List<string> GetFiles()
        {
            string path = Directory.GetCurrentDirectory();

            DirectoryInfo d = new DirectoryInfo(path);

            FileInfo[] files = d.GetFiles();

            return files.Select(file => file.Name).ToList();
        }
    }
}