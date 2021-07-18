
namespace GOF.CreationalMtehod.AbstractFactory
{
    public class ModernFurniture : IFurniture
    {
      

        public IChair GetChair()
        {
            return new ModernChair();
        }

       
        public ISofa GetSofa()
        {
            return new ModernSofa();
        }

        public ICoffeeTable GetCoffeeTable()
        {
            return new ModernCoffeeTable();
        }
    }
}
