using System;

namespace Homework_3_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string [,] phoneBook = new string [5,2];
            phoneBook [0, 0] = "Dmitry Chalganov";
            phoneBook [0, 1] = "chalganovdima@gmail.com";
            phoneBook [1, 0] = "Ivan Ivanovich";
            phoneBook [1, 1] = "Ivan.Ivanovich@gmail.com";
            phoneBook [2, 0] = "Petr Petrovich";
            phoneBook [2, 1] = "Petr.Petrovich@gmail.com";
            phoneBook [3, 0] = "Fedor Fedorovich";
            phoneBook [3, 1] = "Fedor.Fedorovich@gmail.com";
            phoneBook [4, 0] = "David Davidovich";
            phoneBook [4, 1] = "David.Davidovich@gmail.com";

            
            for (int i = 0; i < phoneBook.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < phoneBook.GetLength(1); j++)
                {
                    Console.Write(phoneBook[i,j]);
                    Console.Write("      ");
                }

            }
            Console.ReadLine();
        }
    }
}
