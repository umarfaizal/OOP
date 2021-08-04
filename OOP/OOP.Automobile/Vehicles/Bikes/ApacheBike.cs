﻿using OOP.Automobile.Enums;
using OOP.Automobile.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Automobile.Vehicles.Bikes
{
   public sealed class Apachebike : Bike, IBike
    {
        public Apachebike() : base("Apache", Brand.TVS, 200, true)
        {
            PSVersion = 6;
            Console.WriteLine($"The PS version of {Name} is {PSVersion}" );
        }   
    }
}