using OOP.Automobile.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Automobile.Vehicles.General
{
    public class SeatTypeChangedEventArgs : EventArgs
    {
        public SeatTypeChangedEventArgs(SeaterType oldSeatType, SeaterType newSeatType)
        {
            OldSeatType = oldSeatType;
            NewSeatType = newSeatType;
        }
        public SeaterType OldSeatType { get; set; }
        public SeaterType NewSeatType { get; set; }
    }
}
