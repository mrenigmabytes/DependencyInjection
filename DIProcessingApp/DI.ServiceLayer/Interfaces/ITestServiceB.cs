using System;
using System.Collections.Generic;
using System.Text;

namespace DI.ServiceLayer.Interfaces
{
    public interface ITestServiceB : IDisposable
    {
        void ProcessData();
    }
}
