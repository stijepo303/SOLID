using System;
namespace SOLID.InterfaceSegregation
{
    public class Car : ICar
    {
        public Car() { }
        public void Drive()
        {
            //actions to drive a car
            Console.WriteLine("Driving a car");
        }
    }
}

