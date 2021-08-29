using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя.");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}, сегодня [{DateTime.Now}]");
            Console.ReadLine();
        }
    }
}
