using DI.DataLayer.Interfaces;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DI.DataLayer
{
    public static class DIDataAccessorRegistrations
    {
        public static void Register(this IUnityContainer container)
        {
            container.RegisterType<IDataAccessorA, DataAccessorA>();
            container.RegisterType<IDataAccessorB, DataAccessorB>();
        }
    }
}
