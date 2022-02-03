using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _02_Conditionals
{
    [TestClass]
    public class ConditionalExamples
    {
        [TestMethod]
        public void Booleans()
        {
            bool isTrue = 1 < 2; // value returns as a true which means that it can hold the true/false result.
            bool someBool = true;
            bool isFalse = 1 > 2;
            bool anotherBool = false;
            bool thisBool = 4 == 2; // == is equal
        }

        [TestMethod]
        public void ifElseStatements()
        {
            if(true)
            {
                // do this condition
            }

            bool isTrue = true;
            if (isTrue)
            {
                // Do something
            }

            int age = 16;

            if(age > 17)
            {
                Console.WriteLine("You're an adult");
            }
            else if (age > 6)
            {
                Console.WriteLine("You're just a kid");
            }
            else if (age > 0)
            {
                Console.WriteLine("Why are you on the computer?");
            }
            else
            {
                Console.WriteLine("You're not even born.");
            }


            if (age > 65 && age < 17) 
            {
                // && And comparision
            }

            if (age <= 65 || age <= 17) 
            {
                // less than or equal to <=, OR is || "pipes"
            }

            if (age == 17)
            {
                // Is equal to
            }

            if (age != 17)
            {
                // Is NOT equal to
            }
        }

        [TestMethod]
        public void SwitchCases()
        {
            // used to check a specific condition. One value conditions

            int age = 42;

            switch(age) // we are evaluating the age variable.
            {
                case 18:
                    // Code if age is 18;
                    break;
                case 19:
                    // Code if age is 19;
                    break;
                // Stacking cases
                case 20:
                case 21:
                case 22:
                case 23:
                    // Code from cases from 20 to 23;
                    break;
                default:
                    // catch all code;
                    break;
            }
        }

        [TestMethod]
        public void Ternaries()
        {
            int age = 37;

            // variable = (boolean statement) ? true : false

            bool isAge = (age > 17) ? true : false;
            string isReturned = (age < 17) ? $"{age} is less than 17" : $"{age} is more than 17";
            Console.WriteLine(isReturned);
        }
    }
}
