using OOP.Automobile.Interfaces;
using OOP.Automobile.Vehicles.Cars.Electrics;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace OOP.Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BuildMotors buildMotors = new BuildMotors();
            buildMotors.Cars();
        }
    }


    public class BuildMotors
    {
        private List<IVehicle> vehicles = new List<IVehicle>();
        public void Cars()
        {
            AudiETronElectricCar audiETronElectricCar = new AudiETronElectricCar();
            audiETronElectricCar.ManufactureYear = 2018;
            audiETronElectricCar.ChaseNumber = "0XA1";
            audiETronElectricCar.Color = Color.AliceBlue;
            Console.WriteLine(audiETronElectricCar.IsValid());
            vehicles.Add(audiETronElectricCar);
        }
    }


}
