using System;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, min = 0, max = 0;
            Random random = new Random();
            bool a;

            do
            {
                Console.Write("Enter N: ");
                a = int.TryParse(Console.ReadLine(), out N);
                if (!a)
                    Console.WriteLine("Error");
            } while (!a);
            int[] arr = new int[N];

            Console.WriteLine("Array: ");
            for (int i = 0; i < N; i++)
            {
                arr[i] = random.Next(0, 100);

                Console.Write($"{arr[i]} ");
            }

            for (int i = 0; i < N; i++)
            {
                if(i == 0)
                {
                    if (arr[i] < arr[i + 1])
                        min++;
                    else if (arr[i] > arr[i + 1])
                        max++;
                }
                else if (i + 1 == N)
                {
                    if (arr[i] < arr[i - 1])
                        min++;
                    else if (arr[i] > arr[i - 1])
                        max++;
                }
                else
                {
                    if (arr[i] < arr[i - 1] && arr[i] < arr[i + 1])
                        min++;
                    else if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
                        max++;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Minimums = {min}, maximums = {max}");
        }
    }
}
