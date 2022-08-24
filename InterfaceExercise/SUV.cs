using System;
namespace InterfaceExercise
{
    public class SUV: IVehicle, ICompany
    {
        public SUV()
        {
        }
        public int CargoAmount { get; set; } = 25;

        public bool HasThirdRow { get; set; } = true;

        public int NumberOfTires { get; set; } = 4;

        public bool HasAMotor { get; set; } = true;

        public string Manufacturer { get; set; } = "Honda";

        public string CompanyName { get; set; } = "Honda";

        public string HeadquarterLocation { get; set; } = "Tokyo";

        public void Drive()
        {
            Console.WriteLine($"I am an automatic with 4 wheel drive");
        }
    }
}

