using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.CreationalMtehod.Builder
{
    public class PizzaLayer
    {
       
        public LayerType LayerType { get;private set; }
        public int Amount { get; private set; }

        public PizzaLayer(LayerType LayerType, int Amount)
        {
            this.LayerType = LayerType;
            this.Amount = Amount;
        }
    }
}
