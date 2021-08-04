using OOP.Automobile.Enums;
using OOP.Automobile.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Automobile.Vehicles.Lorries
{
    public sealed class TataLPT3723Lorry : Lorry, ILorry
    {
        public TataLPT3723Lorry() : base("LPT 3723", Brand.Tata, 1600)
        {
            this.IsSupportsHeavyLoad = true;
            this.NumberOfWheels = 16;
        }
    }
}
