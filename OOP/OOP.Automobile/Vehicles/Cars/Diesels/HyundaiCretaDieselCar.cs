using OOP.Automobile.Enums;
using OOP.Automobile.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Automobile.Vehicles.Cars.Diesels
{
    public class HyundaiCretaDieselCar : DieselCar, IDieselCar
    {
        public HyundaiCretaDieselCar() : base(IgnitionQuality.Bad, true, "Creta", Brand.Hyundai, 800)
        {
        }
    }
}
