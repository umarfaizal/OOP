﻿using OOP.Automobile.Enums;
using OOP.Automobile.Interfaces;
using System;

namespace OOP.Automobile.Vehicles.Buses
{
    public class Bus : Vehicle, IBus
    {
        private readonly VehicleType _typeOfVehicle = VehicleType.Bus;
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
        public SeaterType TypeOfSeat { get; set; }
        public int SeatCount { get; }

        public sealed override bool IsValid(string properties = "")
        {
            properties += $"{TypeOfSeat.ToString()}:{SeatCount.ToString()}";
            bool isValid = true;
            if (!base.IsValid(properties))
            {
                isValid = false;
            }
            else if (TypeOfSeat != SeaterType.Unknown)
            {
                Console.WriteLine("TypeOfSeat is not defined");
                isValid = false;
            }
            else if (SeatCount <= 0)
            {
                Console.WriteLine("SeatCount is not defined");
                isValid = false;
            }
            return isValid;
        }
    }
}
