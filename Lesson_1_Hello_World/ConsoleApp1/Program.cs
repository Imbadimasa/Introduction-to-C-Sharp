using System;

namespace ConsoleApp1
{
    class Program
    {
        [Flags]
        enum Months
        {
            December = 12,
            January = 1,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            Sepember,
            October,
            November
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Please input the number of the month");
            int numberOfTheMonth = Convert.ToInt32(Console.ReadLine());

            /*I really don't like how ugly the code looks like right now!!!! I wish I could cycle through values and make
            an easy comparison to values of the enum*/
            
            switch (numberOfTheMonth)
            {
                
                case 1:
                    Console.WriteLine($"We are experiencing {Months.January}.");
                    break;
                case 2:
                    Console.WriteLine($"We are experiencing {Months.February}.");
                    break;
                case 3:
                    Console.WriteLine($"We are experiencing {Months.March}.");
                    break;
                case 4:
                    Console.WriteLine($"We are experiencing {Months.April}.");
                    break;
                case 5:
                    Console.WriteLine($"We are experiencing {Months.May}.");
                    break;
                case 6:
                    Console.WriteLine($"We are experiencing {Months.June}.");
                    break;
                case 7:
                    Console.WriteLine($"We are experiencing {Months.July}.");
                    break;
                case 8:
                    Console.WriteLine($"We are experiencing {Months.August}.");
                    break;
                case 9:
                    Console.WriteLine($"We are experiencing {Months.Sepember}.");
                    break;
                case 10:
                    Console.WriteLine($"We are experiencing {Months.October}.");
                    break;
                case 11:
                    Console.WriteLine($"We are experiencing {Months.November}.");
                    break;
                case 12:
                    Console.WriteLine($"We are experiencing {Months.December}.");
                    break;
                default:
                    Console.WriteLine("Please enter the correct number");
                    break;
            }
            Console.ReadLine();
        }
    }
}
