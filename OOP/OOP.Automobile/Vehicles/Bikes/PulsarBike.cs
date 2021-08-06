using OOP.Automobile.Enums;
using OOP.Automobile.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Automobile.Vehicles.Bikes
{
    public sealed class PulsarBike : Bike, IBike
    {
        public PulsarBike() : base(VehicleName.Pulsar, Brand.Bajaji, 150, true)
        {
            PSVersion = 6;
            Console.WriteLine($"The PS version of {Name} is {PSVersion}");
        }
    }
}
