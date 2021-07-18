namespace GOF.CreationalMtehod.Builder
{
    public interface IPizzaBuilder
    {
        IPizzaBuilder AddChesse(int Amount);
        IPizzaBuilder AddTomato(int Amount);

        IPizzaBuilder AddChicken(int Amount);
        IPizzaBuilder AddMeat(int Amount);

        IPizzaBuilder AddMashroom(int Amount);

        IPizzaBuilder AddDressing(int Amount);
    }
}
