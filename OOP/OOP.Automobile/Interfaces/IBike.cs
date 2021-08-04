using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Automobile.Interfaces
{
   public interface IBike : IVehicle
    {
        bool IsGearBike { get; }
    }
}
