using OOP.Automobile.Enums;
using OOP.Automobile.Interfaces;
using OOP.Automobile.Vehicles.General;
using System;

namespace OOP.Automobile.Vehicles.Buses
{
    public class Bus : Vehicle, IBus
    {
        private readonly VehicleType _typeOfVehicle = VehicleType.Bus;
        private SeaterType _typeOfSeat = SeaterType.Unknown;
        public event SeatTypeChangedEventHandler SeatTypeChanged;

        protected Bus(string name, Brand companyName, int cC, SeaterType typeOfSeat, int seatCount) : base(name, companyName, cC, MachineType.Engine, FuelType.Diesel)
        {
            TypeOfSeat = typeOfSeat;
            SeatCount = seatCount;
        }

        public sealed override VehicleType TypeOfVehicle
        {
            get
            {
                return _typeOfVehicle;
            }
            set
            {
                throw new ArgumentException("Already vehicle type defined as Bus. Don't try to set it");
            }
        }

        public SeaterType TypeOfSeat
        {
            get
            {
                return _typeOfSeat;
            }
            set
            {
                if (_typeOfSeat != value)
                {
                    var seatTypeChangedEventArgs = new SeatTypeChangedEventArgs(_typeOfSeat, value);
                    OnSeatTypeChanged(seatTypeChangedEventArgs);
                }
                _typeOfSeat = value;
            }
        }
        public int SeatCount { get; }

        public sealed override bool IsValid(string properties = "")
        {
            properties += $"TypeOfSeat::{TypeOfSeat};SeatCount::{SeatCount};";
            bool isValid = true;
            if (!base.IsValid(properties))
            {
                isValid = false;
            }
            if (TypeOfSeat != SeaterType.Unknown)
            {
                Console.WriteLine("TypeOfSeat is not defined");
                isValid = false;
            }
            if (SeatCount <= 0)
            {
                Console.WriteLine("SeatCount is not defined");
                isValid = false;
            }
            return isValid;
        }

        protected virtual void OnSeatTypeChanged(SeatTypeChangedEventArgs e)
        {
            // SeatTypeChanged?.Invoke(this, e);
            if (SeatTypeChanged != null)
            {
                SeatTypeChanged(this, e);
            }
        }
    }
}
