using Microsoft.Practices.Unity;
using Unity_Container.CarExmaple;

namespace Unity_Container.Using_UnityContainer
{
    public class Constructor_Injection
    {
        public static void MainTest()
        {
            //https://www.tutorialsteacher.com/ioc/constructor-injection-using-unity-container
            IUnityContainer container = new UnityContainer();

            //////////////////////////////////////////////////////////////////////////////////////////
            ///

           /* container.RegisterType<ICar, Audi>();
            container.RegisterType<ICarKey, AudiKey>();

            ICar car = container.Resolve<ICar>();
            ICarKey key = container.Resolve<ICarKey>();

            container.RegisterType<Driver>(new InjectionConstructor(car, key)); // You can configure the same thing as above at run time instead of applying the [InjectionConstructor]

            Driver driver = container.Resolve<Driver>();

            driver.RunCar();*/

            //////////////////////////////////////////////////////////////////////////////
            ///Primitive Type Parameter
            ///

            container.RegisterType<Driver>(new InjectionConstructor(new object[] { new Audi(), "Steve" }));

            var driver = container.Resolve<Driver>();
            driver.RunCar();



        }
    }
}
