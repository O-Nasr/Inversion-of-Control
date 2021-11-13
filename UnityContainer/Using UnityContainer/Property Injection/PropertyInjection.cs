using Microsoft.Practices.Unity;
using Unity_Container.CarExmaple;

namespace Unity_Container.Using_UnityContainer.Property_Injection
{
    public  class PropertyInjection
    {
        //https://www.tutorialsteacher.com/ioc/property-injection-using-unity-container
        public static void MainTest()
        {
            /*var container = new UnityContainer();
            container.RegisterType<ICar, BMW>();

            var driver = container.Resolve<Property_Injection.Driver>();
            driver.RunCar();*/


            /////////////////////Named Mapping
            ///

            /*var container = new UnityContainer();
            container.RegisterType<ICar, Audi>("LuxuryCar");
            container.RegisterType<ICar, BMW>();

            var driver = container.Resolve<Driver>();
            driver.RunCar();*/

            /////////////////Run-time Configuration
            ///

            var container = new UnityContainer();

            //run-time configuration
            container.RegisterType<Driver>(new InjectionProperty("Car", new BMW()));

            var driver = container.Resolve<Driver>();
            driver.RunCar();
        }
    }
}
