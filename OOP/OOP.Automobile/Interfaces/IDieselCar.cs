using OOP.Automobile.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Automobile.Interfaces
{
    public interface IDieselCar : IEngineCar
    {
        IgnitionQuality IgnitionType { get; set; }
    }
}
