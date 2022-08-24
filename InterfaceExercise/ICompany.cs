using System;
namespace InterfaceExercise
//In ICompany

/*Create 2 members that are specific to each every company
 * regardless of vehicle type.
 *
 *
 * Example: public string Logo { get; set; }
 */
{
    public interface ICompany
    {
        public string CompanyName { get; set; }

        public string HeadquarterLocation { get; set; }
    }
}

