using OOP.Automobile.Enums;
using OOP.Automobile.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Automobile.Vehicles.Bikes
{
    public sealed class NTorqBike : Bike, IBike
    {
        public NTorqBike() : base("NTorq", Brand.TVS, 125, true)
        {

        }
    }
}
