using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03_Loops
{
    [TestClass]
    public class LoopExamples
    {
        [TestMethod]
        public void ForLoops()
        {
            int studentCount = 15;

            // 1 Starting point
            // 2 Condition, while true, keeps loop running
            // 3 What happens after each loop
            // 4 Body of the loop, what happens during an interation.

            
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine(i);
            }
        }

        [TestMethod]
        public void ForEachLoops()
        {
            // Good at workign with a collection (or group of objects)
            string name = "EFA"; // This is just a collection of characters.

            // 1 Collection that is being worked on.
            // 2 Name of the current iteration being used.
            // 3 Current type in the collection
            // 4 "in" keyword. used to separate the individual and the collection
            // 5 Body of the loop

            //      3      2    4    1
            foreach(char letter in name)
            {
                Console.WriteLine(letter);
            }

        }

        [TestMethod]
        public void WhileLoops()
        {
            int total = 1;

            // 1 Loop runs while the condition is true.
            // 2 Body of the loop

            while (total != 30)
            {
                Console.WriteLine(total);
                total++;
            }
        }
    }
}
