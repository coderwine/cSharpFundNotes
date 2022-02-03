using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _04_Methods
{
    [TestClass]
    public class MethodExamples
    {
        // Input
        // What we do
        // Output

        // Access Modifier - Return Type - Method Signature (Name and list of parameters)
        public int AddTwoNumbers(int numOne, int numTwo)
        {
            int sum = numOne + numTwo; 
            return sum;
        }

        private int SubtractTwoNumebrs(int a, int b)
        {
            int num = a - b;
            return num;
        }

        private int MultiplyTwoNumbers(int x, int z)
        {
            int num = x * z;
            return num;
        }

        private int DivideTwoNumbers(int a, int z)
        {
            int num = a / z;
            return num;
        }

        private int FindRemainder(int a, int b)
        {
            int remainder = a % b;
            return remainder;
        }

        [TestMethod]
        public void MethodTests()
        {
            int sum = AddTwoNumbers(7, 12);
            Console.WriteLine(sum);

            Assert.AreEqual(19, sum); // This is a way for us to test a values that we are expecting.

            int subtracted = SubtractTwoNumebrs(10, 5);
            Assert.AreEqual(5, subtracted);

            int product = MultiplyTwoNumbers(12, 5);
            Assert.AreEqual(60,product);

            int divided = DivideTwoNumbers(10, 4);
            Assert.AreEqual(2, divided);

            int remainder = FindRemainder(10, 4);
            Assert.AreEqual(2, remainder);
        }
    }
}
