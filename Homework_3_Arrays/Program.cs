using System;

namespace Homework_3_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 10;
            int xLocation = 0;
            int yLocation = 0;
            int[,] matrix = new int[10, 10];

            Console.WriteLine("Which Version do you want to see: 1 or 2?");
            int version = Convert.ToInt32(Console.ReadLine());


            if (version == 1)
            {
                for (int i = 1; i < matrix.GetLength(0); i++)
                {
                    Console.WriteLine();
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = value;
                        //Console.CursorLeft = xLocation;
                        //Console.CursorLeft = yLocation;
                        Console.Write(matrix[i, j]);
                        Console.Write(" ");
                        value++;
                        xLocation++;
                        yLocation++;

                    }

                }

            }
            else if (version == 2)
            {
                for (int i = 1; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = value;
                        Console.CursorLeft = xLocation;
                        Console.CursorLeft = yLocation;
                        Console.WriteLine(matrix[i, j]);
                        value++;
                        xLocation++;
                        yLocation++;
                    }

                }
            }
            else
            {
                Console.WriteLine("This version does not exist!");
            }
            Console.ReadLine();
        }
    }
}
