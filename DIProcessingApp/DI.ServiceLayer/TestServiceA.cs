using DI.DataLayer.Interfaces;
using DI.ServiceLayer.Interfaces;
using System;

namespace DI.ServiceLayer
{
    public class TestServiceA : ITestServiceA
    {
        private IDataAccessorA _dataAccessorA;

        /// <summary>
        /// TestServiceA uses an implementation of the interface/contract IDataAccessorA. We dont need specifics
        /// we just need an implementation that the dependency framework will take care of. If you follow the outputs
        /// of the application you will see that the implementation of dataAccessorA is created before this class is fully instantiated.
        /// </summary>
        /// <param name="dataAccessorA"></param>
        public TestServiceA(IDataAccessorA dataAccessorA)
        {
            _dataAccessorA = dataAccessorA;
            Console.WriteLine(String.Format("Loaded TestServiceA with AccessorA hash={0}", _dataAccessorA.GetHashCode()));
        }

        public void ProcessData()
        {
            var data = _dataAccessorA.GetSampleData();
            var id = _dataAccessorA.GetId();

            Console.WriteLine(String.Format("Fetched Sample data from A {0} with id={1}", data, id));
        }

        public void Dispose()
        {
            _dataAccessorA.Dispose();
            Console.WriteLine("%% Disposing TestServiceA %%");
        }
    }
}
