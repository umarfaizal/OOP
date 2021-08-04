using OOP.Automobile.Enums;
using OOP.Automobile.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Automobile.Vehicles.Cars.Petrols
{
    public class HyundaiCretaPetrolCar : PetrolCar, IPetrolCar
    {
        public HyundaiCretaPetrolCar() : base(false, true, "Creta", Brand.Hyundai, 950)
        {

        }
    }
}
