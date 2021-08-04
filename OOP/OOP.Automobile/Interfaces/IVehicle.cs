using OOP.Automobile.Enums;

namespace OOP.Automobile.Interfaces
{
    public interface IVehicle
    {
        VehicleType TypeOfVehicle { get; set; }
        MachineType TypeOfMachine { get; set; }
        FuelType TypeOfFuel { get; set; }
        string Name { get; set; }
        string ChaseNumber { get; set; }
        int ManufactureYear { get; set; }
        System.Drawing.Color Color { get; set; }
        int NumberOfWheels { get; set; }
        Brand CompanyName { get; set; }
        bool IsValid(string properties = "");
    }
}
