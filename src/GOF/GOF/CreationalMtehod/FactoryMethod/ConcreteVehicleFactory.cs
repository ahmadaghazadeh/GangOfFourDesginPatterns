using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.CreationalMtehod.FactoryMethod
{
    public class ConcreteVehicleFactory : IVehicleFactory
    {
        public IVehicle GetVehicle(VehicleType vehicleType)
        {
            switch (vehicleType)
            {
                case VehicleType.Scooter:
                    return new Scooter();
                case VehicleType.Bike:
                    return new Bike();
                default:
                    return new Bike();
            }
        }
    }
}
