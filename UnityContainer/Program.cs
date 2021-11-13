using Unity_Container.Using_UnityContainer;
using Unity_Container.Using_UnityContainer.Property_Injection;

namespace Unity_Container
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://www.tutorialsteacher.com/ioc

            /*CarExmaple.Driver driver = new CarExmaple.Driver(new BMW());

            driver.RunCar();*/

            //RegisterAndResolve.MainTest();
            //ConstructorInjection.MainTest();
            PropertyInjection.MainTest();
        }
    }
}
