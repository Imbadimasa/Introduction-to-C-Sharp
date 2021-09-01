using System;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string restaurant = "Cora Mississauga";
            int tableNumber = 60;
            string server = "Donald";
            string entry1 = "BEN BRIE MUSHROOM";
            string entry2 = "BEN SMOKED SALMON";
            string entry3 = "BLUEBERRY FIELDS";
            string entry4 = "CREPOMLET SPINACH CHED";
            string entry5 = "REGULAR COFFEE";

            double priceEntry1 = 18.25;
            double priceEntry2 = 18.25;
            double priceEntry3 = 12.45;
            double priceEntry4 = 15.25;
            double priceEntry5 = 6.50;

            double tax = 9.19;
            double total = 79.89;

            Console.WriteLine();
            Console.WriteLine(restaurant);
            Console.WriteLine();
            Console.WriteLine($"Server: {server}");
            Console.WriteLine();
            Console.WriteLine($"Table Number: {tableNumber}");
            Console.WriteLine();

            for (int i = 0; i < 50; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();

            Console.Write(entry1);
            int posX = getPositionX();
            int posY = getPositionY();
            Console.SetCursorPosition(35, posY);
            Console.Write($"{priceEntry1}");

            Console.WriteLine();

            Console.Write(entry2);
            posX = getPositionX();
            posY = getPositionY();
            Console.SetCursorPosition(35, posY);
            Console.Write($"{priceEntry2}");
            
            Console.WriteLine();

            Console.Write(entry3);
            posX = getPositionX();
            posY = getPositionY();
            Console.SetCursorPosition(35, posY);
            Console.Write($"{priceEntry3}");

            Console.WriteLine();

            Console.Write(entry4);
            posX = getPositionX();
            posY = getPositionY();
            Console.SetCursorPosition(35, posY);
            Console.Write($"{priceEntry4}");

            Console.WriteLine();

            Console.Write(entry5);
            posX = getPositionX();
            posY = getPositionY();
            Console.SetCursorPosition(35, posY);
            Console.Write($"{priceEntry5}");

            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Tax:");
            posX = getPositionX();
            posY = getPositionY();
            Console.SetCursorPosition(35, posY);
            Console.Write($"{tax}");

            Console.WriteLine();

            Console.Write("Total:");
            posX = getPositionX();
            posY = getPositionY();
            Console.SetCursorPosition(35, posY);
            Console.Write($"{total}");

            Console.ReadLine();
        }

        private static int getPositionX()
        {
            int x = Console.CursorLeft;
            return x;
        }

        private static int getPositionY()
        {
            int y = Console.CursorTop;
            return y;
        }
    }
}
