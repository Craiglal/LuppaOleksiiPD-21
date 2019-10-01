using System;

namespace Lab_3._21
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1, y1, x2, y2;
            bool a1, b1, a2, b2;

            do
            {
                Console.Write("Enter x1: ");
                a1 = int.TryParse(Console.ReadLine(), out x1);
                if (x1 < 1 || x1 > 8 || !a1)
                    Console.WriteLine("ERROR! Please enter number from 1 to 8");
            } while (x1 < 1 || x1 > 8 || !a1);

            do
            {
                Console.Write("Enter y1: ");
                b1 = int.TryParse(Console.ReadLine(), out y1);
                if (y1 < 1 || y1 > 8 || !b1)
                    Console.WriteLine("ERROR! Please enter number from 1 to 8");
            } while (y1 < 1 || y1 > 8 || !b1);

            Console.WriteLine(" ");

            do
            {
                Console.Write("Enter x2: ");
                a2 = int.TryParse(Console.ReadLine(), out x2);
                if (x2 < 1 || x2 > 8 || !a2)
                    Console.WriteLine("ERROR! Please enter number from 1 to 8");
            } while (x2 < 1 || x2 > 8 || !a2);

            do
            {
                Console.Write("Enter y2: ");
                b2 = int.TryParse(Console.ReadLine(), out y2);
                if (y2 < 1 || y2 > 8 || !b2)
                    Console.WriteLine("ERROR! Please enter number from 1 to 8");
            } while (y2 < 1 || y2 > 8 || !b2);

            Console.WriteLine();
            Console.WriteLine($"Result: {((x2 == x1 + 1 || x2 == x1 - 1) && (y2 == y1 + 2 || y2 == y1 - 2)) || ((x2 == x1 + 2 || x2 == x1 - 2) && (y2 == y1 + 1 || y2 == y1 - 1))}");
        }
    }
}
