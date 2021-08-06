using OOP.Automobile.Enums;
using OOP.Automobile.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Automobile.Vehicles.Cars.Diesels
{
    public class ToyotaFortunerDieselCar : DieselCar, IDieselCar
    {
        public ToyotaFortunerDieselCar() : base(IgnitionQuality.Good, true, VehicleName.Fortuner, Brand.Toyota, 2000)
        {
        }
    }
}
