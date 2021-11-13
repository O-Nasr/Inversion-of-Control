using Microsoft.Practices.Unity;
using System;

namespace Unity_Container.CarExmaple
{
    public class Driver
    {
        #region RegisterAndResolve
        /*private ICar _car = null;

        public Driver(ICar car)
        {
            _car = car;
        }

        public void RunCar()
        {
            Console.WriteLine("Running {0} - {1} mile ", _car.GetType().Name, _car.Run());
        }*/
        #endregion

        #region Constructor Injection
        /*private ICar _car = null;
        private ICarKey _key = null;

        [InjectionConstructor] // If a class includes multiple constructors, then use the this attribute to indicate which constructor to use for construction injection.
        public Driver(ICar car, ICarKey key)
        {
            _key = key;
            _car = car;
        }

        public Driver(string name, int age)
        {
        }

        public void RunCar()
        {
            Console.WriteLine("Running {0} with {1} - {2} mile ", _car.GetType().Name, _key.GetType().Name, _car.Run());
        }*/
        #endregion


        #region Constructor Injection : Primitive Type Parameter
        private ICar _car = null;
        private string _name = string.Empty;

        public Driver(ICar car, string driverName)
        {
            _car = car;
            _name = driverName;
        }

        public void RunCar()
        {
            Console.WriteLine("{0} is running {1} - {2} mile ",_name, _car.GetType().Name, _car.Run());
        }
        #endregion
    }
}
