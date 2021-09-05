using System;

namespace Homework_3_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            int inputLength = input.Length;

            for (int i = input.Length; i > 0; i --)
            {
                Console.Write(input[i-1]);
            }

            Console.ReadLine();
        }
    }
}
