using System;
namespace InterfaceExercise
//In your IVehicle

/* Create 4 members that Car, Truck, & SUV all have in common.
 * Example: All vehicles have a number of wheels... for now..
 */
{
    public interface IVehicle
    {
        public int NumberOfTires { get; set; }

        public bool HasAMotor { get; set; }

        public string Manufacturer { get; set; }

        public void Drive();
    }
}

