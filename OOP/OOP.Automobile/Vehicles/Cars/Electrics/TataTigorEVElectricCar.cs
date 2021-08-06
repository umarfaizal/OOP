using OOP.Automobile.Enums;
using OOP.Automobile.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Automobile.Vehicles.Cars.Electrics
{
    public class TataTigorEVElectricCar : ElectricCar, IElectricCar
    {
        public TataTigorEVElectricCar() : base(name: VehicleName.Tigor, cC: 1000, companyName: Brand.Tata, isFastCharging: false)
        {
        }
    }
}
