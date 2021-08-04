using OOP.Automobile.Enums;
using OOP.Automobile.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Automobile.Vehicles.Lorries
{
    public sealed class MahindraTruxoLorry : Lorry, ILorry
    {
        public MahindraTruxoLorry() : base("Truxo", Brand.Mahindra, 1500)
        {
            IsSupportsHeavyLoad = true;
            NumberOfWheels = 12;
        }
    }
}
