

using System.Collections.Generic;

namespace GOF.CreationalMtehod.Builder
{
    public class PizzaBuilder:IPizzaBuilder
    {
        protected Pizza pizza;
        public PizzaBuilder(string Name, int Size)
        {
            pizza = new Pizza(Name, Size);
        }

        public IPizzaBuilder AddChesse(int Amount)
        {
            pizza.AddLayer(new PizzaLayer(LayerType.Chesse,Amount));
            return this;
        }

        public IPizzaBuilder AddTomato(int Amount)
        {
            pizza.AddLayer(new PizzaLayer(LayerType.Tamato, Amount));
            return this;
        }

        public IPizzaBuilder AddChicken(int Amount)
        {
            pizza.AddLayer(new PizzaLayer(LayerType.Chesse, Amount));
            return this;
        }

        public IPizzaBuilder AddMeat(int Amount)
        {
            pizza.AddLayer(new PizzaLayer(LayerType.Meat, Amount));
            return this;
        }

        public IPizzaBuilder AddMashroom(int Amount)
        {
            pizza.AddLayer(new PizzaLayer(LayerType.Mashroom, Amount));
            return this;
        }

        public IPizzaBuilder AddDressing(int Amount)
        {
            pizza.AddLayer(new PizzaLayer(LayerType.Dressing, Amount));
            return this;
        }

        public Pizza Build()
        {
            return pizza;
        }


    }
}
