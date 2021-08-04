using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Automobile.Interfaces
{
    public interface IPetrolCar : IEngineCar
    {
        bool IsHighHeatingValue { get; set; }
    }
}
