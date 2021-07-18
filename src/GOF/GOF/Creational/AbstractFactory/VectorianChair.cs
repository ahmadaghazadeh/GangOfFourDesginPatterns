using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.CreationalMtehod.AbstractFactory
{
    public class VectorianChair : IChair
    {
        public string GetModelDetails()
        {
            return "Modern Chair";
        }
    }
}
