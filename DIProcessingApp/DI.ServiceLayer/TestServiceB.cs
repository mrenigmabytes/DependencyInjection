using DI.DataLayer.Interfaces;
using DI.ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DI.ServiceLayer
{
    public class TestServiceB : ITestServiceB
    {
        IDataAccessorB _dataAccessorB;

        public TestServiceB(IDataAccessorB dataAccessorB)
        {
            _dataAccessorB = dataAccessorB;
            Console.WriteLine(String.Format("Loaded TestServiceB with AccessorB hash={0}", _dataAccessorB.GetHashCode()));
        }

        public void ProcessData()
        {
            var data = _dataAccessorB.GetSampleData();
            var guid = _dataAccessorB.GetUserID();

            Console.WriteLine(String.Format("Fetched Sample data from B {0} with id={1}", data, guid.ToString()));
        }

        public void Dispose()
        {
            _dataAccessorB.Dispose();
            Console.WriteLine("%% Disposing TestServiceB %%");
        }
    }
}
