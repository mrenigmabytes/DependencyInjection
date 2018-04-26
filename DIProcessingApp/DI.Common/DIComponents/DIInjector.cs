using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Practices.Unity;
using DI.Common.Extensions;

namespace DI.Common.DIComponents
{
    public static class DIInjector
    {
        private static IUnityContainer InjectorContainer { get; set; }

        /// <summary>
        /// We pass a delegate to the registration of interfaces that we will use upon initialization of our 
        /// dependency injection container. For each item we then pass the container for further initialization.
        /// </summary>
        /// <param name="registeredInterfaces"></param>
        public static void InitializeInjector(params Action<IUnityContainer>[] registeredInterfaces)
        {
            if (InjectorContainer == null)
                InjectorContainer = new UnityContainer();

            foreach (var registration in registeredInterfaces)
                registration(InjectorContainer);
        }

        /// <summary>
        /// This staic method takes care of executing the first resolve of our workflow. 
        /// We use a generic type here because we want to accept any type and try to resolve it.
        /// Generic is key.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="requestedInterfaceParms"></param>
        /// <returns></returns>
        public static T Get<T>(IDictionary<string, object> requestedInterfaceParms = null)
        {
            try
            {
                var overrides = !requestedInterfaceParms.IsNullOrEmpty()
                    ? requestedInterfaceParms.Select(p => new ParameterOverride(p.Key, p.Value)).ToArray()
                    : new ParameterOverride[0];

                return InjectorContainer.Resolve<T>(overrides);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
