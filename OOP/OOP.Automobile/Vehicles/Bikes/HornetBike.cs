using OOP.Automobile.Enums;
using OOP.Automobile.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Automobile.Vehicles.Bikes
{
    public sealed class HornetBike : Bike, IBike
    {
        public HornetBike(string name) : base(name, Brand.Hyundai, 188, true)
        {

        }
        public HornetBike() : base("Hornet", Brand.Hyundai, 188, true)
        {
            PSVersion = 6;
            Console.WriteLine($"The PS version of {Name} is {PSVersion}");
        }

        public static implicit operator string(HornetBike bike)
        {
            return bike.Name;
        }
        public static explicit operator HornetBike(string name)
        {
            return new HornetBike(name);
        }
    }
}
