using System.Collections.Generic;

namespace StubClassLibrary.DataObjects
{
    public interface IDataAccessObject
    {
        List<string> GetFiles();
    }
}