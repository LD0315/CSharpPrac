using System;

namespace CSharpPrac
{
    class Program
    {
        static void Main(string[] args)
        {
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
             * 
             * 
             */
            float totalTax = (summed / 100) * vat;

            summed += totalTax;
            Console.WriteLine("Total price is: " + summed);

        }
    }
}
