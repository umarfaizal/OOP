using OOP.Automobile.Enums;
using OOP.Automobile.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Automobile.Vehicles.Bikes
{
    public sealed class HornetBike : Bike, IBike
    {
        public HornetBike() : base("Hornet", Brand.Hyundai, 188, true)
        {
            PSVersion = 6;
            Console.WriteLine($"The PS version of {Name} is {PSVersion}");
        }
    }
}
