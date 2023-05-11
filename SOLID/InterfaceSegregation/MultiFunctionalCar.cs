using System;
namespace SOLID.InterfaceSegregation
{
    public class MultiFunctionalCar : ICar, IAirplane
    {
        public MultiFunctionalCar() { }
        public void Drive()
        {
            //actions to start driving car
            Console.WriteLine("Drive a multifunctional car");
        }

        public void Fly()
        {
            //actions to start flying
            Console.WriteLine("Fly a multifunctional car");
        }
    }
}

