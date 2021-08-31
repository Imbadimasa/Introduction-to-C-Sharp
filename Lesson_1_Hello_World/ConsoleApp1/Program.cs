using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int knowledges = 0b011111; // знания студента

            // Маски профессий:
            int backenderMask = 0b010111;
            int frontenderMask = 0b011010;
            int designerMask = 0b110000;

            // Те навыки из каждой профессии, которые присутствуют у студента:
            int backenderKnowledges = knowledges & backenderMask;
            int frontenderKnowledges = knowledges & frontenderMask;
            int designerKnowledges = knowledges & designerMask;

            // Если навыки полностью совпали с маской, мы получим True, иначе False
            Console.WriteLine(backenderKnowledges == backenderMask);
            Console.WriteLine(frontenderKnowledges == frontenderMask);
            Console.WriteLine(designerKnowledges == designerMask);

            Console.ReadLine();


        }
    }
}
