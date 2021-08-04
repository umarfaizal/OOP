using OOP.Automobile.Enums;
using OOP.Automobile.Interfaces;
using System;
using System.Drawing;

namespace OOP.Automobile.Vehicles
{
    public abstract class Vehicle : IVehicle
    {
        #region Private Declaration and Definitions
        private MachineType _typeOfMachine = MachineType.UnKnown;
        private FuelType _typeOfFuel = FuelType.UnKnown;
        #endregion

        #region Constructor
        protected Vehicle()
        {
        }

        protected Vehicle(string name, Brand companyName, int cC, MachineType typeOfMachine, FuelType typeOfFuel)
        {
            Name = name;
            CompanyName = companyName;
            CC = cC;
            _typeOfMachine = typeOfMachine;
            _typeOfFuel = typeOfFuel;
        }
        #endregion

        #region Field Definitions
        public const string TypeOfObject = "Vehicle";
        public abstract VehicleType TypeOfVehicle { get; set; }
        public string Name { get; set; }
        public string ChaseNumber { get; set; }
        public virtual int ManufactureYear { get; set; }
        public virtual System.Drawing.Color Color { get; set; }
        public virtual int NumberOfWheels { get; set; }
        public virtual Brand CompanyName { get; set; }
        public virtual int CC { get; set; }
        public MachineType TypeOfMachine
        {
            get
            {
                return _typeOfMachine;
            }
            set
            {
                if ((_typeOfFuel == FuelType.Diesel || _typeOfFuel == FuelType.Petrol) && value == MachineType.Motor)
                {
                    throw new ArgumentException("FuelType should not be Diesel or Petrol when select machine type as motor");
                }
                else _typeOfMachine = value;
            }
        }
        public FuelType TypeOfFuel
        {
            get
            {
                return _typeOfFuel;
            }
            set
            {
                if (_typeOfMachine == MachineType.Engine && value == FuelType.Electric)
                {
                    throw new ArgumentException("Machine type should not be Engine when select Fuel Type as electric");
                }
                else _typeOfFuel = value;
            }
        }
        #endregion

        #region Method Definitions
        protected virtual string VehicleInfo()
        {
            return $"The vehicle name is {Name}! which is developed by {CompanyName} and its released on {ManufactureYear}.";
        }

        public override string ToString()
        {
            return $"Name::{Name};ChaseNumber::{ChaseNumber};ManufactureYear::{ManufactureYear};Color::{Color.ToString()};NumberOfWheels::{NumberOfWheels};CompanyName::{CompanyName};";
        }

        public virtual bool IsValid(string properties = "")
        {
            Console.WriteLine(ToString() + properties);
            bool isValid = true;
            if (TypeOfVehicle == VehicleType.UnKnown)
            {
                Console.WriteLine("TypeofVehicle is not defined");
                isValid = false;
            }
            if (string.IsNullOrEmpty(Name))
            {
                Console.WriteLine("Name is not defined");
                isValid = false;
            }
            if (string.IsNullOrEmpty(ChaseNumber))
            {
                Console.WriteLine("ChaseNumber is not defined");
                isValid = false;
            }
            if (ManufactureYear <= 0 && ManufactureYear < 2000)
            {
                Console.WriteLine("ManufactureYear is not defined");
                isValid = false;
            }
            if (Color == Color.Empty)
            {
                Console.WriteLine("Color is not defined");
                isValid = false;
            }
            else if (NumberOfWheels <= 1)
            {
                Console.WriteLine("NumberOfWheels is not defined");
                isValid = false;
            }
            if (CompanyName == Brand.UnKnown)
            {
                Console.WriteLine("CompanyName is not defined");
                isValid = false;
            }
            if (CC < 50)
            {
                Console.WriteLine("CC is not defined");
                isValid = false;
            }
            if (TypeOfMachine == MachineType.UnKnown)
            {
                Console.WriteLine("TypeOfMachine is not defined");
                isValid = false;
            }
            if (TypeOfFuel == FuelType.UnKnown)
            {
                Console.WriteLine("TypeOfFuel is not defined");
                isValid = false;
            }
            return isValid;
        }
        #endregion

        #region Operator definitions
        public static bool operator ==(Vehicle a, Vehicle b)
        {
            if (a.TypeOfVehicle == b.TypeOfVehicle && a.ManufactureYear == b.ManufactureYear && a.CompanyName == b.CompanyName && a.CC == b.CC)
                return true;
            else return false;
        }

        public static bool operator !=(Vehicle a, Vehicle b)
        {
            return !(a == b);
        }
        #endregion
    }



}
