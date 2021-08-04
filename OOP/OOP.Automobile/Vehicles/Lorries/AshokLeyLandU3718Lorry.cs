using OOP.Automobile.Enums;
using OOP.Automobile.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Automobile.Vehicles.Lorries
{
    public sealed class AshokLeyLandU3718Lorry : Lorry, ILorry
    {
        public AshokLeyLandU3718Lorry() : base("U 3718", Brand.AshokLeyLand, 1000)
        {
            this.IsSupportsHeavyLoad = false;
            this.NumberOfWheels = 10;
        }
    }
}
