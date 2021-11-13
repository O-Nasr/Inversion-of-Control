using System;
using Unity_Container.CarExmaple;

namespace Unity_Container.Using_UnityContainer.Register_And_Resolve
{
    internal class Driver
    {
        private ICar _car = null;

        public Driver(ICar car)
        {
            _car = car;
        }

        public void RunCar()
        {
            Console.WriteLine("Running {0} - {1} mile ", _car.GetType().Name, _car.Run());
        }
    }
}
