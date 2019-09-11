using System;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, n1, n2, n3;
            bool a;
            
            do
            {
                a = int.TryParse(Console.ReadLine(), out num);
                if (!a || num.ToString().Length != 3)
                    Console.WriteLine("Error");
            } while (!a || num.ToString().Length != 3);

            n3 = num % 10;
            n2 = (num / 10) % 10;
            n1 = (num / 100) % 10;
            Console.WriteLine($"Result: {n1 < n2 && n2 < n3}");
        }
    }
}
