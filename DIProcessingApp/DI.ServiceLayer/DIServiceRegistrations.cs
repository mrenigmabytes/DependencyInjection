using DI.ServiceLayer.Interfaces;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DI.ServiceLayer
{
    public static class DIServiceRegistrations
    {
        /// <summary>
        /// Static Register method passed to container at init in order to do 
        /// app wide registration of our class libraries. 
        /// </summary>
        /// <param name="container"></param>
        public static void Register(this IUnityContainer container)
        {
            //The 'RegisterType' method allows us to send a mapping of interfaces to concrete implementations
            //this is in essence the building blocks of the 'factory pattern'.
            container.RegisterType<ITestServiceA, TestServiceA>();
            container.RegisterType<ITestServiceB, TestServiceB>();
        }
    }
}
