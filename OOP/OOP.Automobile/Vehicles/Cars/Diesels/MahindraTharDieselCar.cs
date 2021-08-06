using OOP.Automobile.Enums;
using OOP.Automobile.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Automobile.Vehicles.Cars.Diesels
{
    public class MahindraTharDieselCar : DieselCar, IDieselCar
    {
        public MahindraTharDieselCar() : base(IgnitionQuality.Good, false, VehicleName.Thar, Brand.Mahindra, 1500)
        {
        }
    }
}
