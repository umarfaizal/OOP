using OOP.Automobile.Vehicles.Cars.Diesels;

namespace OOP.Terminal
{
    public class AutomobileValidate
    {
        public void CheckCarInstance()
        {
            HyundaiCretaDieselCar car1 = new HyundaiCretaDieselCar();
        }
        public void CheckIsValid()
        {
            HyundaiCretaDieselCar car1 = new HyundaiCretaDieselCar();
           bool isValid = car1.IsValid();
        }
    }
}
