using Microsoft.Practices.Unity;
using System;
using Unity_Container.CarExmaple;

namespace Unity_Container.Using_UnityContainer.Property_Injection
{
    public class Driver
    {
        //[Dependency]
        [Dependency("LuxuryCar")] //Named Mapping
        public ICar Car { get; set; }

        public Driver()
        {

        }

        public void RunCar()
        {
            Console.WriteLine("Running {0} - {1} mile ",this.Car.GetType().Name, this.Car.Run());
        }
    }
}
