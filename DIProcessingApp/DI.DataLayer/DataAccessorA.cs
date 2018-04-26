using DI.DataLayer.Interfaces;
using System;

namespace DI.DataLayer
{
    public class DataAccessorA : IDataAccessorA
    {
        public DataAccessorA()
        {
            Console.WriteLine("%% Loaded DataAccessorA %%");
        }

        public int GetId()
        {
            return 12345;
        }

        public string GetSampleData()
        {
            return "This is the sample data from DataAccessorA";
        }

        public void Dispose()
        {
            Console.WriteLine("%% Disposing DataAccessorA %%");
        }
    }
}
