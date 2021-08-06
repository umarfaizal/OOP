using OOP.Automobile.Enums;
using OOP.Automobile.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Automobile.Vehicles.Cars.Electrics
{
    public class TataNexonEVElectricCar : ElectricCar, IElectricCar
    {
        public TataNexonEVElectricCar() : base(name: VehicleName.Nexon, cC: 1250, companyName: Brand.Tata, isFastCharging: true)
        {
        }
    }
}
