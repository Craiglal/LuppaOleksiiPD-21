using System;

namespace _09._09_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double mult = 1.0;

            for (int k = 0; k < 50; k++)
            {
                mult *= (((-1) ^ k * k ^ 2 + (-1) ^ (k ^ (2 + 1)) * k) * (2 * k ^ 3 + 6 * k ^ 2 + 6 * k + 5)) / ((2 * k ^ 3 + 3) * (-1) ^ (k + 1) * (k ^ 2 + 2 * k + 1) + (-1) ^ (k ^ 2 + 2) * (k + 1));
            }

            Console.WriteLine(mult);
        }
    }
}
// (((-1) ^ k * k ^ 2 + (-1) ^ (k ^ (2 + 1)) * k) * (2 * k ^ 3 + 6 * k ^ 2 + 6 * k + 5)) / ((2 * k ^ 3 + 3) * (-1) ^ (k + 1) * (k ^ 2 + 2 * k + 1) + (-1) ^ (k ^ 2 + 2) * (k + 1))
// (Math.Pow(-1, k) * Math.Pow(k, 2) + Math.Pow(-1, Math.Pow(k, 2) + 1) * k) / (2 * Math.Pow(k, 3) + 3)
