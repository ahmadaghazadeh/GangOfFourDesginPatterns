using System;
using System.Collections.Generic;

namespace GOF.CreationalMtehod.Builder
{
    public class Pizza
    {
        public readonly List<PizzaLayer> PizzaLayers = new();
        public int Size { get; private set; }

        public string Name { get;private set; }

        public void AddLayer(PizzaLayer pizzaLayer)
        {
            if(PizzaLayers.Count>=10)
            {
                throw new Exception("Layers does not bigger than 10.");
            }
            PizzaLayers.Add(pizzaLayer);
        }

        public Pizza(string Name,int Size)
        {
            this.Size = Size;
            this.Name = Name;
        }
    }
}
