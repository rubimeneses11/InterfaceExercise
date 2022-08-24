using System;
namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public Car()
        {
        }

        public bool HasTrunk { get; set; } = true;

        public bool SedanSuspension { get; set; } = true;

        public int NumberOfTires { get; set; } = 4;

        public bool HasAMotor { get; set; } = true;

        public string Manufacturer { get; set; } = "Toyota";

        public string CompanyName { get; set; } = "Toyota";

        public string HeadquarterLocation { get; set; } = "Japan";

        public void Drive()
        {
            Console.WriteLine($"I am an automatic");
        }
    }
}

