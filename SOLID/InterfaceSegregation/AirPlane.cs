using System;
namespace SOLID.InterfaceSegregation
{
    public class Airplane : IAirplane
    {
        public Airplane() { }
        public void Fly()
        {
            //actions to fly a plane
            Console.WriteLine("Flying a plane");
        }
    }
}

