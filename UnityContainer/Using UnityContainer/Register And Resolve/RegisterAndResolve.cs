using Microsoft.Practices.Unity;
using Unity_Container.CarExmaple;


namespace Unity_Container.Using_UnityContainer.Register_And_Resolve
{
    public class RegisterAndResolve
    {
        public static void MainTest()
        {
            //https://www.tutorialsteacher.com/ioc/register-and-resolve-in-unity-container

            #region Noraml way
            /*Driver driver = new Driver(new BMW());

                driver.RunCar();*/
            #endregion


            IUnityContainer container = new UnityContainer();

            //Resolves dependencies and returns the Driver object

            //Unity container will create a new object and inject it every time we resolve the same type.

            /* container.RegisterType<ICar, BMW>();
             Driver driver1 = container.Resolve<Driver>();
             driver1.RunCar();

             Driver driver2 = container.Resolve<Driver>();
             driver2.RunCar();*/


            ///////////////////////////////////////////////////////////////
            //Multiple Registration

            /*container.RegisterType<ICar, BMW>();
            container.RegisterType<ICar, Audi>();

            Driver driver = container.Resolve<Driver>();
            driver.RunCar();*/


            ////////////////////////////////////////////////////////////////////
            ///Register Named Type
            ///

            /*
            container.RegisterType<ICar, BMW>();
            container.RegisterType<ICar, Audi>("LuxuryCar");

            ICar bmw = container.Resolve<ICar>(); // returns the BMW object
            ICar audi = container.Resolve<ICar>("LuxuryCar"); // returns the Audi object

            container.RegisterType<Driver>("LuxuryCarDriver", new InjectionConstructor(audi));

            Driver driver1 = container.Resolve<Driver>(); // injects BMW
            driver1.RunCar();

            Driver driver2 = container.Resolve<Driver>("LuxuryCarDriver"); // injects Audi
            driver2.RunCar();
            */

            //////////////////////////////////////////////////////////////////////////
            ///Register Instance
            ///
            ICar audi = new Audi();
            container.RegisterInstance<ICar>(audi);

            Driver driver1 = container.Resolve<Driver>();
            driver1.RunCar();
            driver1.RunCar();

            Driver driver2 = container.Resolve<Driver>();
            driver2.RunCar();
        }
    }
}
