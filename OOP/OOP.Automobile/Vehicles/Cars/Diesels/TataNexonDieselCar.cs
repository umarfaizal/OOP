using OOP.Automobile.Enums;
using OOP.Automobile.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Automobile.Vehicles.Cars.Diesels
{
    public class TataNexonDieselCar : DieselCar, IDieselCar
    {
        public TataNexonDieselCar() : base(IgnitionQuality.Bad, true, "Nexon", Brand.Tata, 900)
        {
        }
    }
}
