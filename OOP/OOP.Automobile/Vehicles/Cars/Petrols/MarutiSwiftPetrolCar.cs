using OOP.Automobile.Enums;
using OOP.Automobile.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Automobile.Vehicles.Cars.Petrols
{
    public class MarutiSwiftPetrolCar : PetrolCar, IPetrolCar
    {
        public MarutiSwiftPetrolCar() : base(false, false, "Swift", Brand.Maruti, 1200)
        {

        }
    }
}
