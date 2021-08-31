using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter lowest temperature today.");
            double lowestTemperature = Convert.ToDouble (Console.ReadLine());

            Console.WriteLine("Please enter highest temperature today.");
            double highestTemperature = Convert.ToDouble(Console.ReadLine());

            double averageTemperature = (lowestTemperature + highestTemperature) / 2;
            Console.WriteLine($"Average temperature for today is {averageTemperature}");

            Console.ReadLine();
        }
    }
}
