using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _01_Types
{
    [TestClass]
    public class TypeExamples
    {
        [TestMethod] // testm + Tab Tab     Creates a new TestMethod
        public void ValueTypes()
        {
            // Value Types - has one value.
            // WHOLE NUMBERS
         // type  name of type
            byte oneBytesWorth;
            oneBytesWorth = 255; // min value of 0 & max value of 255

            short smallWholeNumber = 16; // Int16 
            Int16 anotherSmallNumber = 16;
            
            int wholeNumber = 32; // Int32 - one in the same as int

            long largeWholeNumber = 64; // Int64

            int newNumber = oneBytesWorth; // This will always be 1 byte worth in size.

            // Decimals
            float floatExample = 1.234567f; // floats need to be completed with a "f" at end of the value being assigned.
            double doubleExample = 1.23345d;
            // doubles don't need to have the "d" at the end, but this is good for convential uses. Dcimals are automatically set as doubles.
            decimal decimalExample = 1.700000m; // Used for large decimals like for finacial reasons.

            // Character
            char letter = 'i'; // noted with single quotes -- ' ' ---- takes in one 1 single character. ex: n, 9, ?, etc.

            // OPERATORS
            int numOne = 17;
            int numTwo = 5;

            int sum = numOne + numTwo;
            Console.WriteLine(sum);
            int diff = numOne - numTwo;
            Console.WriteLine(diff);
            int prod = numOne * numTwo;
            Console.WriteLine(prod);
            int quot = numOne / numTwo;
            Console.WriteLine(quot);
            int remainder = numOne % numTwo; // modulus to find any of the remainder values.

            Console.WriteLine("Hello");

        }
        // REFERENCE TYPES
        [TestMethod]
        public void ReferenceTypes()
        {
            // STRINGS
            string stringExample = "This is a string.";
            string name = "Eric";

            string declared;
            declared = "Now it's initialized";

            // Formatting strings
            string concatenate = stringExample + " " + name; // "This is a string. Eric
            Console.WriteLine(concatenate);
            string interpolate = $"{name}. Here is the string: {stringExample}";
            Console.WriteLine(interpolate);

            // Other Object Examples (OOP) - C# uses objects 
            DateTime now = DateTime.Now; // Creating an instance of DateTime called "now";
            Console.WriteLine(now);

            DateTime randomDate = new DateTime(2022, 1, 12);

            TimeSpan waitTime = now - randomDate;
            Console.WriteLine(waitTime.TotalSeconds);

            // COLLECTIONS
            // Arrays
            string anotherExample = "Hello World";
            // A collection needs to note what it will hold
            string[] stringArray = { anotherExample, "This", "Test", "!", declared }; // This has a predetermined size of 5
            // We have to assign a predetermined size. Here we can determine that value.
            string[] students = new string[15];

            // type = string array looks like string[]

            // Generic collections
            //LISTS
            List<string> listOfStrings = new List<string>();
            listOfStrings.Add("Benny");


            // QUEUES
            Queue<string> firstInFirstOut = new Queue<string>();
            firstInFirstOut.Enqueue("the Jets");  // Adds to the end of the Queue

            // DICTIONARIES
            Dictionary<char, string> keyValuePair = new Dictionary<char, string>();
            keyValuePair.Add('e', 'Eric'); // "e" = key, "Eric" = value

            // OTHER COLLECTIONS
            SortedList<int, string> sortedKeyValuePair = new SortedList<int, string>();
            Stack<string> firstInLastout = new Stack<string>(); // opposite of a queue
        }

    }
}

/* 
 * - Solutions hold our assemblies.  Each assembly is of a type.
 * - Value Types and Reference Types
 * - Very strongly set 
 * - APIE: Abstraction, Polymorphism, Inheritance, Encapsulation
 *  - Abstraction: picking out he big ideas in a solution and creating a class
 *  - Polymorphism: when different objects respond to the same request in different ways.
 *  - Inheritance: Being able to reuse a class, and add additional details to it.
 *  - Encapsulation: Keeping the details together and hidden.
 *  
 */