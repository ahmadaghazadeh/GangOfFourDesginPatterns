using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.CreationalMtehod.FactoryMethod
{
    public interface IVehicleFactory
    {
        public abstract IVehicle GetVehicle(VehicleType vehicleType);
    }
}
