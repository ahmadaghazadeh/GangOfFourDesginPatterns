
namespace GOF.CreationalMtehod.AbstractFactory
{
    public class VectorianFurniture : IFurniture
    {
      

        public IChair GetChair()
        {
            return new VectorianChair();
        }

       
        public ISofa GetSofa()
        {
            return new VectorianSofa();
        }

        public ICoffeeTable GetCoffeeTable()
        {
            return new VectorianCoffeeTable();
        }
    }
}
