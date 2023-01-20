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
            int num11 = 5;
            int num22 = 3;
            int num3;

            // unary operators
            num3 = -num11;
            Console.WriteLine("num3 is {0}", num3);
       
            bool isSunny = true;
            Console.WriteLine("is it sunny? {0}", !isSunny);

            // increment operators
            int num = 0;
            num++;
            Console.WriteLine("num is {0}", num);
            // post increment
            Console.WriteLine("num is {0}", num++);
            // pre increment
            Console.WriteLine("num is {0}", ++num);

            // decrement operator
            num--;
            Console.WriteLine("num is {0}", num);
            // post decrement
            Console.WriteLine("num is {0}", num--);
            // pre decrement
            Console.WriteLine("num is {0}", --num);


            Console.ReadKey();

            Console.WriteLine("Please enter a number!");
            string userInput = Console.ReadLine();
            //Console.WriteLine(Calculate());
            //Calculate2();
            //Console.Read();
            int num1 = 5;
            int num2 = 0;
            int result;

            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Can't devide by zero!");
            }

            try
            {
                int userInputAsInt = int.Parse(userInput);
            }
            catch (FormatException)
            {
                Console.WriteLine("Format exception, please enter the correct type next time.");
                //throw;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow exception, the number was too long or too short for an int32");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("ArgumentNullException, the value was empty(null)");
            }
            finally
            {
                Console.WriteLine("This is called anyways!");
            }

            Console.ReadKey();

            
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

            //int sumResult = Add(15, 31);
            //Console.WriteLine(sumResult);
            Console.WriteLine(Add(Add(1, 2), Add(3, 4)));
            Console.WriteLine(Add(15, 31));
            Console.WriteLine(Multiply(25, 25));
            Console.WriteLine(Devide(25,13));

            string input = Console.ReadLine(); // take user input
            Console.WriteLine(input); // write user input
            //Console.Read(); // read the user input to console
        }
        public static int Calculate()
        {

            Console.WriteLine("Please enter the first number");
            string number1Input = Console.ReadLine();
            Console.WriteLine("Please enter the second number");
            string number2Input = Console.ReadLine();

            int num1 = int.Parse(number1Input);
            int num2 = int.Parse(number2Input);

            int result = num1 + num2;
            return result;
        }

        public static void Calculate2()
        {
            Console.WriteLine("Please enter the first number");
            string number1Input = Console.ReadLine();
            Console.WriteLine("Please enter the second number");
            string number2Input = Console.ReadLine();

            int num1 = int.Parse(number1Input);
            int num2 = int.Parse(number2Input);

            int result = num1 + num2;
            Console.WriteLine(result);
        }

        // acess modifier (static) return type method name (parameter1, parameter2)
        // void methods don't have return values
        public static void WriteSomething()
        {
            Console.WriteLine("I am called from a method");
        }

        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static double Devide(double num1, double num2)
        {
            return num1 / num2;
        }

    }
}
