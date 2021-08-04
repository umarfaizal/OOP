using OOP.Automobile.Enums;
using OOP.Automobile.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Automobile.Vehicles.Cars
{
    public class Car : Vehicle, ICar
    {
        private readonly VehicleType _typeofVehicle = VehicleType.Car;
        private readonly int _numberOfWheels = 4;

        public Car()
        {

        }
        public Car(MachineType typeOfMachine)
        {
            this.TypeOfMachine = typeOfMachine;
        }
        public Car(MachineType typeOfMachine, FuelType typeOfFuel) : this(typeOfMachine)
        {
            this.TypeOfFuel = typeOfFuel;
        }

        public Car(string name, Brand companyName, int cC, MachineType typeOfMachine, FuelType typeOfFuel) : base(name, companyName, cC, typeOfMachine, typeOfFuel)
        {

        }
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
