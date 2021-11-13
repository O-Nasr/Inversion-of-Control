using Microsoft.Practices.Unity;
using Unity_Container.CarExmaple;

namespace Unity_Container.Using_UnityContainer.Method_Injection
{
    public class MethodInjection
    {
        public static void MainTest()
        {
            /*var container = new UnityContainer();
            container.RegisterType<ICar, BMW>();

            var driver = container.Resolve<Driver>();
            driver.RunCar();*/

            /////////////////////Run-time Configuration
            /// you can comment [InjectionMethod] in driver class

            var container = new UnityContainer();

            //run-time configuration
            container.RegisterType<Driver>(new InjectionMethod("UseCar", new Audi()));

            //to specify multiple parameters values
            //container.RegisterType<Driver>(new InjectionMethod("UseCar", new object[] { new Audi() }));

            var driver = container.Resolve<Driver>();
            driver.RunCar();
        }
    }
}
