using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //DONE- Create 2 Interfaces called IVehicle & ICompany

            //DONE- Create 3 classes called Car , Truck , & SUV
            //In each of your car, truck, and suv classes

            //DONE- Create 2 members that are specific to each class
            // Example: truck has a bed size while car has a trunk while suv has a cargo hold size
            //DONE- Then, Set each class to inherit from both IVehicle and ICompany and implement their members.

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            //creating object one
            Car rubisCar = new Car();

            //creating object two
            Truck luistruck = new Truck();

            //creating object three
            SUV familyCar = new SUV();

            //creating a list so I can add each car to it
            var vehicles = new List<IVehicle>() { rubisCar, luistruck, familyCar };

            //using the loop to iterate through the objects I created from my classes
            Console.WriteLine($"All of my cars-");
            foreach (var whip in vehicles)
            {
                Console.WriteLine($"Has a motor: {whip.HasAMotor}, Number of tires: {whip.NumberOfTires}, Manufacturer: {whip.Manufacturer}");
                whip.Drive();
                
            }

            //???trying to iterate through all of the members but I think it is only allowing me to use the members in the IVehicle interface when i also want to
            //include the car, truck, ,suv members

            //???why does it show green when trying to use my method Drive
        }
    }
}
