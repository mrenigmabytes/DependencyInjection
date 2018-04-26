using System;
using System.Collections.Generic;
using System.Text;

namespace DI.DataLayer.Interfaces
{
    public interface IDataAccessorA : IDisposable
    {
        string GetSampleData();
        int GetId();
    }
}
