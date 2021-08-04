using OOP.Automobile.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Automobile.Interfaces
{
    public interface IBus : IVehicle
    {
        SeaterType TypeOfSeat { get; set; }
        int SeatCount { get;  }
    }
}
