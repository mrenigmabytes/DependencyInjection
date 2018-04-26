using System;
using System.Collections.Generic;
using System.Text;

namespace DI.ServiceLayer.Interfaces
{
    public interface ITestServiceA : IDisposable
    {
        void ProcessData();
    }
}
