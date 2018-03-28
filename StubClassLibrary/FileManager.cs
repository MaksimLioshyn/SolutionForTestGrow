using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StubClassLibrary.DataObjects;
[assembly: InternalsVisibleTo("StubClassLibraryTests")]


namespace StubClassLibrary
{
    class FileManager
    {
        private IDataAccessObject _dataAccessObject;

        public FileManager()
        {
            _dataAccessObject = new FileDataObject();
        }

        public FileManager(IDataAccessObject dataAccessObject)
        {
            _dataAccessObject = dataAccessObject;
        }

        public bool FindLogFile(string fileName)
        {
            List<string> files = _dataAccessObject.GetFiles();

            foreach (var file in files)
            {
                if (file.Contains(fileName))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
