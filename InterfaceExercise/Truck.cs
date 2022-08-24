using System;
namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public Truck()
        {
        }
        //individual members for Truck
        public bool HasTrunkBed { get; set; } = true;

        public bool HasTrunkBedCover { get; set; } = true;

        //IVehicle members
        public int NumberOfTires { get; set; } = 4;

        public bool HasAMotor { get; set; } = true;

        public string Manufacturer { get; set; } = "Ford";

        //ICompany members
        public string CompanyName { get; set; } = "Ford Motor Company";

        public string HeadquarterLocation { get; set; } = "Michigan";

        //IVehicle method
        public void Drive()
        {
            Console.WriteLine($"I am a manual");
        }
    }
}

