using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _05_Classes
{
    [TestClass]
    public class ClassesTest
    {
        [TestMethod]
        public void CookieTests()
        {
             Cookie cookie = new Cookie(); // making a new object of "cookie"
             cookie.Name = "Snickerdoodle"; // setting the name property 
             cookie.HasNuts = true; 

             Cookie anotherCookie = new Cookie(); 
             anotherCookie.Name = "Something Else";
             anotherCookie.GramsOfFlour = 10;
            
            /*
             * The above "new ups" utilized the "invisible" constructor. This currently works due to the overload that 
             * was provided in the ClassExamples above the detailed constructor.
             */
            
            Cookie snickerdoodle = new Cookie("Snickerdoodle", false, 11.5);
            Cookie newCookie = new Cookie('PB Cookie', true, 150);
            
            /*
              - We cannot have two methods that are the exact same as this would cause a break in the code. 
              - We are not able to pass in the same parameters. If there are slightly different, it should allow the method to be created.
              - Providing an overload (empty) constructor, we are able to detail our variables as we have in variables "cookie" and
                "anotherCookie". The bottom variables are utilizing the detailed constructor within the Cookie Class.
             */

        }

        [TestMethod]
        public void VehicleTests()
        {
            Vehicle car = new Vehicle();
            car.TypeOfVehicle = VehicleType.Car;
            // We're able to isolate the keys within the VehicleType object created in the Class Examples.

            Vehicle newCar = new Vehicle
            {
                TypeOfVehicle = VehicleType.Car,
                Make = "Honda",
                Model = "Civic"

            };

            /*
             The above new-up is a way that we can populate object initialization. This means that we can note the enum created in
             our class and assign those associated values.
             */
        }
    }
}
