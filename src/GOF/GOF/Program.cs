using GOF.CreationalMtehod.FactoryMethod;
using GOF.CreationalMtehod.Singleton;
using GOF.CreationalMtehod.Builder;
using System;
using GOF.CreationalMtehod.Protype;
using GOF.CreationalMtehod.AbstractFactory;

namespace GOF
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteHeader("----------");
            WriteHeader("Creational");
            WriteHeader("----------");
            FactoryMethod();

            Singleton();

            Builer();

            Protype();

            AbstractFactory();

            Console.ReadKey();
        }

        private static void AbstractFactory()
        {
            WriteHeader("AbstractFactory");
            var modern = new ModernFurniture();
            var vectorian = new VectorianFurniture();

            Console.WriteLine(@$"modern = chair {modern.GetChair().GetModelDetails()},sofa {modern.GetSofa().GetModelDetails()},coffetable {modern.GetCoffeeTable().GetModelDetails()}");

            Console.WriteLine(@$"vectorian = chair {vectorian.GetChair().GetModelDetails()},sofa {vectorian.GetSofa().GetModelDetails()},coffeTable {vectorian.GetCoffeeTable().GetModelDetails()}");
        }

        private static void Protype()
        {
            WriteHeader("Protype");

            Person person1 = new Person();
            person1.IdInfo = new IdInfo(10);
            person1.Name = "Ahmad Aghazadeh";
            person1.BirthDate = new DateTime(2021, 7, 18);

            Person person2 = person1.DeepCopy();

            Console.WriteLine(@$"person1.IdInfo.IdNumber = {person1.IdInfo.IdNumber}");
            Console.WriteLine(@$"person2.IdInfo.IdNumber = {person2.IdInfo.IdNumber}");


        }

        private static void Builer()
        {
            WriteHeader("Buidler");
            var pizzaBuider = new PizzaBuilder("Meat Pizza",15);
            pizzaBuider
                .AddDressing(1)
                .AddChesse(1)
                .AddMeat(1)
                .AddTomato(1)
                .AddChesse(1);
            var pizza=pizzaBuider.Build();

            pizza.PizzaLayers.ForEach(layer =>
             Console.WriteLine(layer.LayerType.ToString())
             );

        }

        private static void Singleton()
        {
            WriteHeader("Singelton");
            ServerProvider.Instance.Show();
            ServerProvider.Instance.Show();
          
        }

        private static void WriteHeader(string header)
        {
            Console.WriteLine(@$"------------{header}-----------");
        }

        private static void FactoryMethod()
        {
            WriteHeader("FactoryMethod");
            var factory = new ConcreteVehicleFactory();

            var scooter = factory.GetVehicle(VehicleType.Bike);
            scooter.Drive(10);

            var bike = factory.GetVehicle(VehicleType.Bike);
            bike.Drive(20);

             
        }
    }
}
