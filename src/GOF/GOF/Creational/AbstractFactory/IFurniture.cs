
namespace GOF.CreationalMtehod.AbstractFactory
{
    public interface IFurniture
    {
        IChair GetChair();
        ISofa GetSofa();

        ICoffeeTable GetCoffeeTable();
    }

}
