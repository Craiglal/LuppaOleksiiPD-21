using System;

namespace _09._09_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double mult = 1.0;
            int nn, nk;
            bool a, b;

            do
            {
                a = int.TryParse(Console.ReadLine(), out nn);
                b = int.TryParse(Console.ReadLine(), out nk);
                if (!(a & b) || (nn < 0 || nk < nn))
                    Console.WriteLine("Error");
            } while (!(a & b) || (nn < 0 || nk < nn));

            for (int k = nn; k < nk; k++)
            {
                mult *= (Math.Pow(-1, k) * Math.Pow(k, 2) + Math.Pow(-1, Math.Pow(k, 2) + 1) * k) / (2 * Math.Pow(k, 3) + 3);
            }

            Console.WriteLine(mult);
        }
    }
}
