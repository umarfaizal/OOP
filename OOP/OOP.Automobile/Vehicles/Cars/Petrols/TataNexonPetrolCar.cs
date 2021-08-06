using OOP.Automobile.Enums;
using OOP.Automobile.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Automobile.Vehicles.Cars.Petrols
{
    public class TataNexonPetrolCar : PetrolCar, IPetrolCar
    {
        public TataNexonPetrolCar() : base(true, false, VehicleName.Nexon, Brand.Tata, 1300)
        {

        }
    }
}
