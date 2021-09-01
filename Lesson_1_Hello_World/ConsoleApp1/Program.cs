using System;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            double inputNumber;
            Console.WriteLine("Please enter the whole number.");
            inputNumber = Convert.ToDouble (Console.ReadLine());

            if (Calculate(inputNumber) == 0)
            {
                Console.WriteLine("Your number is Even.");
            }
            else if (Calculate(inputNumber) == 1)
            {

                Console.WriteLine("Your number is Odd.");
            }
            else
            {
                Console.WriteLine("The number you have entered is not a whole number.");

            }
            Console.ReadLine();
        }

        static double Calculate(double x)
        {
            double odd = x % 2;                
            return odd;
        }
    }
}
