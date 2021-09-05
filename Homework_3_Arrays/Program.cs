using System;

namespace Homework_3_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            int inputLength = input.Length;
            int longestLine = 0;
            int temp = 1;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == input[i-1])
                {
                    temp++;
                }
                if (longestLine< temp)
                {
                    longestLine = temp;
                }
                if (input[i] !=input[i - 1])
                {
                    temp = 1;
                }
            }

            Console.WriteLine(longestLine);

            Console.ReadLine();
        }
    }
}
