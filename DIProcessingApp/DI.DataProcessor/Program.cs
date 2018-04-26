using DI.Common.DIComponents;
using DI.DataLayer;
using DI.ServiceLayer;
using DI.ServiceLayer.Interfaces;
using System;

namespace DI.DataProcessor
{
    /// <summary>
    /// This is the entry point of our appliaction. We will mimic a standalone backend microservice 
    /// through here. You should use this as a guide as to utilizing any type of dependency injection framework.
    /// Our interest is in learning the concepts not copying a particular implementation.
    /// Avoid copy and pasting the code, use it to learn and modify it to create something completely different.
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("----- Data Processing APP -----");

            //You usually Initialize the DI Injector at the highest level of the application. Usually in the singleton instance
            //that is storing the main application itself or an equivalent Global Init/Configuration secton of your application.
            DIInjector.InitializeInjector(DIDataAccessorRegistrations.Register, DIServiceRegistrations.Register);

            //The chain of Dependency events begins by calling the 'Get<T>' method of our custom injector. This will resolve
            //the interface and all dependencies it might have down the chain. A class should be a black box and for the most 
            //part should not depend on speficif data to run... we can give it a handle to an external toolset. 
            //this is the concept between loose coupling or 'Inversion of Control'
            //the 'using' statement is a C# construct that automatically calls the 'Dispose' method of the instantiated class.
            //it allows us to mananage resources efficiently and not soley relying on the garbage collector. 
            //This is how the dispose method of TestServiceA is called which subsequently calls dispose method of accessorA.
            //It is what is called the 'Dispose pattern'
            using (var _testServiceA = DIInjector.Get<ITestServiceA>())
                _testServiceA.ProcessData();

            using (var _testServiceB = DIInjector.Get<ITestServiceB>())
                _testServiceB.ProcessData();
        }


    }
}
