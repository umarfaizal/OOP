using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Automobile.Interfaces
{
    public interface IElectricCar : ICar
    {
        bool IsFastCharging { get; }
    }
}
