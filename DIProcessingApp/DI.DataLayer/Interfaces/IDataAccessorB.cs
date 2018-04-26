using System;
using System.Collections.Generic;
using System.Text;

namespace DI.DataLayer.Interfaces
{
    public interface IDataAccessorB : IDisposable
    {
        string GetSampleData();
        Guid GetUserID();
    }
}
