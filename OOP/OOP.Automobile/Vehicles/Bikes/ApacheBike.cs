﻿using OOP.Automobile.Enums;
using OOP.Automobile.Interfaces;
using System;

namespace OOP.Automobile.Vehicles.Bikes
{
   public sealed class Apachebike : Bike, IBike
    {
        public Apachebike() : base(VehicleName.Apache, Brand.TVS, 200, true)
        {
            PSVersion = 6;
            Console.WriteLine($"The PS version of {Name} is {PSVersion}" );
        }   
    }
}
