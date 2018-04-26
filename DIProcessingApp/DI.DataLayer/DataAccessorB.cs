using DI.DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DI.DataLayer
{
    public class DataAccessorB : IDataAccessorB
    {
        public DataAccessorB()
        {
            Console.WriteLine("%% Loaded DataAccessorB %%");
        }

        public string GetSampleData()
        {
            return "Sample Data From DataAccessorB";
        }

        public Guid GetUserID()
        {
            return Guid.NewGuid();
        }

        public void Dispose()
        {
            Console.WriteLine("%% Disposing DataAccessorB %%");
        }
    }
}
