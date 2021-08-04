using OOP.Automobile.Enums;
using OOP.Automobile.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Automobile.Vehicles.Bikes
{
    public sealed class ActivaBike : Bike, IBike
    {
        public ActivaBike() : base("Activa", Brand.Honda, 125, true)
        {
                
        }
    }
}
