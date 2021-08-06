using OOP.Automobile.Enums;
using OOP.Automobile.Interfaces;
using System;

namespace OOP.Automobile.Vehicles.Cars
{
    public partial class Car : Vehicle, ICar
    {
        public event Action AcStatusChanged;

        public override VehicleType TypeOfVehicle
        {
            get
            {
                return _typeofVehicle;
            }
            set
            {
                throw new ArgumentException("Already vehicle type defined as Car. Don't try to set it");
            }
        }

        public bool IsAcAvailable { get; set; }
        public bool IsSunRoofAvailable { get; set; }

        public sealed override int NumberOfWheels
        {
            get
            {
                return _numberOfWheels;
            }
            set
            {
                throw new ArgumentException("Car wheels already defined we can't it");
            }
        }
    }
}
