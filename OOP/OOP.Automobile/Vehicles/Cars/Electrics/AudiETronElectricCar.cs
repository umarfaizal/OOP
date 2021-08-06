using OOP.Automobile.Enums;
using OOP.Automobile.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Automobile.Vehicles.Cars.Electrics
{
    public class AudiETronElectricCar : ElectricCar, IElectricCar
    {
        public AudiETronElectricCar() : base(true,VehicleName.Tron, Brand.Audi, 2000)
        {
        }
    }
}
