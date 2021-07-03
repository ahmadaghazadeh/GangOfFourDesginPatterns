using GOF.CreationalMtehod.FactoryMethod;
using System;

namespace GOF
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryMethod();
        }

        private static void FactoryMethod()
        {
            var factory = new ConcreteVehicleFactory();

            var scooter = factory.GetVehicle(VehicleType.Bike);
            scooter.Drive(10);

            var bike = factory.GetVehicle(VehicleType.Bike);
            bike.Drive(20);

            Console.ReadKey();
        }
    }
}
