using Microsoft.Practices.Unity;
using System;
using Unity_Container.CarExmaple;

namespace Unity_Container.Using_UnityContainer.Method_Injection
{
    public class Driver
    {
        private ICar _car = null;

        public Driver()
        {
        }

        [InjectionMethod]
        public void UseCar(ICar car)
        {
            _car = car;
        }

        public void RunCar()
        {
            Console.WriteLine("Running {0} - {1} mile ", _car.GetType().Name, _car.Run());
        }
    }
}
