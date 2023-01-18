using System;

namespace CSharpPrac
{
    public class Program
    {
        /// <summary>
        /// This is the entry point of our application
        /// </summary>
        /// <param name="args"></param>
        static float vat2 = 17f;
        public static void Main(string[] args) // <- Method
        {
            Console.WriteLine("Total vat is: " + vat2);
            Console.WriteLine("Hello World!");

            string color = "blue";
            Console.WriteLine("Hello " + color);

            Console.WriteLine(2+2*6);

            Car myObj = new Car();
            Console.WriteLine(myObj.color);

            int number = 2;
            float price = 3.99f;
            Console.WriteLine(number*price);

            int a = 1;
            int b = 2;
            a = 5;
            int c = a + b;
            Console.WriteLine("Result is: " + c);

            float vat = 19f;
            float productA = 3.99f;
            float productB = 11.99f;
            float productC = 5.75f;

            float summed = productA + productB + productC;

            // vat is required, don't skip it
            /*
             * 1. Hello
             * 2. World
             * 3. Linlin
             */
            float totalTax = (summed / 100) * vat;

            summed += totalTax;
            Console.WriteLine("Total price is: " + summed);

            MyFirstApp cal = new MyFirstApp();
            float vat3 = 15;
            Console.WriteLine("Total vat3 is: " + cal.vat3);

            // Implicitly
            var username = "Linli";

            //Task: create a program to swap two numbers
            int a1 = 5;
            int b1 = 20;

            //logic
            int temp = a1; // 5
            a1 = b1; // a = 20
            b1 = temp; // b = 5

            // Result
            Console.WriteLine("a is: " + a1 + " and b is: " + b1);
            WriteSomething();
            WriteSomethingSpecific("I am an argument and am called from a method");
            Console.Read();
        }

        // acess modifier (static) return type method name (parameter1, parameter2)
        public static void WriteSomething()
        {
            Console.WriteLine("I am called from a method");
        }

        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
        }


    }
}
