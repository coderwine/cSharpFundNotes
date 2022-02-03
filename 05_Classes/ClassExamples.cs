using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    // We can have as many classes as we want within a namespace.
    
    public class Cookie
    {
        /* classes can have different access motifiers. 
         * If we don't declare that, it becomes an internal access. In this case, we will make it a public.
        */
        public string Name { get; set; }
        // Anything that isn't a local variable, it will be Pascal case like this.

        public bool HasNuts { get; set; }
        public double GramsOfFlour { get; set; }

        /* GETTER & SETTERS
            - Known as Accessors and Mutators.
            - Special methods that get or set the value of a property or attribute.
         */

        /*
            Constructors are always implicit. 
            If it doesn't exist in your written code, there will be an empty constructor defined in the background.
            Constructors automatically fire off when our class is being called.
         */

        public Cookie()
        {

        }

        public Cookie(string name, bool hasNuts, double gramsOfFlour) // This is our constructor.
        {
            Name = name;
            HasNuts = hasNuts;
            GramsOfFlour = gramsOfFlour;
            // The left side is pulled from the above variables. The right side are the parameters that are being fed in.
        }
        /*
         */
    }

    //ENUM
    public enum VehicleType
    {
        Car, Truck, Van, Motorcycle, Spaceship, Plane, Boat
    }
    /*
        We can create an enum object values to pass this along as a TYPE to other variables. 
    */

    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }

        // prop + tab tab
        public double Milage { get; set; }
        public string Color { get; set; }
        public double Year { get; set; }
        public VehicleType TypeOfVehicle { get; set; }

        public Vehicle()
        {

        }
    }

    public class Order
    {
        public string CustomerName { get; set; }
        public Cookie OrderedProduct { get; set; } 
        // We are able to grab other classes that were previously created in order to help design out other classes.
        public decimal TotalCost { get; set; }
    }
}
